using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public class X509IssuerSerialType {
        private string x509IssuerNameField;
        private string x509SerialNumberField;
        public string X509IssuerName {
            get {
                return this.x509IssuerNameField;
            }
            set {
                this.x509IssuerNameField = value;
            }
        }
        [XmlElementAttribute(DataType="integer")]
        public string X509SerialNumber {
            get {
                return this.x509SerialNumberField;
            }
            set {
                this.x509SerialNumberField = value;
            }
        }
    }

}

