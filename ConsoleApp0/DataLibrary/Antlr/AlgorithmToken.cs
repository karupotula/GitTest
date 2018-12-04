using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBuilder.Models
{
    public class AlgorithmToken : Token
    {
        public List<Token> PrimaryContext { get; set; }

        public List<Token> Blocks { get; set; }

    }
}
