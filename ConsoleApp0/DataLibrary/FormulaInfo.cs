using System;

namespace iFoundry.Entities
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/PlanFormulae")]
    [System.Xml.Serialization.XmlRootAttribute("Formula", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/PlanFormulae", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "planFormulaInfo", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/PlanFormulae")]
    public partial class planFormulaInfo : PlanFormulaBaseInfo
    {
        public string antlr { get; set; }
        public string tokens { get; set; }
        public string returnType { get; set; }
        public string defId { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsApprovedVersion { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Rule_Id { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ChangesetType { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CategoryId { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AlgoType { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AlgoId { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AlgoPlanName { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PlanVersionId { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int? RefferId { get; set; }
    }
}
