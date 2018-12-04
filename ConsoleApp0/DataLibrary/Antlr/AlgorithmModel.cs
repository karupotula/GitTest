using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBuilder.Models
{   

    public partial class statement : events
    {
        public string type { get; set; }

        public List<Token> condition { get; set; }

        public List<statement> action { get; set; }

        public List<statement> statements { get; set; }

        public List<Token> tokenList { get; set; }
    }
    
    public class Token
    {

        public string p_type { get; set; }

        public string name { get; set; }

        public int paramCount { get; set; }

        public string id { get; set; }

        public string displayName { get; set; }

        public string jsobject { get; set; }

        public string value { get; set; }

        public string tokenType { get; set; }

        public string src { get; set; }

        public string datatype { get; set; }

        public int cardinality { get; set; }

        public List<Token> tokenList { get; set; }

        public List<Token> parameters { get; set; }

        public Token groupInfo { get; set; }

        public List<Token> context { get; set; }

        public int paramIndex { get; set; }
        
    }

    public enum tokentypes
    {

        /// <remarks/>
        _property,

        /// <remarks/>
        _operator,

        /// <remarks/>
        _function,

        /// <remarks/>
        _static,

        /// <remarks/>
        _keyword,

        factor,

        factorGroup,

        lookupTable,

        rateTable,

        algorithm,

        block,

        globalVariable,

        localVariable
    }   

    public class events
    {
        private bool _expand = true;

        private bool _showdelete = true;

        public bool expand
        {
            get
            {
                return _expand;
            }

            set
            {
                _expand = value;
            }
        }

        public bool showdelete
        {
            get
            {
                return _showdelete;
            }

            set
            {
                _showdelete = value;
            }
        }


    }
}
