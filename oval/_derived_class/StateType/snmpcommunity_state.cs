using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class snmpcommunity_state : StateType {
        private EntityStateStringType nameField;
        private EntityStateStringType viewField;
        private EntityStateSNMPModeStringType modeField;
        private EntityStateStringType ipv4_aclField;
        private EntityStateStringType ipv6_aclField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateStringType view {
            get {
                return this.viewField;
            }
            set {
                this.viewField = value;
            }
        }
        public EntityStateSNMPModeStringType mode {
            get {
                return this.modeField;
            }
            set {
                this.modeField = value;
            }
        }
        public EntityStateStringType ipv4_acl {
            get {
                return this.ipv4_aclField;
            }
            set {
                this.ipv4_aclField = value;
            }
        }
        public EntityStateStringType ipv6_acl {
            get {
                return this.ipv6_aclField;
            }
            set {
                this.ipv6_aclField = value;
            }
        }
    }

}

