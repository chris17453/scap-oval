using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Transform", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class TransformType {
        private object[] itemsField;
        private string[] textField;
        private string algorithmField;
        [XmlAnyElementAttribute]
        [XmlElementAttribute("XPath", typeof(string))]
        public object[] Items {
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

