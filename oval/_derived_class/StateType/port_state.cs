using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class port_state : StateType {
        private EntityStateIPAddressStringType local_addressField;
        private EntityStateIntType local_portField;
        private EntityStateProtocolType protocolField;
        private EntityStateIntType pidField;
        private EntityStateIPAddressStringType foreign_addressField;
        private EntityStateStringType foreign_portField;
        public EntityStateIPAddressStringType local_address {
            get {
                return this.local_addressField;
            }
            set {
                this.local_addressField = value;
            }
        }
        public EntityStateIntType local_port {
            get {
                return this.local_portField;
            }
            set {
                this.local_portField = value;
            }
        }
        public EntityStateProtocolType protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        public EntityStateIntType pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
            }
        }
        public EntityStateIPAddressStringType foreign_address {
            get {
                return this.foreign_addressField;
            }
            set {
                this.foreign_addressField = value;
            }
        }
        public EntityStateStringType foreign_port {
            get {
                return this.foreign_portField;
            }
            set {
                this.foreign_portField = value;
            }
        }
    }

}

