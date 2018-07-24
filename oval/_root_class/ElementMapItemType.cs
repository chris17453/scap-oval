using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
    public class ElementMapItemType {
        private string target_namespaceField;
        private string valueField;
        [XmlAttribute(DataType="anyURI")]
        public string target_namespace {
            get {
                return this.target_namespaceField;
            }
            set {
                this.target_namespaceField = value;
            }
        }
        [XmlTextAttribute(DataType="NCName")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

