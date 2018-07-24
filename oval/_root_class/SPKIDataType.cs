using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SPKIData", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class SPKIDataType {
        private byte[][] sPKISexpField;
        private System.Xml.XmlElement anyField;
        [XmlElementAttribute("SPKISexp", DataType="base64Binary")]
        public byte[][] SPKISexp {
            get {
                return this.sPKISexpField;
            }
            set {
                this.sPKISexpField = value;
            }
        }
        [XmlAnyElementAttribute]
        public System.Xml.XmlElement Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }

}

