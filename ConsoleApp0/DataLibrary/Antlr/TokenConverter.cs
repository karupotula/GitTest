using AlgorithmBuilder.Models;
using ANTLR.Parser;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBuilder.AntlrUtility
{
    public class TokenConverter
    {
        private static Random random = new Random();
        private int tempCount = 0;
        private int xPathCount = 0;
        private bool isPricer = false;
        public string SetAntlr(BlockInfo block)
        {
            StringBuilder strBuilder = new StringBuilder();
            isPricer = block.IsPricer;
            try
            {
                strBuilder.Append("{ ");
                strBuilder.Append(BlockStartTag(block));
                foreach (var item in block.Statements)
                {
                    SetStatement(item, strBuilder);
                }
                if (block.ReturnVariable != null)
                    strBuilder.Append(BlockEndTag(block));
                strBuilder.Append(" }");
                string antlrStr = ExtentionMethods.TrimMultipleWhiteSpace(strBuilder.ToString()).Replace(" ; ;", " ;");



                string l_err = ValidateAntlr(antlrStr);
                if (!string.IsNullOrEmpty(l_err))
                    throw new Exception(l_err);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return "";
        }

        public string BlockStartTag(BlockInfo blck)
        {
            StringBuilder strBlck = new StringBuilder();
            strBlck.Append($"metadata name Algo internalName {blck.Name} Version3.0 isPricer False arguments(");
            foreach (var item in blck.BlockDef)
            {
                strBlck.Append($"ObjectModel#{item.value}({Constants.datatype}={item.name},{Constants.cardinality}={item.cardinality}),");
            }
            strBlck.Remove(strBlck.Length - 1, 1);
            strBlck.Append($") ({blck.ReturnType}); ");
            return strBlck.ToString();
        }
        public string BlockEndTag(BlockInfo blck)
        {
            string blkTag = string.Empty;
            if (blck.ReturnType.ToLower() != "void" || !string.IsNullOrEmpty(blck.ReturnType))
            {
                blkTag = "return " + SetToken(blck.ReturnVariable);

            }
            blkTag += " ;";
            return blkTag;
        }
        public void WriteFile(string antlr)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\block.json"))
            {
                sw.WriteLineAsync(antlr);
            }
        }
        private string ValidateAntlr(string anltlr)
        {
            String errString = string.Empty;
            CalcETreeParser parser = null;
            try
            {
                TypeCastImpl.DataTypeMisMatchList = new List<DataMisMatchedException>();
                CalcETreeParser.Counter = 0;
                String antlrResultText = string.Empty;
                CalcETreeLexer lexer = new CalcETreeLexer(new Antlr.Runtime.ANTLRStringStream(anltlr));
                Antlr.Runtime.CommonTokenStream tokens = new Antlr.Runtime.CommonTokenStream(lexer);
                parser = new CalcETreeParser(tokens);
                parser.block();
                if (TypeCastImpl.DataTypeMisMatchList.Count > 0)
                {
                    foreach (DataMisMatchedException dataMisMatch in TypeCastImpl.DataTypeMisMatchList)
                    {
                        errString += dataMisMatch.ErrorCause + " " + dataMisMatch.ErrorMessage + ".\n";
                    }
                }
            }
            catch (Antlr.Runtime.NoViableAltException nve)
            {
                errString = "Invalid expression at step# " + CalcETreeParser.Counter + ". Please verify the syntax of the expression";
            }
            catch (Antlr.Runtime.MismatchedTokenException mte)
            {
                //if (!string.IsNullOrEmpty(parser.TokenNames[mte.Expecting].ToString()))
                //    errString = parser.TokenNames[mte.Expecting].ToString() + " Expecting in the Expression in row " + CalcETreeParser.Counter;
                //else
                errString = TypeCastImpl.AntlrException.ErrorMessage + " at step# " + CalcETreeParser.Counter + ". Please verify the syntax of the expression";

                //_astTA.text += "\n" + er.message;
            }
            catch (Antlr.Runtime.RecognitionException re)
            {
                errString = "Invalid expression at step# " + CalcETreeParser.Counter + ". Please verify the syntax of the expression";
                //_astTA.text += "\n" + er.message;
            }
            catch (Exception er)
            {
                errString = "An Error occured in row " + CalcETreeParser.Counter + " .\nDetails:" + er.Message;
            }
            return errString;
        }

        private void SetStatement(statement stmt, StringBuilder strBuilder)
        {
            try
            {
                //antlr start string
                strBuilder.Append(SetStartag(stmt.type));
                //tokens simple statement
                SetTokenString(stmt.tokenList, strBuilder);
                //tokens condition
                SetTokenString(stmt.condition, strBuilder);

                if (stmt.condition != null && stmt.condition.Count() > 0)
                    strBuilder.Append($"displayProperty \"{DisplayProperty(stmt.condition)}\"");

                //tokens in actions(list of statements)
                if (stmt.action != null && stmt.action.Count() > 0)
                {
                    if (stmt.type == "if" || stmt.type == "elseif")
                        strBuilder.Append(" then ");
                    else if (stmt.type == "for")
                        strBuilder.Append(" [ ");

                    foreach (var item in stmt.action)
                    {
                        SetStatement(item, strBuilder);
                    }
                }
                //tokens in statements(list of statements)
                if (stmt.statements != null && stmt.statements.Count() > 0)
                {
                    foreach (var item in stmt.statements)
                    {
                        SetStatement(item, strBuilder);
                    }
                }

                //antlr end string
                if (stmt.tokenList != null && stmt.tokenList.Count() > 0)
                    strBuilder.Append($"displayProperty \"{DisplayProperty(stmt.tokenList)}\"");

                strBuilder.Append(SetEndTag(stmt.type));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        void SetTokenString(List<Token> tokenList, StringBuilder strBuilder)
        {

            if (tokenList != null)
            {
                foreach (var item in tokenList)
                {
                    strBuilder.Append(SetToken(item));
                    if (item.tokenType != "block")
                        SetChildTokens(item.tokenList, strBuilder);
                }
            }

        }
        private void SetChildTokens(List<Token> tokens, StringBuilder strBuilder)
        {
            if (tokens != null && tokens.Count() > 0)
            {
                foreach (var item in tokens)
                {
                    strBuilder.Append(SetToken(item));
                    if (item.tokenList != null && item.tokenList.Count() > 0)
                    {
                        SetChildTokens(item.tokenList, strBuilder);
                    }
                }
            }
        }
        private string SetStartag(string p_type)
        {
            switch (p_type)
            {
                case "if":
                    return $" {p_type} ";
                case "elseif":
                    return $" {p_type} ";
                case "else":
                    return $" {p_type} ";
                case "for":
                    return $" {Constants.forAll} ";
                case "while":
                    return $" {Constants.While} ";
                default:
                    return string.Empty;
            }
        }

        private string SetEndTagWOSemi(string p_type)
        {
            switch (p_type)
            {
                case "if":
                    return $"{Constants.end}{p_type}";
                case "elseif":
                    return $"{Constants.end}{p_type}";
                case "for":
                    return $"{Constants.end}{Constants.endForAll}";
                case "while":
                    return $"{Constants.end}{Constants.endWhile}";
                case "else":
                    return "";
                case "simple":
                    return "";

            }
            return string.Empty;
        }
        private string SetEndTag(string p_type)
        {
            switch (p_type)
            {
                case "if":
                    return $"{Constants.end}{p_type} ; ";
                case "elseif":
                    return $"{Constants.end}{p_type} ; ";
                case "for":
                    return $" ] {Constants.endForAll} ; ";
                case "while":
                    return $"{Constants.end}{Constants.endWhile} ; ";
                case "else":
                    return " ; ";
                case "simple":
                    return " ; ";

            }
            return string.Empty;
        }
        private string GetLiteralDataType(Token token)
        {
            string l_str = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(token.datatype))
                    l_str = token.datatype;

                DateTime dt;
                bool l_type = DateTime.TryParseExact(token.value, Constants.Formats, null, DateTimeStyles.AllowWhiteSpaces, out dt);
                if (l_type)
                    return Constants.date;
                int l_int;
                l_type = int.TryParse(token.value, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out l_int);
                if (l_type)
                    return Constants.integer;
                double dbl;
                l_type = Double.TryParse(token.value, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out dbl);
                if (l_type)
                    return Constants.Double;
                bool l_bool;
                l_type = bool.TryParse(token.value, out l_bool);
                if (l_type)
                    return Constants.boolean;
                if (token.value == Constants.Null && token.datatype == Constants.Null)
                    return Constants.Null;

                return Constants.String;
            }
            catch
            {
                throw;
            }


        }
        private string GetLiteral(Token token)
        {
            string l_dataType = GetLiteralDataType(token);
            return $"{Constants.Constant}#{Constants.temp}{tempCount++}(datatype={l_dataType},value={token.value}) {OperandDisplay(token)}";
        }

        private string Factor(Token token)
        {
            string l_str = string.Empty;
            if (token.groupInfo != null)
            {
                l_str = FactorGroup(token.groupInfo);
            }
            l_str += $".{token.name}({Constants.datatype}={ token.datatype},{Constants.cardinality}={token.cardinality})";
            l_str += OperandDisplay(token);
            return l_str;
        }
        private string OperandDisplay(Token token)
        {
            string l_value = string.Empty;
            if (token.tokenType != "literal")
            {
                if (token.tokenType == "xPath")
                    l_value = token.value.Trim('\"');
                else
                    l_value = token.value;

                return $" {Constants.operandDisplayProperty} \"{ l_value }\" ";
            }
            else
            {
                l_value = token.value.Trim('\'').Trim('\"');
                return $" {Constants.operandDisplayProperty} \"'{ l_value }'\" ";
            }
        }
        private string FactorGroup(Token token)
        {
            string l_FgString = string.Empty;
            if (token.groupInfo != null)
            {
                l_FgString += ParentGroup(token.groupInfo);
                l_FgString += "." + token.name + $"({Constants.datatype}={ token.datatype},{Constants.cardinality}={token.cardinality})";
            }
            else
                l_FgString += "ObjectModel#" + token.name + $"({Constants.datatype}={ token.datatype},{Constants.cardinality}={token.cardinality})";
            return l_FgString;
        }
        private string ParentGroup(Token token)
        {
            return "ObjectModel#" + token.name + $"({Constants.datatype}={ token.datatype},{Constants.cardinality}={token.cardinality})";
        }
        private string CallBlock(Token token)
        {
            string l_str = Block(token);
            l_str = l_str.Replace("method ", "");
            return $" callBlock {token.groupInfo.name}[{l_str}] ";
        }
        private string Block(Token token)
        {
            string strBlock = string.Empty;
            string strOperandDisp = string.Empty;

            strBlock = $"method {token.value}(";
            if (token.context != null)
            {
                foreach (var item in token.context)
                {
                    if (item.groupInfo != null)
                    {
                        strBlock += $"{Constants.ObjectModel}#";
                        SetParentGroupBlock(item.groupInfo, ref strBlock);
                        strBlock += $"{item.name}({Constants.datatype}={ item.datatype},{Constants.cardinality}={token.cardinality}),";
                        strOperandDisp += item.value + ",";
                    }
                    else
                    {
                        strBlock += $"{Constants.ObjectModel}#{item.name}({Constants.datatype}={ item.datatype},{Constants.cardinality}={token.cardinality}),";
                        strOperandDisp += item.value + ",";
                    }
                }
            }

            if (isPricer)
                strBlock = strBlock.TrimEnd(",") + $" {Constants.operandDisplayProperty} \"{strOperandDisp.TrimEnd(",")}\" ) ";
            else
                strBlock = strBlock.TrimEnd(",") + $") {token.datatype} ";//{Constants.operandDisplayProperty} \"{strOperandDisp.TrimEnd(",")}\"

            return strBlock;
        }

        private void SetParentGroupBlock(Token token, ref string str)
        {
            if (token.groupInfo != null)
            {
                SetParentGroupBlock(token.groupInfo, ref str);
            }
            str += $"{token.name}({Constants.datatype}={ token.datatype},{Constants.cardinality}={token.cardinality}).";
        }
        private string Operator(Token token)
        {
            return $" {token.value} ";
        }
        private string Function(Token token)
        {
            if (token.value == "NOT")
                return $" { token.value}";
            else
                return $"method { token.value}";
        }
        //private string SetFunction(Token token)
        //{
        //    switch (token.value)
        //    {
        //        case "NOT":
        //            return $" { token.value}";
        //    }
        //    return "";
        //}
        private string LookUp(Token token)
        {
            return $"lookup { token.value}";
        }
        private string LocalVariable(Token token)
        {
            return "Variable#" + token.value + $"({Constants.datatype}={ token.datatype},{Constants.cardinality}={token.cardinality},scope=local) {OperandDisplay(token)} ";
        }
        private string GlobalVariable(Token token)
        {
            return "Variable#" + token.value + $"({Constants.datatype}={ token.datatype},{Constants.cardinality}={token.cardinality},scope=global) {OperandDisplay(token)} ";
        }
        private string SetXpathValue(Token token)
        {
            return $"xPath#xPath{xPathCount++}({Constants.datatype}={token.datatype},value=\"{token.value}\") {OperandDisplay(token)} ";
        }

        private string DisplayProperty(List<Token> tokenList)
        {
            StringBuilder str = new StringBuilder(); ;
            foreach (var item in tokenList)
            {
                //if (item.value == "\"\"")
                //    str.Append("''");
                //else
                //{
                if (item.tokenType == Constants.xPath)
                    str.Append(item.value.Trim('\"'));
                else
                    str.Append(item.value);
                //}
                str.Replace("\"", "'");
                str.Append(" ");
            }
            return str.ToString();
        }
        private string SetToken(Token token)
        {
            switch (token.tokenType)
            {
                case "factor":
                    return Factor(token);
                case "factorGroup":
                    return FactorGroup(token) + OperandDisplay(token);
                case "function":
                    return Function(token);
                case "operator":
                    return Operator(token);
                case "block":
                    return Block(token);
                case "rateTable":
                    return LookUp(token);
                case "lookupTable":
                    return LookUp(token);
                case "globalVariable":
                    return GlobalVariable(token);
                case "localVariable":
                    return LocalVariable(token);
                case "literal":
                    return GetLiteral(token);
                case "null":
                    return " null ";
                case "xPath":
                    return SetXpathValue(token);
                case "callBlock":
                    return CallBlock(token);
                default:
                    break;
            }
            return token.displayName;

        }
    }
}
