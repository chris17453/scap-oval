using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa", IsNullable=false)]
    public class snmp_host_item : ItemType {
        private EntityItemStringType interfaceField;
        private EntityItemStringType hostField;
        private EntityItemStringType snmpv3_userField;
        private EntityItemSNMPVersionStringType2 versionField;
        private EntityItemBoolType pollField;
        private EntityItemBoolType trapsField;
        private EntityItemIntType udp_portField;
        public EntityItemStringType @interface {
            get {
                return this.interfaceField;
            }
            set {
                this.interfaceField = value;
            }
        }
        public EntityItemStringType host {
            get {
                return this.hostField;
            }
            set {
                this.hostField = value;
            }
        }
        public EntityItemStringType snmpv3_user {
            get {
                return this.snmpv3_userField;
            }
            set {
                this.snmpv3_userField = value;
            }
        }
        public EntityItemSNMPVersionStringType2 version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        public EntityItemBoolType poll {
            get {
                return this.pollField;
            }
            set {
                this.pollField = value;
            }
        }
        public EntityItemBoolType traps {
            get {
                return this.trapsField;
            }
            set {
                this.trapsField = value;
            }
        }
        public EntityItemIntType udp_port {
            get {
                return this.udp_portField;
            }
            set {
                this.udp_portField = value;
            }
        }
    }

}

