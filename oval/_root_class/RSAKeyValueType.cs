using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("RSAKeyValue", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class RSAKeyValueType {
        private byte[] modulusField;
        private byte[] exponentField;
        [XmlElementAttribute(DataType="base64Binary")]
        public byte[] Modulus {
            get {
                return this.modulusField;
            }
            set {
                this.modulusField = value;
            }
        }
        [XmlElementAttribute(DataType="base64Binary")]
        public byte[] Exponent {
            get {
                return this.exponentField;
            }
            set {
                this.exponentField = value;
            }
        }
    }

}

