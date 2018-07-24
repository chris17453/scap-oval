using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios", IsNullable=false)]
    public class snmpgroup_item : ItemType {
        private EntityItemStringType nameField;
        private EntityItemSNMPVersionStringType versionField;
        private EntityItemSNMPSecLevelStringType snmpv3_sec_levelField;
        private EntityItemStringType ipv4_aclField;
        private EntityItemStringType ipv6_aclField;
        private EntityItemStringType read_viewField;
        private EntityItemStringType write_viewField;
        private EntityItemStringType notify_viewField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
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
        public EntityItemStringType ipv4_acl {
            get {
                return this.ipv4_aclField;
            }
            set {
                this.ipv4_aclField = value;
            }
        }
        public EntityItemStringType ipv6_acl {
            get {
                return this.ipv6_aclField;
            }
            set {
                this.ipv6_aclField = value;
            }
        }
        public EntityItemStringType read_view {
            get {
                return this.read_viewField;
            }
            set {
                this.read_viewField = value;
            }
        }
        public EntityItemStringType write_view {
            get {
                return this.write_viewField;
            }
            set {
                this.write_viewField = value;
            }
        }
        public EntityItemStringType notify_view {
            get {
                return this.notify_viewField;
            }
            set {
                this.notify_viewField = value;
            }
        }
    }

}

