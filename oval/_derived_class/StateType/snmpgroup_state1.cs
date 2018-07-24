using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe")]
    [XmlRootAttribute("snmpgroup_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe", IsNullable=false)]
    public class snmpgroup_state1 : StateType {
        private EntityStateStringType nameField;
        private EntityStateSNMPVersionStringType1 version1Field;
        private EntityStateSNMPSecLevelStringType1 snmpv3_sec_levelField;
        private EntityStateStringType ipv4_aclField;
        private EntityStateStringType ipv6_aclField;
        private EntityStateStringType read_viewField;
        private EntityStateStringType write_viewField;
        private EntityStateStringType notify_viewField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
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
        public EntityStateStringType read_view {
            get {
                return this.read_viewField;
            }
            set {
                this.read_viewField = value;
            }
        }
        public EntityStateStringType write_view {
            get {
                return this.write_viewField;
            }
            set {
                this.write_viewField = value;
            }
        }
        public EntityStateStringType notify_view {
            get {
                return this.notify_viewField;
            }
            set {
                this.notify_viewField = value;
            }
        }
    }

}

