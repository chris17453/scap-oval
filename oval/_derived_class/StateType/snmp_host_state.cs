using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa", IsNullable=false)]
    public class snmp_host_state : StateType {
        private EntityStateStringType interfaceField;
        private EntityStateStringType hostField;
        private EntityStateStringType snmpv3_userField;
        private EntityStateSNMPVersionStringType2 version1Field;
        private EntityStateBoolType pollField;
        private EntityStateBoolType trapsField;
        private EntityStateIntType udp_portField;
        public EntityStateStringType @interface {
            get {
                return this.interfaceField;
            }
            set {
                this.interfaceField = value;
            }
        }
        public EntityStateStringType host {
            get {
                return this.hostField;
            }
            set {
                this.hostField = value;
            }
        }
        public EntityStateStringType snmpv3_user {
            get {
                return this.snmpv3_userField;
            }
            set {
                this.snmpv3_userField = value;
            }
        }
        [XmlElementAttribute("version")]
        public EntityStateSNMPVersionStringType2 version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
        public EntityStateBoolType poll {
            get {
                return this.pollField;
            }
            set {
                this.pollField = value;
            }
        }
        public EntityStateBoolType traps {
            get {
                return this.trapsField;
            }
            set {
                this.trapsField = value;
            }
        }
        public EntityStateIntType udp_port {
            get {
                return this.udp_portField;
            }
            set {
                this.udp_portField = value;
            }
        }
    }

}

