using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBuilder.Models
{
    public interface IRiskChildrenInfo
    {
        List<RiskToken> ChildRisks { get; set; }
        List<Token> Attributes { get; set; }
    }

    public class RiskToken : Token, IRiskChildrenInfo
    {
        public List<RiskToken> ChildRisks { get; set; }
        public List<Token> Attributes { get; set; }
    }
}
