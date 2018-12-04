using System.Collections.Generic;
using System.Runtime.Serialization;

namespace iFoundry.Entities
{
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(FormulaInfo))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/PlanFormulae")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "planFormulaBaseInfo", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/PlanFormulae")]
    public partial class PlanFormulaBaseInfo : pattern
    {
        private PlanFormula planFormulaField;

        public PlanFormulaBaseInfo()
        {
            this.planFormulaField = new PlanFormula();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public PlanFormula PlanFormula
        {
            get
            {
                return this.planFormulaField;
            }
            set
            {
                this.planFormulaField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/Formula")]
    [System.Xml.Serialization.XmlRootAttribute("Formula", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/Formula", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "formulaInfo", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/Formula")]
    public partial class FormulaInfo : FormulaBaseInfo
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsApprovedVersion { get; set; }
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FormulaInfo))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/Formula")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "formulaBaseInfo", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/Formula")]
    public partial class FormulaBaseInfo : pattern
    {

        //private PEFormula pEFormulaField;

        //public FormulaBaseInfo()
        //{
        //    this.pEFormulaField = new PEFormula();
        //}

        //[System.Runtime.Serialization.DataMemberAttribute()]
        //public PEFormula PEFormula
        //{
        //    get
        //    {
        //        return this.pEFormulaField;
        //    }
        //    set
        //    {
        //        this.pEFormulaField = value;
        //    }
        //}
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Core/Calculation")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "PlanFormula", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/PlanFormulae")]
    public partial class PlanFormula : BaseEntity<PlanFormula>
    {

        [System.Xml.Serialization.XmlElementAttribute("expContent")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<ExpContent> ExpContent { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("dispalyContent")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<DispalyContent> DispalyContent { get; set; }
        [DataMember]
        public List<AlgoBlockInfo> Blocks { get; set; }
    }

}
