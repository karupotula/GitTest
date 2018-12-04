using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

using Antlr.Runtime;

using System.Text.RegularExpressions;
using System.Globalization;

namespace ANTLR.Parser
{
    public class TypeCastImpl
    {

        public static List<DataMisMatchedException> DataTypeMisMatchList = new List<DataMisMatchedException>();
        public static ExceptionMessage AntlrException { get; set; }
        public static ArrayList functionList = new ArrayList();
        public static List<string> paramDataTypes = new List<string>();
        private string fieldDataType = string.Empty;
        
        public TypeCastImpl()
        {
           
        }

        public string CheckInNotInDataType(String fieldDataType, List<string> paramsDataTypes)
        {
            return "";
        }

        public string GetStringWithoutQuotes(string str)
        {
            try
            {
                if (!string.IsNullOrEmpty(str) && !str.Equals("\"\""))
                {
                    str = str.Trim();
                    while (str[0] == '"')
                    {
                        str = str.Substring(1);
                    }
                    while (str[str.Length - 1] == '"')
                    {
                        str = str.Substring(0, str.Length - 1);
                    }
                }
                else if (!string.IsNullOrEmpty(str) && str.Equals("\"\""))
                    str = string.Empty;
                return str;
            }
            catch { throw; }
        }

        public static string GetStaticStringWithoutQuotes(string str)
        {
            try
            {
                if (!string.IsNullOrEmpty(str) && !str.Equals("\"\""))
                {
                    str = str.Trim();
                    while (str[0] == '"')
                    {
                        str = str.Substring(1);
                    }
                    while (str[str.Length - 1] == '"')
                    {
                        str = str.Substring(0, str.Length - 1);
                    }
                }
                else if (!string.IsNullOrEmpty(str) && str.Equals("\"\""))
                    str = string.Empty;
                return str;
            }
            catch { throw; }
        }
        public static bool IsDate(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;
            value = value.Trim();
            if (value == "*")
                return true;
            Regex pattern = new Regex(@"^(1[0-2]|0?[1-9])/(3[01]|[12][0-9]|0?[1-9])/(?:[0-9]{2})?[0-9]{2}$");
            return pattern.IsMatch(value);
        }
        public static string GetDatatype(string literal)
        {
            double i;
            int j;
            DateTime d;
            Boolean b;
            string[] formats = { "dd/MM/yyyy", "dd/M/yyyy", "d/M/yyyy", "d/MM/yyyy","dd/MM/yy", "dd/M/yy", "d/M/yy", "d/MM/yy","MM/dd/yyyy",
                                             "M/dd/yyyy", "M/d/yyyy", "MM/d/yyyy","MM/dd/yy", "M/dd/yy", "M/d/yy", "MM/d/yy","dd-MM-yyyy", "dd-M-yyyy",
                                             "d-M-yyyy", "d-MM-yyyy","dd-MM-yy", "dd-M-yy", "d-M-yy", "d-MM-yy","MM-dd-yyyy","M-dd-yyyy", "M-d-yyyy",
                                             "MM-d-yyyy","MM-dd-yy", "M-dd-yy", "M-d-yy", "MM-d-yy","yyyy/dd/MM", "yyyy/dd/M", "yyyy/d/M", "yyyy/d/MM","yy/dd/MM", "yy/dd/M", "yy/d/M", "yy/d/MM","yyyy/MM/dd",
                                             "yyyy/M/dd", "yyyy/M/d", "yyyy/MM/d","yy/MM/dd", "yy/M/dd", "yy/M/d", "yy/MM/d","yyyy-dd-MM", "yyyy-dd-M",
                                             "yyyy-d-M", "yyyy-d-MM","yyyy-dd-MM", "yyyy-dd-M", "yyyy-d-M", "yyyy-d-MM","yyyy-MM-dd","yyyy-M-dd", "yyyy-M-d",
                                             "yyyy-MM-d","yy-MM-dd", "yy-M-dd", "yy-M-d", "yy-MM-d","yyyy'-'MM'-'dd'T'HH':'mm':'ss"};
            if (Int32.TryParse(literal, out j))
            {
                return "integer";
            }
            else if (Double.TryParse(literal, out i))
            {
                return "double";
            }
            else if (Boolean.TryParse(literal, out b))
            {
                return "boolean";
            }
            else if (DateTime.TryParseExact(GetStaticStringWithoutQuotes(literal), formats, null, DateTimeStyles.AllowWhiteSpaces, out d))
            {
                return "date";
            }
            else
                return "string";
        }

       
        /// <summary>
        /// Gets the respective Field Type
        /// </summary>
        /// <param name="fieldType"></param>
        /// <returns></returns>
        private string GetFieldType(string fieldType)
        {
            String strDataType = string.Empty;
            switch (fieldType.ToUpper())
            {
                case "STRING":
                    strDataType = AntlrConstants.STRING.ToLower();
                    break;
                case "DOUBLE":
                    strDataType = AntlrConstants.DOUBLE.ToLower();
                    break;
                case "NUMBER":
                    strDataType = AntlrConstants.DOUBLE.ToLower();
                    break;
                case "NUMERIC":
                    strDataType = AntlrConstants.DOUBLE.ToLower();
                    break;
                case "DATE_TIME":
                    strDataType = AntlrConstants.DATE.ToLower(); ;
                    break;
                case "BOOLEAN":
                    strDataType = AntlrConstants.BOOLEAN.ToLower(); ;
                    break;
                default:
                    strDataType = AntlrConstants.STRING.ToLower();
                    break;
            }
            return strDataType;
        }

