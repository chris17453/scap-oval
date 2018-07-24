using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("PGPData", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class PGPDataType {
        private object[] itemsField;
        private ItemsChoiceType1[] itemsElementNameField;
        [XmlAnyElementAttribute]
        [XmlElementAttribute("PGPKeyID", typeof(byte[]), DataType="base64Binary")]
        [XmlElementAttribute("PGPKeyPacket", typeof(byte[]), DataType="base64Binary")]
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
        public ItemsChoiceType1[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }

}

