using AlgorithmBuilder.AntlrUtility;
using AlgorithmBuilder.Models;
using DataLibrary;
using iFoundry.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace AntlrValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            AlgorithmData algData = new AlgorithmData();
            AntlrConverter antlrConverter = new AntlrConverter();
            TokenConverter tc = new TokenConverter();
            try
            {
                ObjectCache cache = MemoryCache.Default;
                var cachedObject = cache["algoList"];
                List<BlockData> l_algoList = null;
                if (cachedObject == null)
                {
                    l_algoList = algData.GetBlocks();

                    CacheItemPolicy policy = new CacheItemPolicy();
                    cachedObject = l_algoList;
                    cache.Set("algoList", cachedObject, policy);
                }
                else
                {
                    l_algoList = (List<BlockData>)cache.Get("algoList");
                }
                int count = 0;
                List<planFormulaInfo> l_planList = new List<planFormulaInfo>();
                foreach (var item in l_algoList)
                {
                    planFormulaInfo l_plan = null;
                    Console.WriteLine("Totlal count:" + l_algoList.Count());
                    BlockInfo l_blck = null;
                    if (item.planInfo != null)
                        foreach (var blck in item.planInfo.PlanFormula.ExpContent)
                        {
                            l_blck = antlrConverter.GetBlockInfo(blck.AntlrContent);
                            string l_err = tc.SetAntlr(l_blck);
                            l_plan = SetBlockStatements(l_blck, blck.AntlrContent, item.ruleId);
                            Console.WriteLine(blck.BlockName);
                            if (l_plan != null)
                                l_planList.Add(l_plan);
                        }
                    if (item.pricer != null)
                        foreach (var blck in item.pricer.PricerAlgorithm.ExpContent)
                        {
                            l_blck = antlrConverter.GetBlockInfo(blck.AntlrContent);
                            l_blck.IsPricer = true;
                            string l_err = tc.SetAntlr(l_blck);
                            l_plan = SetBlockStatements(l_blck, blck.AntlrContent, item.ruleId);
                            if (l_plan != null)
                                l_planList.Add(l_plan);
                            Console.WriteLine(item.pricer.Name + " " + blck.BlockName);
                        }
                    if (item.formRules != null)
                        foreach (var blck in item.formRules.blockExponents)
                        {
                            l_blck = antlrConverter.GetBlockInfo(blck.AntlrContent);
                            string l_err = tc.SetAntlr(l_blck);
                            l_plan = SetBlockStatements(l_blck, blck.AntlrContent, item.ruleId);
                            Console.WriteLine(item.formRules.formulaeName + " - " + blck.BlockName);
                            if (l_plan != null)
                                l_planList.Add(l_plan);
                        }
                    count++;
                    
                    Console.WriteLine(count);
                }
                algData.SaveBlock(l_planList);
                Console.WriteLine("Block validation finished");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Block validation failed");
            }
        }
        private static planFormulaInfo SetBlockStatements(BlockInfo l_blck, string antlr, int ruleId)
        {
            planFormulaInfo l_plan = new planFormulaInfo();
            l_plan.Name = l_blck.Name;
            l_plan.DisplayName = l_blck.Name;
            l_plan.antlr = antlr;
            l_plan.returnType = l_blck.ReturnType;
            l_plan.tokens = Newtonsoft.Json.JsonConvert.SerializeObject(l_blck.Statements);
            l_plan.Rule_Id = ruleId;

            return l_plan;
        }
    }
}
