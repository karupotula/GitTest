using System.Collections.Generic;

// <copyright file=" " company="ValueMomentum Software Services">
// Copyright (c) 2016 All Rights Reserved
// <author>Santosh Kumar Yedla</author>
// </copyright>

namespace iFoundry.Entities
{
    /// <summary>
    /// FormRules Class
    /// </summary>
    public class FormRules : BaseUnifiedEntity
    {
        /// <summary>
        /// Name 
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("name", Namespace = "http://www.valuemomentum.com/iFoundry/Common")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name { get; set; }

        /// <summary>
        /// defId
        /// </summary>
        /// 
        /// <summary>
        /// formulaeName as algorithm name
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "defId")]
        public string defId { get; set; }

        /// <summary>
        ///  factorGroupName as scopeName here
        /// </summary>
        public string factorGroupName { set; get; }

        /// <summary>
        /// formulaeName as algorithm name
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "formulaName")]
        public string formulaeName { set; get; }

        /// <summary>
        /// Effective Date
        /// </summary>
        [System.Xml.Serialization.XmlIgnore()]
        public System.DateTime effectiveDate { set; get; }

        /// <summary>
        /// Expiry Date
        /// </summary>
        [System.Xml.Serialization.XmlIgnore()]
        public System.DateTime expiryDate { set; get; }

        /// <summary>
        /// Block Exponents
        /// </summary>
        public List<ExpContent> blockExponents { set; get; }

        /// <summary>
        /// Blocks
        /// </summary>
        public List<AlgoBlockInfo> Blocks { get; set; }
        /// <summary>
        /// if its refer
        /// </summary>
        //[System.Xml.Serialization.XmlElementAttribute(ElementName = "refer")]
        //[System.Runtime.Serialization.DataMemberAttribute()]
        //public OwnershipInfo OwnershipInfo { get; set; }
    }
}
