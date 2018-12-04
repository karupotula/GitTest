using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmBuilder.Models;
using static System.Convert;
using System.Text.RegularExpressions;

namespace AlgorithmBuilder.AntlrUtility
{
    public class AntlrConverter
    {

        #region Public Methods
        public BlockInfo GetBlockInfo(string antlrString)
        {
            BlockInfo blockInfo = new BlockInfo();

            try
            {
                List<string> splitByHashStatements = antlrString.SplitBy(Constants.Semicolon);

                blockInfo.Name = GetAntlrBlockName(splitByHashStatements.First());
                //blockInfo.Context = GetAnltrBlockContext(splitByHashStatements.First());
                blockInfo.ReturnType = GetAntlrBlockReturnDataType(splitByHashStatements.First());
                blockInfo.ReturnVariable = GetAntlrBlockReturnToken(splitByHashStatements[splitByHashStatements.Count - 2]);
                blockInfo.BlockDef = GetAnltrBlockContext(splitByHashStatements.First());
                blockInfo.Statements = GetAntlrBlockAsStatement(antlrString);
            }
            catch (Exception ex)
            {
                throw;
            }

            return blockInfo;
        }

        public List<statement> GetAntlrBlockAsStatement(string antlrString)
        {
            //antlrString = "{metadata name Algo internalName daysDiffLiquor_1 Version3.0 isPricer False arguments(ObjectModel#GeneralLiability(datatype=GeneralLiability,cardinality=0)) (integer);if  NOT ( (ObjectModel#GeneralLiability(datatype=GeneralLiability,cardinality=0).Subline(datatype=string,cardinality=0) operandDisplayProperty \"GeneralLiability.Subline\"  EQ Constant#temp1(datatype=string,value=\"Premises/Operations\") operandDisplayProperty \"'Premises/Operations'\" OR ObjectModel#GeneralLiability(datatype=GeneralLiability,cardinality=0).Subline(datatype=string,cardinality=0) operandDisplayProperty \"GeneralLiability.Subline\"  EQ Constant#temp2(datatype=string,value=\"Products/Completed Operations\") operandDisplayProperty \"'Products/Completed Operations'\" OR ObjectModel#GeneralLiability(datatype=GeneralLiability,cardinality=0).Subline(datatype=string,cardinality=0) operandDisplayProperty \"GeneralLiability.Subline\"  EQ Constant#temp3(datatype=string,value=\"Premises/Operations and Products/Completed Operations\") operandDisplayProperty \"'Premises/Operations and Products/Completed Operations'\" )  AND xPath#xPath1(datatype=object , value=\"/PremOpsProdsCoverageForm\") operandDisplayProperty \"/PremOpsProdsCoverageForm\" NE null AND xPath#xPath2(datatype=string , value=\"/PremOpsProdsCoverageForm\") operandDisplayProperty \"/PremOpsProdsCoverageForm\" EQ Constant#temp4(datatype=string,value=\"Claims Made\") operandDisplayProperty \"'Claims Made'\" AND xPath#xPath3(datatype=object , value=\"/PremOpsProdsRetroactiveDate\") operandDisplayProperty \"/PremOpsProdsRetroactiveDate\" NE null AND xPath#xPath4(datatype=string , value=\"/PremOpsProdsRetroactiveDate\") operandDisplayProperty \"/PremOpsProdsRetroactiveDate\" NE Constant#temp5(datatype=string,value=\"\") operandDisplayProperty \"''\" )  displayProperty \"if  NOT ( (  GeneralLiability.Subline ==   'Premises/Operations' OR   GeneralLiability.Subline ==   'Products/Completed Operations' OR   GeneralLiability.Subline ==   'Premises/Operations and Products/Completed Operations' )  AND   xPath(/PremOpsProdsCoverageForm) !=   null AND   xPath(/PremOpsProdsCoverageForm) ==   'Claims Made' AND   xPath(/PremOpsProdsRetroactiveDate) !=   null AND   xPath(/PremOpsProdsRetroactiveDate) != method convertStringToDate(   '' ) )  \" then if ObjectModel#GeneralLiability(datatype=GeneralLiability,cardinality=0).Subline(datatype=string,cardinality=0) operandDisplayProperty \"GeneralLiability.Subline\"  EQ Constant#temp6(datatype=string,value=\"Liquor\") operandDisplayProperty \"'Liquor'\" AND xPath#xPath5(datatype=object , value=\"/LiquorCoverageForm\") operandDisplayProperty \"/LiquorCoverageForm\" NE null AND xPath#xPath6(datatype=string , value=\"/LiquorCoverageForm\") operandDisplayProperty \"/LiquorCoverageForm\" EQ Constant#temp7(datatype=string,value=\"Claims Made\") operandDisplayProperty \"'Claims Made'\" AND xPath#xPath7(datatype=object , value=\"/LiquorRetroactiveDate\") operandDisplayProperty \"/LiquorRetroactiveDate\" NE null AND xPath#xPath8(datatype=string , value=\"/LiquorRetroactiveDate\") operandDisplayProperty \"/LiquorRetroactiveDate\" NE Constant#temp8(datatype=string,value=\"\") operandDisplayProperty \"''\" displayProperty \"if   GeneralLiability.Subline ==   'Liquor' AND   xPath(/LiquorCoverageForm) !=   null AND   xPath(/LiquorCoverageForm) ==   'Claims Made' AND   xPath(/LiquorRetroactiveDate) !=   null AND   xPath(/LiquorRetroactiveDate) != method convertStringToDate(   '' )\" then Variable#daysDiffLiquor_1(datatype=integer,cardinality=0,scope=local) operandDisplayProperty \"daysDiffLiquor_1\" = method convertDoubleToInteger(  method timeSpan(method EffectiveDt(ObjectModel#GeneralLiability(datatype=GeneralLiability,cardinality=0)) datetime,xPath#xPath9(datatype=datetime , value=\"/LiquorRetroactiveDate\") operandDisplayProperty \"/LiquorRetroactiveDate\" ) ) displayProperty \" daysDiffLiquor_1 = method timeSpan(  callBlock EffectiveDt() ,  xPath(/LiquorRetroactiveDate) ) \" ; endif ; endif ; return Variable#daysDiffLiquor_1(datatype=integer,cardinality=0,scope=local) operandDisplayProperty \"daysDiffLiquor_1\"; } ";
            List<statement> l_statements;

            try
            {
                //removing all display strings from antlr string
                antlrString = RemoveAllDisplayStrings(antlrString);

                //check and insert space for specific anltr string
                antlrString = AdjustSpaceToAntlr(antlrString);

                l_statements = GetMultiStatement(antlrString);
            }
            catch (Exception ex)
            {
                throw;
            }
            return l_statements;
        }
        #endregion

        #region private methods

        private string GetAntlrBlockName(string antlrString)
        {
            if (antlrString.StartsWith("{metadata"))
                return antlrString.SplitBy("internalName")[1].SplitBy(" ").First();
            else
                return string.Empty;
        }

