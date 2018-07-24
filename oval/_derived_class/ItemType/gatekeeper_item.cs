using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class gatekeeper_item : ItemType {
        private EntityItemBoolType enabledField;
        private EntityItemStringType[] unlabeledField;
        public EntityItemBoolType enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        [XmlElementAttribute("unlabeled")]
        public EntityItemStringType[] unlabeled {
            get {
                return this.unlabeledField;
            }
            set {
                this.unlabeledField = value;
            }
        }
    }

}

