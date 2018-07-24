using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("X509Data", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class X509DataType {
        private object[] itemsField;
        private ItemsChoiceType[] itemsElementNameField;
        [XmlAnyElementAttribute]
        [XmlElementAttribute("X509CRL", typeof(byte[]), DataType="base64Binary")]
        [XmlElementAttribute("X509Certificate", typeof(byte[]), DataType="base64Binary")]
        [XmlElementAttribute("X509IssuerSerial", typeof(X509IssuerSerialType))]
        [XmlElementAttribute("X509SKI", typeof(byte[]), DataType="base64Binary")]
        [XmlElementAttribute("X509SubjectName", typeof(string))]
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
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }

}

