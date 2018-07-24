using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("KeyInfo", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class KeyInfoType {
        private object[] itemsField;
        private ItemsChoiceType2[] itemsElementNameField;
        private string[] textField;
        private string idField;
        [XmlAnyElementAttribute]
        [XmlElementAttribute("KeyName", typeof(string))]
        [XmlElementAttribute("KeyValue", typeof(KeyValueType))]
        [XmlElementAttribute("MgmtData", typeof(string))]
        [XmlElementAttribute("PGPData", typeof(PGPDataType))]
        [XmlElementAttribute("RetrievalMethod", typeof(RetrievalMethodType))]
        [XmlElementAttribute("SPKIData", typeof(SPKIDataType))]
        [XmlElementAttribute("X509Data", typeof(X509DataType))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        [XmlElementAttribute("ItemsElementName")]
        [XmlIgnoreAttribute]
        public ItemsChoiceType2[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
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

