using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Object", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class ObjectType {
        private System.Xml.XmlNode[] anyField;
        private string idField;
        private string mimeTypeField;
        private string encodingField;
        [XmlTextAttribute]
        [XmlAnyElementAttribute]
        public System.Xml.XmlNode[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        [XmlAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        [XmlAttribute]
        public string MimeType {
            get {
                return this.mimeTypeField;
            }
            set {
                this.mimeTypeField = value;
            }
        }
        [XmlAttribute(DataType="anyURI")]
        public string Encoding {
            get {
                return this.encodingField;
            }
            set {
                this.encodingField = value;
            }
        }
    }

}

