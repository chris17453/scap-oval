using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class snmphost_state : StateType {
        private EntityStateStringType hostField;
        private EntityStateStringType community_or_userField;
        private EntityStateSNMPVersionStringType version1Field;
        private EntityStateSNMPSecLevelStringType snmpv3_sec_levelField;
        private EntityStateStringType trapsField;
        public EntityStateStringType host {
            get {
                return this.hostField;
            }
            set {
                this.hostField = value;
            }
        }
        public EntityStateStringType community_or_user {
            get {
                return this.community_or_userField;
            }
            set {
                this.community_or_userField = value;
            }
        }
        [XmlElementAttribute("version")]
        public EntityStateSNMPVersionStringType version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
        public EntityStateSNMPSecLevelStringType snmpv3_sec_level {
            get {
                return this.snmpv3_sec_levelField;
            }
            set {
                this.snmpv3_sec_levelField = value;
            }
        }
        public EntityStateStringType traps {
            get {
                return this.trapsField;
            }
            set {
                this.trapsField = value;
            }
        }
    }

}

