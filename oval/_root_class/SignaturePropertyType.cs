using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SignatureProperty", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class SignaturePropertyType {
        private System.Xml.XmlElement[] itemsField;
        private string[] textField;
        private string targetField;
        private string idField;
        [XmlAnyElementAttribute]
        public System.Xml.XmlElement[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        [XmlTextAttribute]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        [XmlAttribute(DataType="anyURI")]
        public string Target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
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
    }

}

