using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios", IsNullable=false)]
    public class snmphost_item : ItemType {
        private EntityItemStringType hostField;
        private EntityItemStringType community_or_userField;
        private EntityItemSNMPVersionStringType versionField;
        private EntityItemSNMPSecLevelStringType snmpv3_sec_levelField;
        private EntityItemStringType trapsField;
        public EntityItemStringType host {
            get {
                return this.hostField;
            }
            set {
                this.hostField = value;
            }
        }
        public EntityItemStringType community_or_user {
            get {
                return this.community_or_userField;
            }
            set {
                this.community_or_userField = value;
            }
        }
        public EntityItemSNMPVersionStringType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        public EntityItemSNMPSecLevelStringType snmpv3_sec_level {
            get {
                return this.snmpv3_sec_levelField;
            }
            set {
                this.snmpv3_sec_levelField = value;
            }
        }
        public EntityItemStringType traps {
            get {
                return this.trapsField;
            }
            set {
                this.trapsField = value;
            }
        }
    }

}

