using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class rpmverifypackage_object : ObjectType1 {
        private object[] itemsField;
        private ItemsChoiceType64[] itemsElementNameField;
        [XmlElementAttribute("arch", typeof(EntityObjectStringType))]
        [XmlElementAttribute("behaviors", typeof(RpmVerifyPackageBehaviors))]
        [XmlElementAttribute("epoch", typeof(rpmverifypackage_objectEpoch))]
        [XmlElementAttribute("name", typeof(EntityObjectStringType))]
        [XmlElementAttribute("release", typeof(rpmverifypackage_objectRelease))]
        [XmlElementAttribute("version", typeof(rpmverifypackage_objectVersion))]
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
        public ItemsChoiceType64[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }

}