        /**
         *
         * @param lookupType
         * @param lookUpName
         * @param paramType
         * @param paramsDataTypes
         */


        public string checkType(string arg1, string arg2, string operatorText)
        {

            if ((!string.IsNullOrEmpty(arg1) && arg1.ToLower() == "entityinfo") || (!string.IsNullOrEmpty(arg2) && arg2.ToLower() == "entityinfo"))
                return "";

            arg1 = (!string.IsNullOrEmpty(arg1) && arg1.ToLower() == "datetime") ? "date" : arg1;
            arg2 = (!string.IsNullOrEmpty(arg1) && arg1.ToLower() == "datetime") ? "date" : arg2;

            if (arg2 == "any")
                return "";
            if (operatorText == PricerConstants.GT || operatorText == PricerConstants.GE || operatorText == PricerConstants.LE || operatorText == PricerConstants.LT || operatorText == PricerConstants.DIV || operatorText == PricerConstants.MUL || operatorText == PricerConstants.SUB || operatorText == PricerConstants.ADD)
            {
                if (arg1.ToUpper() == "STRING" || arg2.ToUpper() == "STRING" || arg1.ToUpper() == "BOOLEAN" || arg2.ToUpper() == "BOOLEAN")
                {
                    DataMisMatchedException exception = new DataMisMatchedException();
                    exception.ErrorCause = "Invalid datatype at step number " + CalcETreeParser.Counter;
                    if (arg1.ToUpper() == "STRING" || arg2.ToUpper() == "STRING")
                        exception.ErrorMessage = " text  for " + operatorText;
                    else if (arg1.ToUpper() == "BOOLEAN" || arg2.ToUpper() == "BOOLEAN")
                        exception.ErrorMessage = " boolean  for " + operatorText;
                    exception.RowIndex = CalcETreeParser.Counter;
                    DataTypeMisMatchList.Add(exception);
                    //throw exception;
                }
            }
            else if (operatorText == PricerConstants.ADD || operatorText == PricerConstants.SUB || operatorText == PricerConstants.MUL || operatorText == PricerConstants.DIV)
            {
                if (arg1.ToUpper() == "DATE" || arg2.ToUpper() == "DATE" || arg1.ToUpper() == "DATETIME" || arg2.ToUpper() == "DATETIME")
                {
                    DataMisMatchedException exception = new DataMisMatchedException();
                    exception.ErrorCause = "Invalid datatype at step number " + CalcETreeParser.Counter;
                    exception.ErrorMessage = "datetime for " + operatorText;
                    exception.RowIndex = CalcETreeParser.Counter;
                    DataTypeMisMatchList.Add(exception);
                    //throw exception;
                }
            }
            if (!string.IsNullOrEmpty(arg1) && !string.IsNullOrEmpty(arg2))
            {
                if (arg1.ToUpper() == arg2.ToUpper())
                {
                    arg1 = arg2;
                }
                else
                {
                    if (arg2 == null)
                    {
                        DataMisMatchedException exception = new DataMisMatchedException();
                        exception.ErrorCause = "Data mismatch at step number " + CalcETreeParser.Counter;
                        exception.ErrorMessage = "Found " + arg2 + " expecting " + arg1;
                        exception.RowIndex = CalcETreeParser.Counter;
                        DataTypeMisMatchList.Add(exception);
                        //throw exception;
                    }
                    else
                    {
                        DataMisMatchedException exception = new DataMisMatchedException();
                        exception.ErrorCause = "Data mismatch at step number " + CalcETreeParser.Counter;
                        exception.ErrorMessage = "Found " + arg2 + " expecting " + arg1;
                        exception.RowIndex = CalcETreeParser.Counter;
                        DataTypeMisMatchList.Add(exception);
                        //throw exception;
                    }
                }
            }

            return "";
        }

        public void StopForallInsideIfexists()
        {
            DataMisMatchedException exception = new DataMisMatchedException();
            exception.ErrorCause = "Invalid Statement in ifexists.";
            exception.ErrorMessage = "Can not use forall inside ifexists.";
            exception.RowIndex = CalcETreeParser.Counter;
            DataTypeMisMatchList.Add(exception);
        }

