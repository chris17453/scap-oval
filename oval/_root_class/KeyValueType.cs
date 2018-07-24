using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("KeyValue", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class KeyValueType {
        private object itemField;
        private string[] textField;
        [XmlAnyElementAttribute]
        [XmlElementAttribute("DSAKeyValue", typeof(DSAKeyValueType))]
        [XmlElementAttribute("RSAKeyValue", typeof(RSAKeyValueType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
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
    }

}

