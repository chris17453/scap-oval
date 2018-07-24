using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class selinuxboolean_state : StateType {
        private EntityStateStringType nameField;
        private EntityStateBoolType current_statusField;
        private EntityStateBoolType pending_statusField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateBoolType current_status {
            get {
                return this.current_statusField;
            }
            set {
                this.current_statusField = value;
            }
        }
        public EntityStateBoolType pending_status {
            get {
                return this.pending_statusField;
            }
            set {
                this.pending_statusField = value;
            }
        }
    }

}

