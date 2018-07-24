using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe")]
    [XmlRootAttribute("snmphost_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe", IsNullable=false)]
    public class snmphost_state1 : StateType {
        private EntityStateStringType hostField;
        private EntityStateStringType community_or_userField;
        private EntityStateSNMPVersionStringType1 version1Field;
        private EntityStateSNMPSecLevelStringType1 snmpv3_sec_levelField;
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
        public EntityStateSNMPVersionStringType1 version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
        public EntityStateSNMPSecLevelStringType1 snmpv3_sec_level {
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