        public void StopIfexistsInsideForall()
        {
            DataMisMatchedException exception = new DataMisMatchedException();
            exception.ErrorCause = "Invalid Statement in forall.";
            exception.ErrorMessage = "Can not use ifexists inside forall.";
            exception.RowIndex = CalcETreeParser.Counter;
            DataTypeMisMatchList.Add(exception);
        }

        public void InvalidOrAnd()
        {
            DataMisMatchedException exception = new DataMisMatchedException();
            exception.ErrorCause = "Invalid OR and And combination";
            exception.ErrorCause = "Cannot use OR and And combination in condition expressions.";
            exception.RowIndex = CalcETreeParser.Counter;
            DataTypeMisMatchList.Add(exception);
        }
        public void createErrorMessage(RecognitionException e)
        {
            if (AntlrException == null)
            {
                AntlrException = new ExceptionMessage();
            }
            //if (e is DataMisMatchedException)
            //{
            //    DataMisMatchedException dme = (DataMisMatchedException)e;
            //    ExceptionMessage.setErrorMessage(dme.ErrorMessage + " reason "
            //            + dme.ErrorCause);
            //}           
            if (e is MismatchedTokenException)
            {
                MismatchedTokenException mte = (MismatchedTokenException)e;

                if (mte.Token.Text.Equals("then"))
                {
                    AntlrException.ErrorMessage = "Not a valid condition part";
                }
                else if (mte.Token.Text.Equals(AntlrConstants.EQ) || mte.Token.Text.Equals(AntlrConstants.GT) || mte.Token.Text.Equals(AntlrConstants.GE) || mte.Token.Text.Equals(AntlrConstants.LT) || mte.Token.Text.Equals(AntlrConstants.LE) || mte.Token.Text.Equals(AntlrConstants.NE))
                {
                    AntlrException.ErrorMessage = "Not a valid conditional Expression";
                }
                else if (mte.Token.Text.Equals(AntlrConstants.ADD) || mte.Token.Text.Equals(AntlrConstants.SUB) || mte.Token.Text.Equals(AntlrConstants.MUL) || mte.Token.Text.Equals(AntlrConstants.DIV) || mte.Token.Text.Equals(AntlrConstants.EQ))
                {
                    AntlrException.ErrorMessage = "Not a valid statement";
                }
                else if (mte.Token.Text.ToUpper().Equals(AntlrConstants.METHOD))
                {
                    AntlrException.ErrorMessage = "Not a valid function or method statement";
                }
                else
                {
                    AntlrException.ErrorMessage = "Not a valid expression";
                }
            }
            else if (e is MismatchedTreeNodeException)
            {
                MismatchedTreeNodeException mtne = (MismatchedTreeNodeException)e;
                if (e.Token.Text != null)
                {
                    AntlrException.ErrorMessage = "SYNTAX ERROR: FOUND "
                            + mtne.Node + "  EXPECTING "
                            + CalcETreeParser.tokenNames[mtne.expecting];
                }
            }
            else if (e is NoViableAltException)
            {
                NoViableAltException nvae = (NoViableAltException)e;
                if (nvae.Token.Text.Equals(AntlrConstants.SEMICOLON))
                {
                    AntlrException.ErrorMessage = "Not a valid statement";
                }
            }
            else if (e is EarlyExitException)
            {
                AntlrException.ErrorMessage = "PLEASE PROVIDE THE INPUT FOR THE METHOD";
            }
            else if (e is MismatchedSetException)
            {
                MismatchedSetException mse = (MismatchedSetException)e;
                if (e.Token.Text != null)
                {
                    AntlrException.ErrorMessage = "SYNTAX ERROR: FOUND '"
                            + e.Token + "'  EXPECTING  " + mse.expecting;
                }
            }
            else if (e is MismatchedNotSetException)
            {
                MismatchedNotSetException mse = (MismatchedNotSetException)e;
                if (e.Token.Text != null)
                {
                    AntlrException.ErrorMessage = "SYNTAX ERROR: FOUND '"
                            + e.Token + "'  EXPECTING " + mse.expecting;
                }
            }
            else if (e is FailedPredicateException)
            {
                FailedPredicateException fpe = (FailedPredicateException)e;
                if (e.Token.Text != null)
                {
                    AntlrException.ErrorMessage = "rule " + fpe.ruleName
                            + " failed predicate: {" + fpe.predicateText + "}?";
                }
            }
        }
    }

    public class DataMisMatchedException : System.Exception
    {
        public DataMisMatchedException()
        {

        }
        public string ErrorCause { get; set; }
        public string ErrorMessage { get; set; }
        public int RowIndex { get; set; }

    }

    public class ExceptionMessage
    {
        public ExceptionMessage()
        {

        }

        private string _errorMessage = "";
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
            }
        }
    }
    public class MetadataInfo
    {
        public MetadataInfo()
        {
            ismultiple = false;
        }
        //stores datatype 'double','string' etc
        public string datatype { get; set; }
        //represents Cardinality if true cardinality is multiple else single
        public bool ismultiple { get; set; }
        public string value { get; set; }
    }
}
