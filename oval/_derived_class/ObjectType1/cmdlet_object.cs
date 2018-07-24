using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class cmdlet_object : ObjectType1 {
        private object[] itemsField;
        private ItemsChoiceType14[] itemsElementNameField;
        [XmlElementAttribute("module_id", typeof(EntityObjectGUIDType), IsNullable=true)]
        [XmlElementAttribute("module_name", typeof(EntityObjectStringType), IsNullable=true)]
        [XmlElementAttribute("module_version", typeof(EntityObjectVersionType), IsNullable=true)]
        [XmlElementAttribute("noun", typeof(EntityObjectStringType))]
        [XmlElementAttribute("parameters", typeof(EntityObjectRecordType), IsNullable=true)]
        [XmlElementAttribute("select", typeof(EntityObjectRecordType), IsNullable=true)]
        [XmlElementAttribute("verb", typeof(EntityObjectCmdletVerbType))]
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
        public ItemsChoiceType14[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }

}

