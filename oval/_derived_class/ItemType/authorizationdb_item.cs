using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class authorizationdb_item : ItemType {
        private EntityItemStringType right_nameField;
        private EntityItemStringType xpathField;
        private EntityItemAnySimpleType[] value_ofField;
        public EntityItemStringType right_name {
            get {
                return this.right_nameField;
            }
            set {
                this.right_nameField = value;
            }
        }
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

