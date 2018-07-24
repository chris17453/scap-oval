using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class regkeyauditedpermissions_object : ObjectType1 {
        private object[] itemsField;
        private ItemsChoiceType25[] itemsElementNameField;
        [XmlElementAttribute("behaviors", typeof(RegkeyAuditPermissionsBehaviors))]
        [XmlElementAttribute("hive", typeof(EntityObjectRegistryHiveType))]
        [XmlElementAttribute("key", typeof(EntityObjectStringType))]
        [XmlElementAttribute("trustee_name", typeof(EntityObjectStringType))]
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
        public ItemsChoiceType25[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }

}

