using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace iFoundry.Entities
{
    #region Base entity class
    [DataContract]
    public partial class BaseEntity<T> where T:class
    {

        private static System.Xml.Serialization.XmlSerializer serializer;

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current BaseEntity object into an XML document
        /// </summary>
        // <returns>string XML value</returns>
        public virtual string Serialize(XmlSerializerNamespaces ns)
        {
            MemoryStream memoryStream = null;
            try
            {

                if (ns == null) ns = GetCommonNameSpaceManger();
                XmlSerializer s = new XmlSerializer(this.GetType());
                memoryStream = new MemoryStream();
                XmlTextWriter sw = new XmlTextWriter(memoryStream, Encoding.UTF8);
                s.Serialize(sw, this, ns);
                memoryStream = (MemoryStream)sw.BaseStream;
                sw.Flush();          
                // If we dispose the StreamWriter now, it will close          
                // the BaseStream (which is our MemoryStream) which          
                // will prevent us from reading from our MemoryStream         
                //DON'T DO THIS - sw.Dispose();          
                // The StreamReader will read from the current          
                // position of the MemoryStream which is currently          
                // set at the end of the string we just wrote to it.         
                // We need to set the position to 0 in order to read          
                // from the beginning.         
                memoryStream.Position = 0;
                var sr = new StreamReader(memoryStream);
                string streamXml = sr.ReadToEnd(); 
                XmlDocument doc = new XmlDocument();
                //string streamXml = UTF8ByteArrayToString(memoryStream.ToArray());
                streamXml = streamXml.Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>", "");
                doc.LoadXml(streamXml);
                return doc.OuterXml;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }
        private string UTF8ByteArrayToString(Byte[] characters)
        {
            try
            {
                UTF8Encoding encoding = new UTF8Encoding();
                String constructedString = encoding.GetString(characters);
                return (constructedString.Trim());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Deserializes workflow markup into an BaseEntity object
        /// </summary>
        // <param name="xml">string workflow markup to deserialize</param>
        // <param name="obj">Output BaseEntity object</param>
        // <param name="exception">output Exception value if deserialize failed</param>
        // <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out T obj, out System.Exception exception)
        {
            exception = null;
            obj = default(T);
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool Deserialize(string xml, out T obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static T Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);

                return ((T)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));

            }
            catch (InvalidOperationException)
            {
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        #region Commented        

        ///// <summary>
        ///// Serializes current BaseEntity object into file
        ///// </summary>
        //// <param name="fileName">full path of outupt xml file</param>
        //// <param name="exception">output Exception value if failed</param>
        //// <returns>true if can serialize and save into file; otherwise, false</returns>
        //public virtual bool SaveToFile(string fileName, out System.Exception exception)
        //{
        //    exception = null;
        //    try
        //    {
        //        SaveToFile(fileName);
        //        return true;
        //    }
        //    catch (System.Exception e)
        //    {
        //        exception = e;
        //        return false;
        //    }
        //}

        //public virtual void SaveToFile(string fileName)
        //{
        //    System.IO.StreamWriter streamWriter = null;
        //    try
        //    {
        //        string xmlString = Serialize();
        //        System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
        //        streamWriter = xmlFile.CreateText();
        //        streamWriter.WriteLine(xmlString);
        //        streamWriter.Close();
        //    }
        //    finally
        //    {
        //        if ((streamWriter != null))
        //        {
        //            streamWriter.Dispose();
        //        }
        //    }
        //}

        ///// <summary>
        ///// Deserializes workflow markup from file into an BaseEntity object
        ///// </summary>
        //// <param name="xml">string workflow markup to deserialize</param>
        //// <param name="obj">Output BaseEntity object</param>
        //// <param name="exception">output Exception value if deserialize failed</param>
        //// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        //public static bool LoadFromFile(string fileName, out T obj, out System.Exception exception)
        //{
        //    exception = null;
        //    obj = default(T);
        //    try
        //    {
        //        obj = LoadFromFile(fileName);
        //        return true;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        exception = ex;
        //        return false;
        //    }
        //}

        //public static bool LoadFromFile(string fileName, out T obj)
        //{
        //    System.Exception exception = null;
        //    return LoadFromFile(fileName, out obj, out exception);
        //}

        //public static T LoadFromFile(string fileName)
        //{
        //    System.IO.FileStream file = null;
        //    System.IO.StreamReader sr = null;
        //    try
        //    {
        //        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        //        sr = new System.IO.StreamReader(file);
        //        string xmlString = sr.ReadToEnd();
        //        sr.Close();
        //        file.Close();
        //        return Deserialize(xmlString);
        //    }
        //    finally
        //    {
        //        if ((file != null))
        //        {
        //            file.Dispose();
        //        }
        //        if ((sr != null))
        //        {
        //            sr.Dispose();
        //        }
        //    }
        //}
        #endregion

        #endregion


        private static XmlSerializerNamespaces GetCommonNameSpaceManger()
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("xs", "http://www.w3.org/2001/XMLSchema-instance");
            ns.Add("ifd", "http://www.valuemomentum.com/iFoundry/Domains");
            ns.Add("ifc", "http://www.valuemomentum.com/iFoundry/Common");
            ns.Add("ifbt", "http://www.valuemomentum.com/iFoundry/BusinessTerms");
            ns.Add("ifbe", "http://www.valuemomentum.com/iFoundry/Common/Entities");
            ns.Add("ifbo", "http://www.valuemomentum.com/iFoundry/Patterns/BusinessObject");
            ns.Add("ifpt", "http://www.valuemomentum.com/iFoundry/Patterns/Part");
            ns.Add("iffe", "http://www.valuemomentum.com/iFoundry/Patterns/Feature");
            ns.Add("iff", "http://www.valuemomentum.com/iFoundry/Entity/Factor");
            ns.Add("iffc", "http://www.valuemomentum.com/iFoundry/Factor/Common");
            ns.Add("iffg", "http://www.valuemomentum.com/iFoundry/Entity/FactorGroup");
            ns.Add("ifadjlib", "http://www.valuemomentum.com/iFoundry/Patterns/AdjustmentLibrary");
            ns.Add("ifcp", "http://www.valuemomentum.com/iFoundry/Plans/Plan");
            ns.Add("iffp", "http://www.valuemomentum.com/iFoundry/Plans/FormulaPlan");
            ns.Add("ifcd", "http://www.valuemomentum.com/iFoundry/Core/DecisionRules");
            ns.Add("cf", "http://www.valuemomentum.com/iFoundry/Patterns/CompositeFeature");
            ns.Add("ifpelib", "http://www.valuemomentum.com/iFoundry/Patterns/PELibrary");
            ns.Add("rules", "http://www.valuemomentum.com/iFoundry/Core/Rules");
            return ns;
        }
    }
    #endregion
}
