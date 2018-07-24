using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class interface_state : StateType {
        private EntityStateStringType nameField;
        private EntityStateIntType indexField;
        private EntityStateInterfaceTypeType typeField;
        private EntityStateStringType hardware_addrField;
        private EntityStateIPAddressStringType inet_addrField;
        private EntityStateIPAddressStringType broadcast_addrField;
        private EntityStateIPAddressStringType netmaskField;
        private EntityStateAddrTypeType addr_typeField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateIntType index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
            }
        }
        public EntityStateInterfaceTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public EntityStateStringType hardware_addr {
            get {
                return this.hardware_addrField;
            }
            set {
                this.hardware_addrField = value;
            }
        }
        public EntityStateIPAddressStringType inet_addr {
            get {
                return this.inet_addrField;
            }
            set {
                this.inet_addrField = value;
            }
        }
        public EntityStateIPAddressStringType broadcast_addr {
            get {
                return this.broadcast_addrField;
            }
            set {
                this.broadcast_addrField = value;
            }
        }
        public EntityStateIPAddressStringType netmask {
            get {
                return this.netmaskField;
            }
            set {
                this.netmaskField = value;
            }
        }
        public EntityStateAddrTypeType addr_type {
            get {
                return this.addr_typeField;
            }
            set {
                this.addr_typeField = value;
            }
        }
    }

}

