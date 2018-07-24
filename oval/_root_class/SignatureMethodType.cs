using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SignatureMethod", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class SignatureMethodType {
        private string hMACOutputLengthField;
        private System.Xml.XmlNode[] anyField;
        private string algorithmField;
        [XmlElementAttribute(DataType="integer")]
        public string HMACOutputLength {
            get {
                return this.hMACOutputLengthField;
            }
            set {
                this.hMACOutputLengthField = value;
            }
        }
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
        [XmlAttribute(DataType="anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }

}

