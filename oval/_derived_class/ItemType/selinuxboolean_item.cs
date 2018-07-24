using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux", IsNullable=false)]
    public class selinuxboolean_item : ItemType {
        private EntityItemStringType nameField;
        private EntityItemBoolType current_statusField;
        private EntityItemBoolType pending_statusField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemBoolType current_status {
            get {
                return this.current_statusField;
            }
            set {
                this.current_statusField = value;
            }
        }
        public EntityItemBoolType pending_status {
            get {
                return this.pending_statusField;
            }
            set {
                this.pending_statusField = value;
            }
        }
    }

}

