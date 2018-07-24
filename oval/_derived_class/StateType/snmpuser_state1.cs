using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe")]
    [XmlRootAttribute("snmpuser_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe", IsNullable=false)]
    public class snmpuser_state1 : StateType {
        private EntityStateStringType nameField;
        private EntityStateStringType groupField;
        private EntityStateSNMPVersionStringType1 version1Field;
        private EntityStateStringType ipv4_aclField;
        private EntityStateStringType ipv6_aclField;
        private EntityStateSNMPPrivStringType1 privField;
        private EntityStateSNMPAuthStringType1 authField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateStringType group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
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
        public EntityStateSNMPPrivStringType1 priv {
            get {
                return this.privField;
            }
            set {
                this.privField = value;
            }
        }
        public EntityStateSNMPAuthStringType1 auth {
            get {
                return this.authField;
            }
            set {
                this.authField = value;
            }
        }
    }

}