        private List<Token> GetAnltrBlockContext(string antlrString)
        {
            try
            {
                string objmdlStr = antlrString.GetBraceBetweenString('(', ')');
                if (objmdlStr.StartsWith(Constants.ObjectModel))
                    return new List<Token>() { GetObjectModelToken(objmdlStr) };
            }
            catch (Exception ex)
            {
                throw;
            }
            return new List<Token>();
        }

        public Token GetAntlrBlockReturnToken(string antlrString)
        {
            Token token = null;
            try
            {
                if (antlrString.StartsWith(Constants.Return))
                {
                    antlrString = antlrString.Substring(Constants.Return.Length);
                    if (antlrString.StartsWith(Constants.ObjectModel))
                        return GetObjectModelToken(antlrString);
                    else if (antlrString.StartsWith(Constants.Variable))
                        return GetVariableToken(antlrString);

                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return token;
        }

        private string GetAntlrBlockReturnDataType(string antlrString)
        {
            if (antlrString.StartsWith("{metadata"))
            {
                var aa = antlrString.SplitBy(" ");
                if (aa.LastOrDefault().StartsWith("(") && aa.LastOrDefault().EndsWith(")"))
                    return aa.LastOrDefault().GetBraceBetweenString('(', ')');
            }

            return Constants.Void;
        }

        private List<statement> GetMultiStatement(string antlrString)
        {
            List<statement> l_statements = new List<statement>();

            List<string> splitByHashStatements = antlrString.SplitBy(Constants.Semicolon);

            try
            {
                splitByHashStatements = CheckContinuesAntlrStrings(splitByHashStatements, new List<string>());

                foreach (var stmnt in splitByHashStatements)
                {
                    if (IsSkipStatment(stmnt))
                        continue;
                    else if (stmnt.StartsWith(Constants.If))
                        l_statements.Add(GetIfStatement(stmnt));
                    else if (stmnt.StartsWith(Constants.forAll))
                        l_statements.Add(GetForAllStatement(stmnt));
                    else
                        l_statements.Add(GetSimpleStatement(stmnt));
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return l_statements;
        }


        private statement GetForAllStatement(string antlrStr)
        {
            statement stmnt = new statement() { type = Constants.For };
            string antlrSubStr = string.Empty;
            try
            {
                string forAllAntlrStr = GetForAllAntlrString(ref antlrStr);

                antlrSubStr = GetForAllConditionString(ref forAllAntlrStr);
                stmnt.condition = GetConditionTokens(antlrSubStr);

                antlrSubStr = GetForAllActionString(forAllAntlrStr);
                stmnt.action = GetMultiStatement(antlrSubStr);
            }
            catch (Exception ex)
            {
                throw;
            }
            return stmnt;
        }

        private string GetForAllAntlrString(ref string antlStr)
        {
            List<int> ifStmnts = new List<int>();
            List<string> splitBySpace = antlStr.SplitBy(' ');
            string forAllAntlrStr = string.Empty;


            try
            {
                for (int i = 0; i <= splitBySpace.Count - 1; i++)
                {
                    if (splitBySpace[i].Equals(Constants.forAll))
                        ifStmnts.Add(i);

                    else if (splitBySpace[i].Equals(Constants.endForAll))
                    {
                        if (ifStmnts.Count > 1)
                            ifStmnts.Remove(ifStmnts.LastOrDefault());
                        else
                        {
                            forAllAntlrStr = string.Join(" ", splitBySpace.SubList(ifStmnts.First(), i + 1));
                            antlStr = string.Join(" ", splitBySpace.SubList(i + 1)).Trim(';').Trim();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return forAllAntlrStr;
        }

        private string GetForAllActionString(string antlrStr)
        {
            try
            {
                List<int> openbrases = new List<int>();

                for (int i = 0; i <= antlrStr.Length - 1; i++)
                {
                    if (antlrStr[i].Equals('['))
                        openbrases.Add(i);

                    else if (antlrStr[i].Equals(']'))
                    {
                        if (openbrases.Count > 1)
                            openbrases.Remove(openbrases.LastOrDefault());
                        else
                            return antlrStr.Slice(openbrases.First() + 1, i).Trim();
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return string.Empty;
        }

        private string GetForAllConditionString(ref string forAllAntlrStr)
        {
            forAllAntlrStr = forAllAntlrStr.Substring(6).Trim();

            if (forAllAntlrStr.StartsWith(Constants.ObjectModel))
                return GetObjectModelAntlrString(ref forAllAntlrStr);

            else if (forAllAntlrStr.StartsWith(Constants.xPath))
                return GetXpathAntlrString(ref forAllAntlrStr);

            else
                throw new Exception(message: "ForAll failed");
        }

        private bool IsSkipStatment(string antlrStr)
        {
            if (antlrStr.StartsWith(Constants.Return))
                return true;
            else if (antlrStr.Equals(Constants.Close))
                return true;
            else if (antlrStr.StartsWith("{metadata "))
                return true;
            else
                return false;
        }

        private statement GetIfStatement(string ifAntlrStr)
        {
            statement stmnt = new statement() { type = Constants.If };
            string antlrStr = string.Empty;

            try
            {
                string ifStmntAntlrStr = GetIfAntlrString(ref ifAntlrStr);

                //if condition antlr to tokens
                antlrStr = GetConditionAntlString(ifStmntAntlrStr, Constants.If);
                stmnt.condition = GetConditionTokens(antlrStr);

                //then antlr to statements
                antlrStr = GetThenAnltrString(ifStmntAntlrStr);
                stmnt.action = GetMultiStatement(antlrStr);

                //elseif antlr to statements
                List<string> antlrStrs = GetElseIfAnltrStrings(ifStmntAntlrStr);
                if (antlrStrs.AnyItems())
                    stmnt.statements = GetElseIfStatements(antlrStrs);

                //else antlr to statements
                antlrStr = GetElseAnltrString(ifStmntAntlrStr);
                if (!string.IsNullOrEmpty(antlrStr))
                {
                    stmnt.statements = stmnt.statements ?? new List<statement>();
                    stmnt.statements.AddRange(GetElseStatement(antlrStr));
                }

            }
            catch (Exception ex)
            {
                throw;
            }

            return stmnt;
        }


        private List<statement> GetElseIfStatements(List<string> elseIfAntlrStrs)
        {
            string antlrStr = string.Empty;
            List<statement> l_stmnts = new List<statement>();
            statement elseifStmnt = null;

            foreach (var elseIfAntlrStr in elseIfAntlrStrs)
            {
                elseifStmnt = new statement() { type = "elseIf" };

                //elseif condition token
                antlrStr = GetConditionAntlString(elseIfAntlrStr, Constants.Elseif);
                elseifStmnt.condition = GetConditionTokens(antlrStr);


                //elseif then statement
                antlrStr = GetElseIfThenAnltrString(elseIfAntlrStr);
                elseifStmnt.action = GetMultiStatement(antlrStr);

                l_stmnts.Add(elseifStmnt);

            }

            return l_stmnts;
        }

        private string GetElseIfThenAnltrString(string elseIfAntlrStr)
        {
            int indxOfthen = elseIfAntlrStr.IndexOf(" then ");
            if (indxOfthen == -1)
                throw new Exception();

            return elseIfAntlrStr.Substring(indxOfthen + 6);

        }


        private List<string> GetElseIfAnltrStrings(string antlrStr)
        {
            List<string> l_elseIfAntlrStrs = new List<string>();

            List<int> ifStmnts = new List<int>();
            List<int> elseifStmnts = new List<int>();


            try
            {
                List<string> splitBySpace = antlrStr.SplitBy(' ');

                for (int i = 0; i <= splitBySpace.Count - 1; i++)
                {
                    if (splitBySpace[i].Equals(Constants.If))
                        ifStmnts.Add(i);

                    else if (ifStmnts.Count == 1 && splitBySpace[i].Equals(Constants.Elseif))
                    {
                        if (elseifStmnts.Count > 0)
                        {
                            l_elseIfAntlrStrs.Add(string.Join(" ", splitBySpace.SubList(elseifStmnts.Last(), i)));
                            elseifStmnts.Remove(elseifStmnts.Last());
                        }

                        elseifStmnts.Add(i);
                    }

                    else if (splitBySpace[i].EqualsAny(Constants.Else, Constants.endif))
                    {

                        if (elseifStmnts.Count > 0)
                        {
                            l_elseIfAntlrStrs.Add(string.Join(" ", splitBySpace.SubList(elseifStmnts.Last(), i)));
                            elseifStmnts.Remove(elseifStmnts.Last());
                        }
                        else if (splitBySpace[i].Equals(Constants.endif) && ifStmnts.Count > 1) //then item is endif so we removing the if stmnt                        
                            ifStmnts.Remove(ifStmnts.LastOrDefault());
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return l_elseIfAntlrStrs;
        }

        private string GetThenAnltrString(string antlrStr)
        {
            List<int> ifStmnts = new List<int>();
            int thenCloseIndex = 0;

            try
            {
                int indxOfthen = antlrStr.IndexOf(" then ");

                if (indxOfthen == -1)
                    throw new Exception();

                antlrStr = antlrStr.Substring(indxOfthen + 6);
                List<string> splitBySpace = antlrStr.SplitBy(' ');

                for (int i = 0; i <= splitBySpace.Count - 1; i++)
                {
                    if (splitBySpace[i].Equals(Constants.If))
                        ifStmnts.Add(i);

                    else if (splitBySpace[i].EqualsAny(Constants.Elseif, Constants.Else, Constants.endif))
                    {

                        if (!ifStmnts.AnyItems())
                            return string.Join(" ", splitBySpace.SubList(0, (thenCloseIndex != 0 ? thenCloseIndex : i)));

                        else if (splitBySpace[i].EqualsAny(Constants.Elseif, Constants.Else))
                            thenCloseIndex = i;

                        else if (ifStmnts.Count > 0) //then item is endif so we removing the if stmnt
                        {
                            ifStmnts.Remove(ifStmnts.LastOrDefault());
                            thenCloseIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return string.Empty;
        }

        private List<statement> GetElseStatement(string elseAntlrStr)
        {
            List<statement> stmnts = new List<statement>();

            try
            {
                statement stmnt = new statement() { type = Constants.Else };
                elseAntlrStr = elseAntlrStr.Substring(5).TrimEnd(Constants.Semicolon).Trim();
                elseAntlrStr = elseAntlrStr.EndsWith(Constants.endif) ? elseAntlrStr.Substring(0, (elseAntlrStr.Count() - 5)).Trim() : elseAntlrStr;
                stmnt.action = GetMultiStatement(elseAntlrStr);
                stmnts.Add(stmnt);
            }
            catch (Exception ex)
            {
                throw;
            }

            return stmnts;
        }

        private List<Token> GetConditionTokens(string conditionAntlrStr)
        {
            return GetSimpleStatementTokens(conditionAntlrStr);
        }

        private string GetConditionAntlString(string ifStatemnet, string conditionType)
        {
            int indxOfthen = ifStatemnet.IndexOf(" then ");
            if (indxOfthen == -1)
                throw new Exception();

            return ifStatemnet.Substring(conditionType.Length + 1, (indxOfthen - (conditionType.Length + 1))).Trim();
        }


        private string GetIfAntlrString(ref string antlStr)
        {
            List<int> ifStmnts = new List<int>();
            List<string> splitBySpace = antlStr.SplitBy(' ');
            string ifAntlrStr = string.Empty;

            try
            {

                for (int i = 0; i <= splitBySpace.Count - 1; i++)
                {
                    if (splitBySpace[i].Equals(Constants.If))
                        ifStmnts.Add(i);

                    else if (splitBySpace[i].Equals(Constants.endif))
                    {
                        if (ifStmnts.Count > 1)
                            ifStmnts.Remove(ifStmnts.LastOrDefault());
                        else
                        {
                            ifAntlrStr = string.Join(" ", splitBySpace.SubList(ifStmnts.First(), i + 1));
                            antlStr = string.Join(" ", splitBySpace.SubList(i + 1)).Trim(';').Trim();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return ifAntlrStr;
        }

        private string GetElseAnltrString(string antlStr)
        {
            List<int> ifStmnts = new List<int>();
            List<string> splitBySpace = antlStr.SplitBy(' ');
            string elseAntlrStr = string.Empty;

            try
            {
                int i = 0;

                for (i = 0; i <= splitBySpace.Count - 1; i++)
                {
                    if (splitBySpace[i].Equals(Constants.If))
                        ifStmnts.Add(i);

                    else if (splitBySpace[i].Equals(Constants.Else))
                    {
                        if (ifStmnts.Count > 1)
                            ifStmnts.Remove(ifStmnts.LastOrDefault());
                        else
                        {
                            elseAntlrStr = string.Join(" ", splitBySpace.SubList(i));
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return elseAntlrStr;
        }

        private List<string> CheckContinuesAntlrStrings(List<string> splitByHashStatements, List<string> l_statements)
        {
            string antlrSubStatement = string.Empty;
            int ifindx = splitByHashStatements.ToList().FindIndex(p => p.StartsWith(Constants.If));
            int forAllindx = splitByHashStatements.ToList().FindIndex(p => p.StartsWith(Constants.forAll));

            try
            {
                if (ifindx != -1 && ((forAllindx == -1) || forAllindx > ifindx)) // check which is first statement
                {
                    if (ifindx != 0)
                        l_statements.AddRange(splitByHashStatements.SubList(0, ifindx).ToList());

                    string antlrStr = string.Join(" ; ", splitByHashStatements.SubList(ifindx));

                    while (antlrStr.StartsWith(Constants.If))
                    {
                        antlrSubStatement = GetIfAntlrString(ref antlrStr);

                        l_statements.Add(antlrSubStatement);
                    }
                    splitByHashStatements = antlrStr.SplitBy(Constants.Semicolon);

                    if (splitByHashStatements.AnyItems())
                        l_statements = CheckContinuesAntlrStrings(splitByHashStatements, l_statements);
                }
                else if (forAllindx != -1)
                {
                    if (forAllindx != 0)
                        l_statements.AddRange(splitByHashStatements.SubList(0, forAllindx).ToList());

                    string antlrStr = string.Join(" ; ", splitByHashStatements.SubList(forAllindx));

                    while (antlrStr.StartsWith(Constants.forAll))
                    {
                        antlrSubStatement = GetForAllAntlrString(ref antlrStr);

                        l_statements.Add(antlrSubStatement);
                    }

                    splitByHashStatements = antlrStr.SplitBy(Constants.Semicolon);

                    if (splitByHashStatements.AnyItems())
                        l_statements = CheckContinuesAntlrStrings(splitByHashStatements, l_statements);
                }
                else
                    l_statements.AddRange(splitByHashStatements);
            }
            catch (Exception ex)
            {
                throw;
            }

            return l_statements;
        }




        private statement GetSimpleStatement(string antlStr)
        {
            return new statement() { type = "simple", tokenList = GetSimpleStatementTokens(antlStr) };
        }

        private List<Token> GetSimpleStatementTokens(string antlStr)
        {
            List<Token> tokenList = null;

            try
            {
                List<string> multpleStatemnets = GetMultiAntlrStatements(antlStr.Trim());

                if (multpleStatemnets.AnyItems())
                {
                    tokenList = new List<Token>();

                    foreach (var item in multpleStatemnets)
                    {
                        if (item.StartsWithAny(Constants.Operators))
                            tokenList.Add(GetOperatorToken(item));

                        else if (item.StartsWithAny(Constants.method, Constants.lookup))
                            tokenList.Add(GetBlockTypeToken(item));

                        else if (item.StartsWith(Constants.NOT))
                            tokenList.Add(GetNotFunctionToken(item));

                        else if (item.StartsWith(Constants.callBlock))
                            tokenList.Add(GetCallBlockToken(item));

                        else if (item.StartsWith(Constants.Variable))
                            tokenList.Add(GetVariableToken(item));

                        else if (item.StartsWith(Constants.Constant))
                            tokenList.Add(GetConstantToken(item));

                        else if (item.StartsWith(Constants.xPath))
                            tokenList.Add(GetXpathToken(item));

                        else if (item.StartsWith(Constants.ObjectModel))
                            tokenList.Add(GetObjectModelToken(item)); //factor and factorGroup

                        else if (item.StartsWith(Constants.Null))
                            tokenList.Add(GetNullToken(item));

                        else if (item.EqualsAny("(", ")", "]", "[", ","))
                            tokenList.Add(GetBraceTypeToken(item));

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return tokenList;
        }

        private Token GetNullToken(string item)
        {
            Token token = new Token();
            token.name = token.displayName = token.id = token.value = item;
            token.tokenType = item;
            return token;
        }

        private Token GetBraceTypeToken(string item)
        {
            return GetOperatorToken(item);
        }

        private Token GetXpathToken(string xpathAntlr)
        {
            Token token = new Token();

            token.datatype = GetSpecificValueFromAnltrStr(xpathAntlr, Constants.datatype);
            token.value = GetXpathValueFromAnltrStr(xpathAntlr);
            token.name = token.displayName = token.id = $"xPath({token.value })";
            token.tokenType = Constants.xPath;

            return token;
        }

        private Token GetConstantToken(string constantAnltr)
        {
            Token token = new Token();
            token.name = token.id = constantAnltr.GetStringRange('#', '(');
            token.datatype = GetSpecificValueFromAnltrStr(constantAnltr, Constants.datatype);
            if (token.datatype == Constants.String)
            {
                token.displayName = token.value = GetLiteralSpecificValueFromAnltrStr(constantAnltr, Constants.value);

                token.displayName = token.value = "\"" + token.value + "\"";
            }
            else
                token.displayName = token.value = GetSpecificValueFromAnltrStr(constantAnltr, Constants.value);
            token.tokenType = "literal";
            return token;
        }

        private string GetSpecificValueFromAnltrStr(string antlrStr, string tagName)
        {
            List<string> values = antlrStr.SplitBy(tagName);

            return values.Count > 1 ? values[1].SplitBy("=", ",", ")").FirstOrDefault().Trim() : string.Empty;
        }

        private string GetLiteralSpecificValueFromAnltrStr(string antlrStr, string tagName)
        {
            List<string> values = antlrStr.SplitBy(tagName);

            var indxs = values[1].IndexListOf("\"");

            return values[1].Slice(indxs[0] + 1, indxs[1]);
        }
        private string GetXpathValueFromAnltrStr(string antlrStr)
        {
            List<string> values = antlrStr.SplitBy(Constants.value);
            if (values[1].Contains("\""))
            {
                int[] qouetsIndx = values[1].IndexListOf("\"");

                return qouetsIndx.Count() > 1 ? values[1].Slice(qouetsIndx[0] + 1, qouetsIndx[1]) : string.Empty;
            }
            return string.Empty;
        }


        private Token GetVariableToken(string varibleAntlrStr)
        {
            Token token = new Token();
            token.name = token.displayName = token.id = token.value = varibleAntlrStr.GetStringRange('#', '(');

            token.datatype = GetSpecificValueFromAnltrStr(varibleAntlrStr, Constants.datatype);
            if (varibleAntlrStr.Contains(Constants.cardinality))
                token.cardinality = ToInt32(GetSpecificValueFromAnltrStr(varibleAntlrStr, Constants.cardinality));
            token.tokenType = GetSpecificValueFromAnltrStr(varibleAntlrStr, Constants.scope).ToLower() == Constants.local ? tokentypes.localVariable.ToString() : tokentypes.globalVariable.ToString();
            return token;


        }

        private Token GetOperatorToken(string operatorAntlr)
        {
            Token token;

            switch (operatorAntlr)
            {
                case "NE":
                    token = new Token() { id = "notequal", value = "NE", displayName = "!=", datatype = "relational" };
                    break;
                case "EQ":
                    token = new Token() { id = "doubleequal", value = "EQ", displayName = "==", datatype = "relational" };
                    break;
                case "=":
                    token = new Token() { id = "equal", value = "=", displayName = "=", datatype = "assignment" };
                    break;
                case "LT":
                    token = new Token() { id = "lessthan", value = "LT", displayName = "<", datatype = "relational" };
                    break;
                case "GT":
                    token = new Token() { id = "greaterthan", value = "GT", displayName = ">", datatype = "relational" };
                    break;
                case "LE":
                    token = new Token() { id = "lessthanequal", value = "LE", displayName = "<=", datatype = "relational" };
                    break;
                case "GE":
                    token = new Token() { id = "greaterthanequal", value = "GE", displayName = ">=", datatype = "relational" };
                    break;
                case "OR":
                    token = new Token() { id = "OR", value = "OR", displayName = "OR", datatype = "logical" };
                    break;
                case "AND":
                    token = new Token() { id = "AND", value = "AND", displayName = "AND", datatype = "logical" };
                    break;
                case "+":
                    token = new Token() { id = "plus", value = "+", displayName = "+", datatype = "arithmetic" };
                    break;
                case "-":
                    token = new Token() { id = "minus", value = "-", displayName = "-", datatype = "arithmetic" };
                    break;
                case "*":
                    token = new Token() { id = "into", value = "*", displayName = "x", datatype = "arithmetic" };
                    break;
                case "/":
                    token = new Token() { id = "slash", value = "/", displayName = "/", datatype = "arithmetic" };
                    break;

                case "(":
                    token = new Token() { id = "bracketopen", value = "(", displayName = "(", datatype = "grouping" };
                    break;

                case ")":
                    token = new Token() { id = "bracketclose", value = ")", displayName = ")", datatype = "grouping" };
                    break;

                case "[":
                    token = new Token() { id = "squarebracketopen", value = "[", displayName = "[", datatype = "propertyaccessors" };
                    break;

                case "]":
                    token = new Token() { id = "squarebracketclose", value = "]", displayName = "]", datatype = "propertyaccessors" };
                    break;

                case ",":
                    token = new Token() { id = "comma", value = ",", displayName = ",", datatype = "parameterseparator" };
                    break;

                default:
                    token = new Token();
                    break;
            }

            token.tokenType = "operator";
            token.name = token.id;
            return token;
        }

        private List<string> GetMultiAntlrStatements(string antlrStr)
        {
            List<string> l_multistatments = new List<string>();

            int exceptionCount = 0;

            try
            {
                do
                {
                    if (antlrStr.StartsWithAny(Constants.Operators))
                        l_multistatments.Add(GetOperatorAntlrString(ref antlrStr));

                    else if (antlrStr.StartsWith(Constants.Variable))
                        l_multistatments.Add(GetVaribleAntlrString(ref antlrStr));

                    else if (antlrStr.StartsWithAny(Constants.method, Constants.lookup, Constants.NOT))
                        l_multistatments.Add(GetBlockTypeAntlrString(ref antlrStr));

                    else if (antlrStr.StartsWith(Constants.callBlock))
                        l_multistatments.Add(GetCallBlockAntlrString(ref antlrStr));

                    else if (antlrStr.StartsWith(Constants.xPath))
                        l_multistatments.Add(GetXpathAntlrString(ref antlrStr));

                    else if (antlrStr.StartsWith(Constants.ObjectModel))
                        l_multistatments.Add(GetObjectModelAntlrString(ref antlrStr));

                    else if (antlrStr.StartsWith(Constants.Constant))
                        l_multistatments.Add(GetConstantAntlrString(ref antlrStr));

                    else if (antlrStr.StartsWithAny("(", ")", "]", "[", ","))
                        l_multistatments.Add(GetBraceAntlrString(ref antlrStr));

                    else if (antlrStr.StartsWith(Constants.Null))
                        l_multistatments.Add(GetNullAntlrString(ref antlrStr));
                    else
                        antlrStr = CheckIsEndAntlrStrings(antlrStr, exceptionCount++);

                } while (!string.IsNullOrEmpty(antlrStr));
            }
            catch (Exception ex)
            {
                throw;
            }

            return l_multistatments;
        }



        private string GetObjectModelAntlrString(ref string antlrStr)
        {
            string objectModelStr = string.Empty;
            int[] doubleQuetoIndx = antlrStr.IndexListOf("\"");

            objectModelStr = antlrStr.Substring(0, doubleQuetoIndx[1] + 1);
            antlrStr = antlrStr.Substring(doubleQuetoIndx[1] + 1).Trim();

            return objectModelStr;
        }

        private string CheckIsEndAntlrStrings(string antlrStr, int exceptionCount)
        {
            antlrStr = antlrStr.StartsWith(";") ? antlrStr.TrimStart(';') : antlrStr;
            antlrStr = antlrStr.StartsWith(Constants.endif) ? antlrStr.Substring(5) : antlrStr;
            if (exceptionCount == 3)
                throw new Exception(message: "something went to wrong");

            return antlrStr.Trim();
        }

        private string GetNullAntlrString(ref string antlrStr)
        {
            antlrStr = antlrStr.Substring(4).Trim();
            return Constants.Null;
        }

        private string GetBraceAntlrString(ref string antlrStr)
        {
            string brace = antlrStr.Substring(0, 1);
            antlrStr = antlrStr.Substring(1).Trim();
            return brace;
        }

        private string GetConstantAntlrString(ref string antlrStr)
        {
            string l_constantAntlr = string.Empty;

            try
            {

                List<int> openbrases = new List<int>();

                int i = 0;

                for (i = 0; i <= antlrStr.Length - 1; i++)
                {
                    if (antlrStr[i].Equals('('))
                        openbrases.Add(i);

                    else if (antlrStr[i].Equals(')'))
                    {
                        if (openbrases.Count > 1)
                            openbrases.Remove(openbrases.LastOrDefault());
                        else
                        {
                            l_constantAntlr = antlrStr.Substring(0, i + 1);
                            antlrStr = antlrStr.Substring(i + 1).Trim();
                            if (antlrStr.StartsWith(Constants.operandDisplayProperty))
                            {
                                int[] doublesQueotsIndx = antlrStr.IndexListOf("\"");
                                l_constantAntlr = $"{l_constantAntlr} {antlrStr.Substring(0, doublesQueotsIndx[1] + 1)}".Trim();
                                antlrStr = antlrStr.Substring(doublesQueotsIndx[1] + 1).Trim();
                            }
                            return l_constantAntlr;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return l_constantAntlr;
        }

        private string GetXpathAntlrString(ref string antlrStr)
        {
            string l_xpathAntlr = string.Empty;

            try
            {
                int[] quetosIndex = antlrStr.IndexListOf("\"");

                if (quetosIndex.Count() > 3)
                {
                    l_xpathAntlr = antlrStr.Substring(0, quetosIndex[3] + 1);
                    antlrStr = antlrStr.Substring(quetosIndex[3] + 1).Trim();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return l_xpathAntlr;
        }

        private string GetOperatorAntlrString(ref string antlrStr)
        {
            //getting opeator by split with space
            List<string> data = antlrStr.SplitBy(" ");

            // updating antlStr after pick operator
            antlrStr = string.Join(" ", data.Skip(1)).Trim();

            return data.FirstOrDefault();
        }

        private string GetVaribleAntlrString(ref string antlrStr)
        {
            string l_varibleAntlr = string.Empty;

            try
            {
                int[] quetosIndex = antlrStr.IndexListOf("\"");

                if (quetosIndex.Count() > 1)
                {
                    l_varibleAntlr = antlrStr.Substring(0, quetosIndex[1] + 1);
                    antlrStr = antlrStr.Substring(quetosIndex[1] + 1).Trim();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return l_varibleAntlr;
        }

        private string GetBlockTypeAntlrString(ref string antlrStr)
        {

            List<int> openbrases = new List<int>();
            string block = string.Empty;

            int i = 0;

            for (i = 0; i <= antlrStr.Length - 1; i++)
            {
                if (antlrStr[i].Equals('('))
                    openbrases.Add(i);

                else if (antlrStr[i].Equals(')'))
                {
                    if (openbrases.Count > 1)
                        openbrases.Remove(openbrases.LastOrDefault());
                    else
                    {
                        block = antlrStr.Substring(0, i + 1);
                        antlrStr = antlrStr.Substring(i + 1).Trim();
                        block = $"{block} {CheckIsDataType(ref antlrStr)}".Trim();
                        break;
                    }

                }
            }

            return block;
        }

        private string CheckIsDataType(ref string p_data)
        {
            string dataType = string.Empty;
            if (p_data.StartsWithAny(Constants.String, Constants.Double, Constants.bolean, Constants.Object))
            {
                dataType = p_data.Substring(0, 6);
                p_data = p_data.Substring(6);
            }
            else if (p_data.StartsWith(Constants.datetime))
            {
                dataType = p_data.Substring(0, 8);
                p_data = p_data.Substring(8);
            }
            else if (p_data.StartsWith(Constants.integer))
            {
                dataType = p_data.Substring(0, 7);
                p_data = p_data.Substring(7);
            }
            else if (p_data.StartsWith(Constants.date))
            {
                dataType = p_data.Substring(0, 4);
                p_data = p_data.Substring(4);
            }
            return dataType.Trim();

        }

        private string GetCallBlockAntlrString(ref string antlrStr)
        {
            List<int> openbrases = new List<int>();
            string block = string.Empty;

            int i = 0;

            for (i = 0; i <= antlrStr.Length - 1; i++)
            {
                if (antlrStr[i].Equals('['))
                    openbrases.Add(i);

                else if (antlrStr[i].Equals(']'))
                {
                    if (openbrases.Count > 1)
                        openbrases.Remove(openbrases.LastOrDefault());
                    else
                    {
                        block = antlrStr.Substring(0, i + 1);
                        antlrStr = antlrStr.Substring(i + 1).Trim();
                        block = $"{block} {CheckIsDataType(ref antlrStr)}".Trim();
                        break;
                    }

                }
            }

            return block;
        }


        private string AdjustSpaceToAntlr(string antlrString)
        {
            //check before and after space for operandDisplayProperty
            antlrString = AdjustSpaceToAntlr(antlrString, Constants.operandDisplayProperty);

            antlrString = antlrString.Replace($"[if ", "[ if ")
                .Replace($"\"if ", "\" if ")
                .Replace($")if ", ") if ")
                .Replace($";if ", "; if ")
                .Replace("[forAll ", "[ forAll ")
                .Replace("=lookup ", "= lookup ");

            return antlrString;
        }

        private string AdjustSpaceToAntlr(string antlrString, string keyWord)
        {
            int[] opdispIndexArry = antlrString.IndexListOf(keyWord);
            int lettrsCount = keyWord.Count();
            int addingSpaceCount = 0;

            foreach (var item in opdispIndexArry)
            {
                if (antlrString[(item - 1) + addingSpaceCount] != ' ')
                    antlrString = antlrString.Insert(((item - 1) + addingSpaceCount++), " ");

                if (antlrString[item + lettrsCount + addingSpaceCount] != ' ')
                    antlrString = antlrString.Insert((item + lettrsCount + addingSpaceCount++), " ");
            }
            return antlrString.Trim();

        }

        private string RemoveAllDisplayStrings(string antlrString)
        {
            StringBuilder l_antlrString = new StringBuilder();
            string withOutDoubleQuetos = string.Empty;

            try
            {
                List<string> splitByDispStrings = antlrString.SplitBy(Constants.displayProperty);

                l_antlrString.Append(splitByDispStrings.First());

                foreach (var item in splitByDispStrings.Skip(1))
                {
                    withOutDoubleQuetos = RemoveDoubleQuetoStr(item);
                    withOutDoubleQuetos = withOutDoubleQuetos.StartsWithAny(" ", Constants.Semicolon) ? withOutDoubleQuetos : " " + withOutDoubleQuetos;
                    l_antlrString.Append(withOutDoubleQuetos);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return Regex.Replace(l_antlrString.ToString(), @"\s+", " ");

        }

        private string RemoveDoubleQuetoStr(string item)
        {
            int indx = item.IndexOf("\"", 1);
            return item.Substring(indx + 1).Trim();
        }

        private Token GetNotFunctionToken(string antlrStr)
        {
            Token token = new Token() { tokenList = new List<Token>() };
            try
            {
                token.name = token.displayName = token.id = token.value = Constants.NOT;
                token.tokenType = Constants.function;

                token.tokenList.Add(GetBraceTypeToken("("));
                token.tokenList.AddRange(GetSimpleStatementTokens(antlrStr.GetBraceBetweenString('(', ')')));
                token.tokenList.Add(GetBraceTypeToken(")"));

                //get odd list from tokenList for perameters
                token.parameters = token.tokenList.Where((c, i) => i % 2 != 0).ToList();

            }
            catch (Exception ex)
            {
                throw;
            }
            return token;
        }



        private Token GetBlockTypeToken(string blockAntlrStr)
        {
            Token token = new Token();

            try
            {
                string methodNameStr = blockAntlrStr.StartsWith(Constants.method) ? GetBlockName(blockAntlrStr, Constants.method) : GetBlockName(blockAntlrStr, Constants.lookup);

                token.name = token.displayName = token.id = token.value = methodNameStr.Trim();
                token.datatype = GetMethodDataType(blockAntlrStr);

                if (blockAntlrStr.StartsWith(Constants.method))
                    token.tokenType = Constants.systemFunctions.Contains(token.name) ? Constants.function : tokentypes.block.ToString();
                else
                    token.tokenType = "lookupTable";

                List<string> antlrStr = blockAntlrStr.SplitBy($"{methodNameStr}(");

                if (!token.tokenType.Equals(Constants.function) && antlrStr[1].StartsWith(Constants.ObjectModel))
                {
                    string objectModelStr = blockAntlrStr.Substring(blockAntlrStr.IndexOf('(') + 1).TrimEnd(")");
                    token.context = new List<Token>() { GetObjectModelToken(objectModelStr) };
                }
                else
                {
                    blockAntlrStr = string.Join($" {token.name}(", antlrStr.Skip(1)).TrimEnd(")");
                    token.tokenList = new List<Token>();
                    token.tokenList.Add(GetBraceTypeToken("("));
                    token.tokenList.AddRange(GetSimpleStatementTokens(blockAntlrStr));
                    token.tokenList.Add(GetBraceTypeToken(")"));

                    //get odd list from tokenList for perameters
                    token.parameters = token.tokenList.Where((c, i) => i % 2 != 0).ToList();
                }


            }
            catch (Exception ex)
            {
                throw;
            }
            return token;
        }

        private Token GetCallBlockToken(string callBlockAntlrStr)
        {
            Token token;
            try
            {

                string callBlockFormuleaName = GetCallBlockFormuleaName(callBlockAntlrStr, Constants.callBlock);

                string methodAnltrStr = $"{Constants.method} {callBlockAntlrStr.GetBraceBetweenString('[', ']')}";

                token = GetBlockTypeToken(methodAnltrStr);

                token.tokenType = Constants.callBlock;
                token.groupInfo = new Token() { name = callBlockFormuleaName };

            }
            catch (Exception ex)
            {
                throw;
            }

            return token;
        }
        private string GetCallBlockFormuleaName(string callBlockAntlrStr, string blockType)
        {
            int indx = callBlockAntlrStr.IndexOf('[');
            return callBlockAntlrStr.Slice(blockType.Length + 1, indx);
        }


        private string GetMethodDataType(string methodAntlrStr)
        {
            List<string> splitBySpc = methodAntlrStr.SplitBy(' ');

            if (splitBySpc.LastOrDefault().EqualsAny(Constants.String, Constants.Double, Constants.integer, Constants.bolean, Constants.datetime, Constants.date, Constants.Object))
                return splitBySpc.LastOrDefault();
            else
                return string.Empty;
        }

        public Token GetObjectModelToken(string objectModelStr)
        {

            objectModelStr = objectModelStr.Replace($"{Constants.ObjectModel}#", string.Empty);
            List<string> splitByOprndDisp = objectModelStr.SplitBy(Constants.operandDisplayProperty);
            objectModelStr = splitByOprndDisp.First();

            List<string> splitByDot = objectModelStr.SplitBy('.');
            splitByDot.Reverse();
            Token obj = GetRecursiveFactorGroups(splitByDot, 0);
            obj.value = splitByOprndDisp.Count > 1 ? splitByOprndDisp[1].ToString().GetStringRange('\"', '\"') : obj.name;
            return obj;

        }

        private Token GetRecursiveFactorGroups(List<string> splitByDot, int FGindex)
        {
            Token token = new Token();
            try
            {
                token.value = token.name = token.id = token.displayName = splitByDot[FGindex].SplitBy("(").First();

                token.datatype = GetSpecificValueFromAnltrStr(splitByDot[FGindex], Constants.datatype);

                if (splitByDot[FGindex].Contains(Constants.cardinality))
                    token.cardinality = ToInt32(GetSpecificValueFromAnltrStr(splitByDot[FGindex], Constants.cardinality));

                token.tokenType = token.name == token.datatype ? tokentypes.factorGroup.ToString() : tokentypes.factor.ToString();



                if (splitByDot.Count != FGindex + 1)
                    token.groupInfo = GetRecursiveFactorGroups(splitByDot, FGindex + 1);
            }
            catch (Exception ex)
            {
                throw;
            }

            return token;

        }

        private string GetBlockName(string methodAntlrStr, string blockType)
        {
            int indx = methodAntlrStr.IndexOf('(');
            return methodAntlrStr.Slice(blockType.Length + 1, indx); //7 is for Method srting length
        }


        #endregion

    }

    public static class ExtentionMethods
    {
        public static bool EqualsAny(this string strString, params string[] equalWords) => equalWords.Contains(strString) ? true : false;

        public static bool ConatainsAny(this string strString, params string[] equalWords) => equalWords.Any(p => strString.Contains(p)) ? true : false;

        public static bool StartsWithAny(this string strString, params string[] equalWords) => equalWords.Any(p => strString.StartsWith(p)) ? true : false;

        public static int[] IndexListOf(this string str, string word)
        {
            int curentIndex = -1;
            List<int> indexList = new List<int>();
            do
            {
                curentIndex = str.IndexOf(word, curentIndex + 1);

                if (curentIndex != -1)
                    indexList.Add(curentIndex);
            }
            while (curentIndex != -1);

            return indexList.ToArray();
        }

        public static string Slice(this string source, int start, int end)
        {
            if (end < 0) // Keep this for negative end support
            {
                end = source.Length + end;
            }
            int len = end - start;               // Calculate length
            return source.Substring(start, len); // Return Substring of length
        }

        public static List<string> SubList(this IEnumerable<string> source, int startIndex, int endIndex = 0)
        {
            if (endIndex == 0) // Keep this for negative end support            
                endIndex = source.Count();
            else if (endIndex <= startIndex)
                endIndex = startIndex;

            int len = endIndex - startIndex;               // Calculate length
            return source.ToList().GetRange(startIndex, len); // Return Substring of length
        }
        public static List<TSource> SubList<TSource>(this IEnumerable<TSource> source, int startIndex, int endIndex = 0)
        {
            if (endIndex == 0) // Keep this for negative end support            
                endIndex = source.Count();
            else if (endIndex <= startIndex)
                endIndex = startIndex;

            int len = endIndex - startIndex;               // Calculate length
            return source.ToList().GetRange(startIndex, len); // Return Substring of length
        }

        public static List<string> SplitBy(this string str, params char[] charArray)
        {
            //split by char array and remove all empty items
            string[] splitOpt = str.Split(charArray, StringSplitOptions.RemoveEmptyEntries);

            //trim every item in same array
            return splitOpt.Select(item => item.Trim()).ToList();

        }

        public static List<string> SplitBy(this string str, params string[] strArray)
        {
            //split by string array and remove all empty items
            string[] splitOpt = str.Split(strArray, StringSplitOptions.RemoveEmptyEntries);

            //trim every item in same array
            return splitOpt.Select(item => item.Trim()).ToList();
        }

        public static string TrimEnd(this string str, string trimWord)
        {
            if (str.Trim().EndsWith(trimWord))
                str = str.Trim().Remove(str.Length - trimWord.Length).Trim();

            return str;
        }


        public static bool AnyItems<TSource>(this IEnumerable<TSource> source) => source != null && source.Any() ? true : false;

        public static string GetBraceBetweenString(this string str, char startBraceChar, char endBraceChar)
        {
            List<int> openbrases = new List<int>();

            int i = 0;

            for (i = 0; i <= str.Length - 1; i++)
            {
                if (str[i].Equals(startBraceChar))
                    openbrases.Add(i);

                else if (str[i].Equals(endBraceChar))
                {
                    if (openbrases.Count > 1)
                        openbrases.Remove(openbrases.LastOrDefault());
                    else
                        return str.Slice(openbrases.Last() + 1, i);
                }
            }
            return string.Empty;
        }

        public static string GetStringRange(this string str, char fromChar, char toChar)
        {
            int startIndex = str.IndexOf(fromChar);
            int toIndex = str.IndexOf(toChar);
            toIndex = startIndex == toIndex ? str.IndexOf(toChar, startIndex + 1) : toIndex;
            return Slice(str, startIndex + 1, toIndex).Trim();
        }
        public static string TrimMultipleCharacter(string str, char limiter)
        {
            var len = str.Length;
            var src = str.ToCharArray();
            int dstIdx = 0; int cnt = 0;
            for (int i = 0; i < len; i++)
            {
                var ch = src[i];
                if (ch != limiter)
                {
                    src[dstIdx++] = ch;
                }
                else
                {
                    if (i != cnt + 1)
                        src[dstIdx++] = ch;
                    cnt = i;
                }
            }
            return new string(src, 0, dstIdx);
        }
        public static string TrimMultipleWhiteSpace(string str)
        {
            var len = str.Length;
            var src = str.ToCharArray();
            int dstIdx = 0; int cnt = 0;
            for (int i = 0; i < len; i++)
            {
                var ch = src[i];
                if (!isWhiteSpace(ch))
                {
                    src[dstIdx++] = ch;
                }
                else
                {
                    if (i != cnt + 1)
                        src[dstIdx++] = ch;
                    cnt = i;
                }
            }
            return new string(src, 0, dstIdx);
        }
        public static bool isWhiteSpace(char ch)
        {
            switch (ch)
            {
                case '\u0009':
                case '\u000A':
                case '\u000B':
                case '\u000C':
                case '\u000D':
                case '\u0020':
                case '\u0085':
                case '\u00A0':
                case '\u1680':
                case '\u2000':
                case '\u2001':
                case '\u2002':
                case '\u2003':
                case '\u2004':
                case '\u2005':
                case '\u2006':
                case '\u2007':
                case '\u2008':
                case '\u2009':
                case '\u200A':
                case '\u2028':
                case '\u2029':
                case '\u202F':
                case '\u205F':
                case '\u3000':
                    return true;
                default:
                    return false;
            }
        }
    }


    public class Constants
    {
        #region operators
        public const string NE = "NE";
        public const string EQ = "EQ";
        public const string LE = "LE";
        public const string GE = "GE";
        public const string GT = "GT";
        public const string LT = "LT";
        public const string OR = "OR";
        public const string AND = "AND";
        public const string Equal = "=";
        public const string DoubleEqual = "==";
        public const string NotEqual = "!=";
        public const string Plus = "+";
        public const string Minus = "-";
        public const string Mutliply = "*";
        public const string Percent = "%";
        public const string Slash = "/";
        public const string LEFTOPENBRACE = "(";
        public const string RIGHTOPENBRACE = ")";
        public const string LEFTSQUAREBRACE = "[";
        public const string RIGHTSQUAREBRACE = "]";



        /// <summary>
        /// 
        /// </summary>
        public static string[] Operators = new string[] { "NE", "EQ", "GT", "LT", "OR", "AND", "GE", "LE", "=", "!=", "==", "*", "/", "+", "-" };
        #endregion

        public static string[] systemFunctions = new string[] {
            "convertBooleanToString",
            "convertToString",
            "convertDateToString",
            "convertStringToDouble",
            "convertStringToInteger",
            "convertIntegerToString",
            "convertDoubleToInteger",
            "convertIntegerToDouble",
            "convertStringToBoolean",
            "convertStringToDate",
            "convertDoubleToString",
            "convertDoubleToDate",
            "convertBooleanToDouble",
            "Round",
            "count",
            "sum",
            "Add",
            "split",
            "timeSpan",
            "replace",
            "DateDiffinYears","DateDiffinMonths","DateDiffinDay","Day","Month","Year","DateAdd"
        };


        #region systemFunction constants
        public const string convertBooleanToString = "convertBooleanToString( ";
        public const string convertToString = "convertToString( ";
        public const string convertDateToString = "convertDateToString( ";
        public const string convertStringToDouble = "convertStringToDouble( ";
        public const string convertStringToInteger = "convertStringToInteger( ";
        public const string convertIntegerToString = "convertIntegerToString( ";
        public const string convertDoubleToInteger = "convertDoubleToInteger( ";
        public const string convertIntegerToDouble = "convertIntegerToDouble( ";
        public const string convertStringToBoolean = "convertStringToBoolean( ";
        public const string convertStringToDate = "convertStringToDate( ";
        public const string convertDoubleToString = "convertDoubleToString( ";
        public const string convertDoubleToBoolean = "convertDoubleToBoolean( ";
        public const string convertDoubleToDate = "convertDoubleToDate( ";
        public const string convertBooleanToDouble = "convertBooleanToDouble( ";
        public const string add = "add";
        public const string round = "round";
        public const string replace = "replace";
        public const string sum = "sum";
        public const string count = "count";
        public const string split = "split";
        public const string function = "function";

        #endregion


        #region dataTypes
        public const string date = "date";
        public const string Double = "double";
        public const string integer = "integer";
        public const string String = "string";
        public const string bolean = "bool";
        public const string boolean = "boolean";
        public const string datetime = "datetime";
        public const string Object = "object";
        public const string Null = "null";
        public const string Void = "void";
        #endregion

        public const string Semicolon = ";";
        public const string For = "for";
        public const string forAll = "forAll";
        public const string endForAll = "endForAll";
        public const string EXIT = "EXIT";
        public const string save = "save";
        public const string While = "while";
        public const string endWhile = "endWhile";
        public const string ifnot = "ifnot";
        public const string cardinality = "cardinality";
        public const string datatype = "datatype";
        public const string If = "if";
        public const string Then = "then";
        public const string Else = "else";
        public const string Elseif = "elseif";
        public const string endif = "endif";
        public const string end = "end";
        public const string IN = "IN";
        public const string NOT = "NOT";
        public const string NOTIN = "NOTIN";
        public const string Return = "return ";
        public const string lookup = "lookup";
        public const string singleLookup = "singleLookup";
        public const string multiLookup = "multiLookup";
        public const string method = "method";
        public const string callBlock = "callBlock";
        public const string scope = "scope";
        public const string local = "local";
        public const string xPath = "xPath";
        public const string value = "value";
        public const string Variable = "Variable";
        public const string Constant = "Constant";
        public const string ObjectModel = "ObjectModel";
        public const string displayProperty = "displayProperty";
        public const string operandDisplayProperty = "operandDisplayProperty";
        public const string hash = "#";
        public const string Close = "}";
        public const string temp = "temp";
        public static string[] Formats = { "dd/MM/yyyy", "dd/M/yyyy", "d/M/yyyy", "d/MM/yyyy","dd/MM/yy", "dd/M/yy", "d/M/yy", "d/MM/yy","MM/dd/yyyy",
                                             "M/dd/yyyy", "M/d/yyyy", "MM/d/yyyy","MM/dd/yy", "M/dd/yy", "M/d/yy", "MM/d/yy","dd-MM-yyyy", "dd-M-yyyy",
                                             "d-M-yyyy", "d-MM-yyyy","dd-MM-yy", "dd-M-yy", "d-M-yy", "d-MM-yy","MM-dd-yyyy","M-dd-yyyy", "M-d-yyyy",
                                             "MM-d-yyyy","MM-dd-yy", "M-dd-yy", "M-d-yy", "MM-d-yy","yyyy/dd/MM", "yyyy/dd/M", "yyyy/d/M", "yyyy/d/MM","yy/dd/MM",
                                              "yy/dd/M", "yy/d/M", "yy/d/MM","yyyy/MM/dd",
                                             "yyyy/M/dd", "yyyy/M/d", "yyyy/MM/d","yy/MM/dd", "yy/M/dd", "yy/M/d", "yy/MM/d","yyyy-dd-MM", "yyyy-dd-M",
                                             "yyyy-d-M", "yyyy-d-MM","yyyy-dd-MM", "yyyy-dd-M", "yyyy-d-M", "yyyy-d-MM","yyyy-MM-dd","yyyy-M-dd", "yyyy-M-d",
                                             "yyyy-MM-d","yy-MM-dd", "yy-M-dd", "yy-M-d", "yy-MM-d"};
    }

}
