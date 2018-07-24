using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios", IsNullable=false)]
    public class snmpuser_item : ItemType {
        private EntityItemStringType nameField;
        private EntityItemStringType groupField;
        private EntityItemSNMPVersionStringType versionField;
        private EntityItemStringType ipv4_aclField;
        private EntityItemStringType ipv6_aclField;
        private EntityItemSNMPPrivStringType privField;
        private EntityItemSNMPAuthStringType authField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemStringType group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
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
        public EntityItemSNMPPrivStringType priv {
            get {
                return this.privField;
            }
            set {
                this.privField = value;
            }
        }
        public EntityItemSNMPAuthStringType auth {
            get {
                return this.authField;
            }
            set {
                this.authField = value;
            }
        }
    }

}

