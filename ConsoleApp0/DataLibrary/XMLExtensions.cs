using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Xml.Schema;
using System.Runtime.Serialization;
using iFoundry.Entities;
using System.Linq;
using System.Xml.Linq;
using System.Collections;
namespace iFoundry.Shared
{
    public static class XMLExtensions
    {
        public static string Serialize<T>(this T t, XmlSerializerNamespaces ns)
        // where T : IXmlSerializable
        {
            XmlSerializer s = new XmlSerializer(t.GetType());
            MemoryStream memoryStream = new MemoryStream();
            XmlTextWriter sw = new XmlTextWriter(memoryStream, Encoding.UTF8);
            s.Serialize(sw, t, ns);
            memoryStream = (MemoryStream)sw.BaseStream;            
            sw.Flush();
            memoryStream.Position = 0;
            var sr = new StreamReader(memoryStream);
            string streamXml = sr.ReadToEnd();
            XmlDocument doc = new XmlDocument();
            //string streamXml = UTF8ByteArrayToString(memoryStream.ToArray());
            streamXml = streamXml.Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>", "");
            doc.LoadXml(streamXml);
            return doc.OuterXml;
        }
        public static T DeSerialize<T>(this string xmlString)
        //where T : IXmlSerializable
        {
            try
            {
                XmlSerializer s = new XmlSerializer(typeof(T));

                byte[] buffer = ASCIIEncoding.UTF8.GetBytes(xmlString);
                MemoryStream ms = new MemoryStream(buffer);
                XmlReader reader = new XmlTextReader(ms);
                return (T)s.Deserialize(reader);
            }
            catch (Exception ex)
            {
               throw ex;
            }
        }
        private static readonly Hashtable serializerCache = new Hashtable();
        public static string ToXMLString(object obj, string nodeName)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            Type type = obj.GetType();
            var cacheKey = new { Type = type, Name = nodeName };
            XmlSerializer xmlSerializer = (XmlSerializer)serializerCache[cacheKey];
            if (xmlSerializer == null)
            {
                lock (serializerCache)
                { // double-checked
                    xmlSerializer = (XmlSerializer)serializerCache[cacheKey];
                    if (xmlSerializer == null)
                    {
                        xmlSerializer = new XmlSerializer(type, new XmlRootAttribute(nodeName));
                        serializerCache.Add(cacheKey, xmlSerializer);
                    }
                }
            }
            try
            {
                StringWriter sw = new StringWriter();
                using (XmlWriter writer = XmlWriter.Create(sw,
                    new XmlWriterSettings() { OmitXmlDeclaration = true, Indent = true }))
                {
                    // Don't include XML namespace
                    XmlSerializerNamespaces xmlnsEmpty = new XmlSerializerNamespaces();
                    xmlnsEmpty.Add("ifc", "http://www.valuemomentum.com/iFoundry/Common");
                    xmlnsEmpty.Add("ifbt", "http://www.valuemomentum.com/iFoundry/BusinessTerms");
                    xmlnsEmpty.Add("ifbe", "http://www.valuemomentum.com/iFoundry/Common/Entities");
                    xmlnsEmpty.Add("ifpelib", "http://www.valuemomentum.com/iFoundry/Patterns/PELibrary");
                    xmlnsEmpty.Add("iftab", "http://www.valuemomentum.com/iFoundry/Core/Table");
                    xmlnsEmpty.Add("ifcalc", "http://www.valuemomentum.com/iFoundry/Core/Calculation");
                    xmlnsEmpty.Add("iff", "http://www.valuemomentum.com/iFoundry/Entity/Factor");
                    xmlnsEmpty.Add("iffc", "http://www.valuemomentum.com/iFoundry/Factor/Common");
                    xmlnsEmpty.Add("iffg", "http://www.valuemomentum.com/iFoundry/Entity/FactorGroup");
                    xmlnsEmpty.Add("ifadjlib", "http://www.valuemomentum.com/iFoundry/Patterns/AdjustmentLibrary");
                    xmlSerializer.Serialize(writer, obj, xmlnsEmpty);
                }
                string streamXml = sw.ToString(); ;
                XmlDocument doc = new XmlDocument();
                streamXml = streamXml.Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>", "");
                doc.LoadXml(streamXml);
                return doc.OuterXml;

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw;
            }
        }
        public static XmlSerializerNamespaces GetNameSpace()
        {
            try
            {
                XmlSerializerNamespaces l_xmlns = new XmlSerializerNamespaces();
                l_xmlns.Add("ifc", "http://www.valuemomentum.com/iFoundry/Common");
                l_xmlns.Add("ifbt", "http://www.valuemomentum.com/iFoundry/BusinessTerms");
                l_xmlns.Add("ifbe", "http://www.valuemomentum.com/iFoundry/Common/Entities");
                l_xmlns.Add("ifpelib", "http://www.valuemomentum.com/iFoundry/Patterns/PELibrary");
                l_xmlns.Add("iftab", "http://www.valuemomentum.com/iFoundry/Core/Table");
                l_xmlns.Add("ifcalc", "http://www.valuemomentum.com/iFoundry/Core/Calculation");
                l_xmlns.Add("iff", "http://www.valuemomentum.com/iFoundry/Entity/Factor");
                l_xmlns.Add("iffc", "http://www.valuemomentum.com/iFoundry/Factor/Common");
                l_xmlns.Add("iffg", "http://www.valuemomentum.com/iFoundry/Entity/FactorGroup");
                l_xmlns.Add("ifadjlib", "http://www.valuemomentum.com/iFoundry/Patterns/AdjustmentLibrary");
                l_xmlns.Add("xs", "http://www.w3.org/2001/XMLSchema-instance");
                l_xmlns.Add("ifcp", "http://www.valuemomentum.com/iFoundry/Plans/Plan");
                l_xmlns.Add("ifcd", "http://www.valuemomentum.com/iFoundry/Core/DecisionRules");
                l_xmlns.Add("ifd", "http://www.valuemomentum.com/iFoundry/Domains");
                l_xmlns.Add("iffp", "http://www.valuemomentum.com/iFoundry/Plans/FormulaPlan");
                l_xmlns.Add("ifbo", "http://www.valuemomentum.com/iFoundry/Patterns/Risk");
                l_xmlns.Add("ifpt", "http://www.valuemomentum.com/iFoundry/Patterns/Coverages");
                l_xmlns.Add("ifdt", "http://www.valuemomentum.com/iFoundry/Patterns/DomainTable");

                return l_xmlns;
            }
            catch
            {
                //LogHelper.LogMethodInfo(MethodBase.GetCurrentMethod());
                throw;
            }
        }
        private static string UTF8ByteArrayToString(Byte[] characters)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            String constructedString = encoding.GetString(characters);
            return (constructedString.Trim());
        }
        public static bool AppendAttribute(this XmlDocument document, XmlElement element, string attributeName, string innerText)
        {
            try
            {
                if (document != null && element != null && !String.IsNullOrEmpty(attributeName))
                {
                    XmlAttribute newElement = document.CreateAttribute(attributeName);
                    newElement.Value = innerText;
                    element.Attributes.Append(newElement);
                    return true;
                }
                else
                {
                    throw new XmlException("Document,Element or attributeName cannot be null");
                }
            }
            catch
            {
                throw;
            }

        }

        
        /// <summary>
        /// returns the normalize of the XElement
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static XElement Normalize(XElement element)
        {
            if (element.HasElements)
            {
                return new XElement(
                    element.Name,
                    element.Attributes().Where(a => a.Name.Namespace == XNamespace.Xmlns)
                    .OrderBy(a => a.Name.ToString()),
                    element.Elements().OrderBy(a => a.Name.ToString())

                    .Select(e => Normalize(e)));
            }

            if (element.IsEmpty)
            {
                return new XElement(element.Name, element.Attributes()
                    .OrderBy(a => a.Name.ToString()));
            }

            return new XElement(element.Name, element.Attributes()
                .OrderBy(a => a.Name.ToString()), element.Value);
        }
    }
    public static class DataContractSerilizerExt
    {
        public static T DeSerialize<T>(this string xmlString)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(T));
            byte[] buffer = ASCIIEncoding.UTF8.GetBytes(xmlString);
            MemoryStream ms = new MemoryStream(buffer);
            return (T)serializer.ReadObject(ms);
        }

        public static string Serialize<T>(T t, XmlSerializerNamespaces ns)
        {
            StringBuilder serialXML = new StringBuilder();
            DataContractSerializer dcSerializer = new DataContractSerializer(t.GetType());
            using (XmlWriter xWriter = XmlWriter.Create(serialXML))
            {
                dcSerializer.WriteObject(xWriter, t);
                xWriter.Flush();
                return serialXML.ToString().Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>", "");
            }
        }

    }
}
