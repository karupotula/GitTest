using System.Collections.Generic;
using System.Runtime.Serialization;

namespace iFoundry.Entities
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/Pricer")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/Pricer", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "PricerInfo", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/Pricer")]
    public partial class PricerInfo:pattern 
    {
        private PricerAlgorithm pricerField;

            public PricerInfo()
            {
                this.pricerField = new PricerAlgorithm();
            }

            [System.Xml.Serialization.XmlElementAttribute(ElementName = "pricerAlgorithm", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/Pricer")]
            [System.Runtime.Serialization.DataMemberAttribute()]
            public PricerAlgorithm PricerAlgorithm
            {
                get
                {
                    return this.pricerField;
                }
                set
                {
                    this.pricerField = value;
                }
            }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.Runtime.Serialization.DataMemberAttribute()]
            public bool IsApprovedVersion { get; set; }

        /// <summary>
        /// defId
        /// </summary>
        public string defId { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/Pricer")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "pricerAlgorithm", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/Pricer")]
    public partial class PricerAlgorithm : BaseEntity<PricerAlgorithm>
    {
        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<ExpContent> ExpContent { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("dispalyContent")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<DispalyContent> DispalyContent { get; set; }
        [DataMember]
        public List<AlgoBlockInfo> Blocks { get; set; }
    }
}
