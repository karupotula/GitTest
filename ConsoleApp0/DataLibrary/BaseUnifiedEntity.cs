using System;
using System.Runtime.Serialization;

// <copyright file=" " company="ValueMomentum Software Services">
// Copyright (c) 2016 All Rights Reserved
// <author>Santosh Kumar Yedla</author>
// </copyright>

namespace iFoundry.Entities
{
    /// <summary>
    /// Base Unified Entity Class
    /// </summary>
    [DataContract]
    public class BaseUnifiedEntity
    {
        /// <summary>
        /// Guid
        /// </summary>
        [DataMember]
        public string id { get; set; }


        /// <summary>
        /// Id
        /// </summary>
        [System.Xml.Serialization.XmlIgnore()]
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        ///Created Date
        /// </summary>
        [DataMember]
        [System.Xml.Serialization.XmlIgnore()]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        ///Modified Date
        /// </summary>
        [DataMember]
        [System.Xml.Serialization.XmlIgnore()]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        ///Created By
        /// </summary>
        [DataMember]
        [System.Xml.Serialization.XmlIgnore()]
        public string CreatedBy { get; set; }

        /// <summary>
        ///Modified By
        /// </summary>
        [DataMember]
        [System.Xml.Serialization.XmlIgnore()]
        public string ModifiedBy { get; set; }

        ///// <summary>
        ///// Unified PlanVersion Status
        ///// </summary>
        //[DataMember]
        //[System.Xml.Serialization.XmlIgnore()]
        //public DefinitionStatus Mode { get; set; }
        

    }
}
