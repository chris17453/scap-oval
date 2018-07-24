using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android", IsNullable=false)]
    public class encryption_state : StateType {
        private EntityStateBoolType encryption_policy_enabledField;
        private EntityStateEncryptionStatusType encryption_statusField;
        public EntityStateBoolType encryption_policy_enabled {
            get {
                return this.encryption_policy_enabledField;
            }
            set {
                this.encryption_policy_enabledField = value;
            }
        }
        public EntityStateEncryptionStatusType encryption_status {
            get {
                return this.encryption_statusField;
            }
            set {
                this.encryption_statusField = value;
            }
        }
    }

}

