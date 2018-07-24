using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SignatureProperties", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class SignaturePropertiesType {
        private SignaturePropertyType[] signaturePropertyField;
        private string idField;
        [XmlElementAttribute("SignatureProperty")]
        public SignaturePropertyType[] SignatureProperty {
            get {
                return this.signaturePropertyField;
            }
            set {
                this.signaturePropertyField = value;
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

