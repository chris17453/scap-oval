using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent", IsNullable=false)]
    public class ldap57_object : ObjectType1 {
        private object[] itemsField;
        private ItemsChoiceType6[] itemsElementNameField;
        [XmlElementAttribute("attribute", typeof(EntityObjectStringType), IsNullable=true)]
        [XmlElementAttribute("behaviors", typeof(LdapBehaviors))]
        [XmlElementAttribute("relative_dn", typeof(EntityObjectStringType), IsNullable=true)]
        [XmlElementAttribute("suffix", typeof(EntityObjectStringType))]
        [XmlElementAttribute("filter", typeof(filter), Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        [XmlElementAttribute("set", typeof(set), Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
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
        public ItemsChoiceType6[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }

}

