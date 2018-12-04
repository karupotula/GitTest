using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace iFoundry.Entities
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Common/Entities")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "pattern", Namespace = "http://www.valuemomentum.com/iFoundry/Patterns/PC")]
    public abstract partial class pattern : BaseEntity<pattern>
    {
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "id", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id { get; set; }
       

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "name", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name { get; set; }


        [System.Xml.Serialization.XmlElementAttribute(ElementName = "displayName", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DisplayName { get; set; }

        [System.Xml.Serialization.XmlIgnore()]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "id", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "internalName", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InternalName { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "description", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "version", Namespace = "http://www.valuemomentum.com/iFoundry/Common", DataType = "double")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Double Version { get; set; }

        [System.Xml.Serialization.XmlIgnore()]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "createdBy", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CreatedBy { get; set; }
        [System.Xml.Serialization.XmlIgnore()]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "createdDate", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Nullable<System.DateTime> CreatedDate { get; set; }
        [System.Xml.Serialization.XmlIgnore()]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastModifiedBy", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastModifiedBy { get; set; }
        [System.Xml.Serialization.XmlIgnore()]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastModifiedDate", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        [System.Xml.Serialization.XmlIgnore()]

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "effectiveDate", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        [System.Xml.Serialization.XmlIgnore()]
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "expiryDate", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Nullable<System.DateTime> ExpiryDate { get; set; }


        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        //[System.Runtime.Serialization.DataMemberAttribute()]
        //public Nullable<status> Status { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "planName", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlanName { get; set; }

        [System.Xml.Serialization.XmlIgnore()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mapping_Status { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "Sequence", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sequence { get; set; }

        /// <summary>
        /// .ctor class constructor
        /// </summary>
        public pattern()
        {

        }

        

        /// <summary>
        /// planFormula Definition Id
        /// </summary>
        [System.Xml.Serialization.XmlIgnore()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DefinitionId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("tableType", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TableCategory tableType { get; set; }


        [System.Xml.Serialization.XmlElementAttribute("BureauReference", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BureauReference { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.valuemomentum.com/iFoundry/Common/Enumerations")]
    public enum TableCategory
    {
        [Description("Others")]
        Others,
        [Description("Base Rate")]
        BaseRate,
        [Description("Base Premium")]
        BasePremium,
        [Description("Minimum Premium")]
        MinimumPremium,
        [Description("Tax")]
        Tax,
        [Description("Discount Factor")]
        DiscountFactor,
        [Description("Credit Factor")]
        CreditFactor,
        [Description("Factor")]
        Factor,
        [Description("Fee")]
        Fee,
        [Description("Loss Cost")]
        LossCost,
        [Description("Stat Code")]
        StatCode,
        [Description("Loss Cost Multiplier")]
        LossCostMultiplier,
        [Description("Multiplier")]
        Multiplier,
        [Description("Limit Factor")]
        LimitFactor,
        [Description("Deductible Factor")]
        DeductibleFactor,
        [Description("Rate")]
        Rate,
        [Description("Classification")]
        Classification,
        [Description("Surcharge")]
        Surcharge,
        [Description("Preliminary Base Premium")]
        PreliminaryBasePremium,
        [Description("Expense Constant")]
        ExpenseConstant,
        [Description("Discount")]
        Discount,
        [Description("Code")]
        Code,
        [Description("Premium")]
        Premium,
        [Description("Debit")]
        Debit,
        [Description("Credit")]
        Credit,
    }
}
