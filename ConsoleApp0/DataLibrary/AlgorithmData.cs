using iFoundry.Entities;
using iFoundry.Shared;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class AlgorithmData
    {
        private static Database l_database;

        public AlgorithmData()
        {
            l_database = DBHelper.CreateDatabase();
        }
        public List<BlockData> GetBlocks()
        {
            List<BlockData> list = null;
            BlockData l_user = null;
            try
            {
                string strquery = @"SELECT ID_RLS,[DOCUMENT_RLS],[TYPE_RLS] FROM [dbo].[RULES_RLS] RLS where RLS.TYPE_RLS IN  ('pricer', 'FORMLOGIC', 'ErrorMessages', 'CommonRating', 'StatReporting', 'PolicyIndicator', 'PremiumCalculation', 'PremiumRollups','others')";

                using (DbCommand command = l_database.GetSqlStringCommand(strquery))
                {
                    //l_database.AddInParameter(command, "@EMAIL", DbType.String, userName);
                    //l_database.AddInParameter(command, "@PASSWORD", DbType.String, password);

                    DataSet l_dataset = l_database.ExecuteDataSet(command);
                    if (l_dataset != null && l_dataset.Tables.Count > 0 && l_dataset.Tables[0].Rows.Count > 0)
                    {

                        list = new List<BlockData>();
                        foreach (DataRow row in l_dataset.Tables[0].Rows)
                        {
                            l_user = new BlockData();
                            l_user.blockType = Convert.ToString(row["TYPE_RLS"]);
                            if (l_user.blockType.ToLower() == "pricer")
                                l_user.pricer = XMLExtensions.DeSerialize<PricerInfo>(Convert.ToString(row["DOCUMENT_RLS"]));
                            else if (l_user.blockType.ToLower() == "formlogic")
                                l_user.formRules = XMLExtensions.DeSerialize<FormRules>(Convert.ToString(row["DOCUMENT_RLS"]));

                            l_user.algoName = "";
                            l_user.displayName = "";
                            l_user.ruleId = Convert.ToInt32(row["ID_RLS"]);
                            list.Add(l_user);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                string exceptionMessage = ex.Errors[0].Message;

                throw new Exception(exceptionMessage);
            }
            catch (Exception ex)
            {

                throw;
            }
            return list;
        }

        public int SaveBlock(List<planFormulaInfo> planInfoList)
        {
            try
            {
                foreach (var planInfo in planInfoList)
                {
                    using (DbCommand command = l_database.GetStoredProcCommand("SP_MANAGE_BLOCK"))
                    {

                        l_database.AddInParameter(command, "@NAME_BLK", DbType.String, planInfo.Name);
                        l_database.AddInParameter(command, "@DISPLAY_NAME_BLK", DbType.String, planInfo.DisplayName);
                        l_database.AddInParameter(command, "@ANTLR_BLK", DbType.String, planInfo.antlr);
                        l_database.AddInParameter(command, "@STATEMENTS_BLK", DbType.String, planInfo.tokens);
                        l_database.AddInParameter(command, "@STATUS_BLK", DbType.String, "Active");
                        l_database.AddInParameter(command, "@ISDELETE", DbType.Boolean, false);
                        l_database.AddInParameter(command, "@ISTOKEN", DbType.Boolean, true);
                        l_database.AddInParameter(command, "@ID_RULES_MAP", DbType.Int32, planInfo.Rule_Id);
                        l_database.AddInParameter(command, "@RETURN_TYPE_BLK", DbType.String, planInfo.returnType);
                        l_database.AddInParameter(command, "@ID_BLK", DbType.Int32, 0);
                        int effId = 0;
                        object l_effid = l_database.ExecuteScalar(command);
                        if (l_effid != null)
                        {
                            int.TryParse(l_effid.ToString(), out effId);
                        }
                    }

                    //l_database.AddInParameter(command, "@ID_PLV_MAP", DbType.Boolean, planInfo.PlanVersionId);
                }
                return 0;
            }
            catch (SqlException ex)
            {
                string exceptionMessage = ex.Errors[0].Message;
                throw new Exception(exceptionMessage);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    public class BlockData
    {
        public int ruleId { get; set; }
        public planFormulaInfo planInfo
        {
            get; set;
        }

        public FormRules formRules
        {
            get; set;
        }

        public PricerInfo pricer
        {
            get; set;
        }

        public string algoName
        {
            get; set;
        }

        public string displayName
        {
            get; set;
        }
        public string blockType
        {
            get; set;
        }
    }
}

