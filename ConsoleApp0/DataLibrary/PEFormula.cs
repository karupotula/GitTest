using System.Collections.Generic;
using System.Runtime.Serialization;


namespace iFoundry.Entities
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Core/Calculation")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "PEFormula", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/Formula")]
    public partial class PEFormula : BaseEntity<PEFormula>
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

    [DataContract]
    public class AlgoBlockInfo
    {
        
        [DataMember]
        public string AntlrExprContent { get; set; }
        [DataMember]
        public string BlockName { get; set; }
        [DataMember]
        public bool IsNotMainBlock { get; set; }
        [DataMember]
        public BlockReturnType ReturnType { get; set; }
        [DataMember]
        public string ReturnVariable { get; set; }
        [DataMember]
        public string MetaData { get; set; }
        [DataMember]
        public string ActulalAntlr { get; set; }
        [DataMember]
        public string AlgoType { get; set; }
        [DataMember]
        public List<AlgoExpressionInfo> Expressions { get; set; }
        
        [DataMember]
        public bool IsEdit;
        
    }

    [DataContract]
    public class AlgoExpressionInfo
    {     
        [DataMember]
        public string AntlrString { get; set; }

        [DataMember]
        public string DisplayString { get; set; }

        [DataMember]
        public bool IsDirty { get; set; }
        [DataMember]
        public ExpressionsTypes ExprType { get; set; }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Core/Calculation")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ExpContent", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns")]
    public partial class ExpContent 
    {

        [System.Xml.Serialization.XmlText]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AntlrContent { get; set; }
        [System.Xml.Serialization.XmlAttribute("blockName")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BlockName { get; set; }
        [System.Xml.Serialization.XmlAttribute("returnType")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReturnType { get; set; }
        [System.Xml.Serialization.XmlAttribute("isdeviat")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsDeviat { get; set; }
        


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string  AlgoType { get; set; }

        private string blockdecisionField = "NA";

        [System.Xml.Serialization.XmlAttribute("BlockDecision")]
        [DataMember(Name = "BlockDecision")]
        public string BlockDecision
        {
            get
            {
                return blockdecisionField;
            }
            set { this.blockdecisionField = value; }

        }

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Core/Calculation")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DispalyContent", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns")]
    public partial class DispalyContent
    {

        [System.Xml.Serialization.XmlText]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExpContent { get; set; }
        [System.Xml.Serialization.XmlAttribute("blockName")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BlockName { get; set; }
        [System.Xml.Serialization.XmlAttribute("returnType")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReturnType { get; set; }

    }

    public enum BlockReturnType
    {
        None,
        Integer,
        Decimal,
        String,
        Boolean,
        DateTime
    }
    public enum ExpressionsTypes
    {
        Formulae,
        Pricer,
        PriceElement,
        PriceComponent,
        Formula,
        MasterPricer,
        Adjustment,
        PlanFormula
    }
}
