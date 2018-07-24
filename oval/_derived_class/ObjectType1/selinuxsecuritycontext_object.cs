using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class selinuxsecuritycontext_object : ObjectType1 {
        private object[] itemsField;
        private ItemsChoiceType65[] itemsElementNameField;
        [XmlElementAttribute("behaviors", typeof(FileBehaviors3))]
        [XmlElementAttribute("filename", typeof(EntityObjectStringType), IsNullable=true)]
        [XmlElementAttribute("filepath", typeof(EntityObjectStringType))]
        [XmlElementAttribute("path", typeof(EntityObjectStringType))]
        [XmlElementAttribute("pid", typeof(EntityObjectIntType), IsNullable=true)]
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
        public ItemsChoiceType65[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }

}

