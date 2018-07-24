using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#junos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#junos", IsNullable=false)]
    public class xml_config_item : ItemType {
        private EntityItemStringType xpathField;
        private EntityItemAnySimpleType[] value_ofField;
        public EntityItemStringType xpath {
            get {
                return this.xpathField;
            }
            set {
                this.xpathField = value;
            }
        }
        [XmlElementAttribute("value_of")]
        public EntityItemAnySimpleType[] value_of {
            get {
                return this.value_ofField;
            }
            set {
                this.value_ofField = value;
            }
        }
    }

}

