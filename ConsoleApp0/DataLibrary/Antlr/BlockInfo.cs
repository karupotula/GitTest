using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBuilder.Models
{
    public class BlockInfo
    {
        public string Name { get; set; }

        public string InternalName { get; set; }

        public string ReturnType { get; set; }

        public Token ReturnVariable { get; set; }

        public List<Token> Context { get; set; }

        public bool IsPricer { get; set; }

        public string AntlrContent { get; set; }

        public List<statement> Statements { get; set; }

        public List<Token> BlockDef { get; set; }
    }
}
