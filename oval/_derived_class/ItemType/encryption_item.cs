using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android", IsNullable=false)]
    public class encryption_item : ItemType {
        private EntityItemBoolType encryption_policy_enabledField;
        private EntityItemEncryptionStatusType encryption_statusField;
        public EntityItemBoolType encryption_policy_enabled {
            get {
                return this.encryption_policy_enabledField;
            }
            set {
                this.encryption_policy_enabledField = value;
            }
        }
        public EntityItemEncryptionStatusType encryption_status {
            get {
                return this.encryption_statusField;
            }
            set {
                this.encryption_statusField = value;
            }
        }
    }

}

