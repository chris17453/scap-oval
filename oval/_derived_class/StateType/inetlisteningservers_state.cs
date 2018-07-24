using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class inetlisteningservers_state : StateType {
        private EntityStateStringType program_nameField;
        private EntityStateIPAddressStringType local_addressField;
        private EntityStateStringType local_full_addressField;
        private EntityStateIntType local_portField;
        private EntityStateIPAddressStringType foreign_addressField;
        private EntityStateStringType foreign_full_addressField;
        private EntityStateStringType foreign_portField;
        private EntityStateIntType pidField;
        private EntityStateStringType protocolField;
        private EntityStateStringType user_idField;
        public EntityStateStringType program_name {
            get {
                return this.program_nameField;
            }
            set {
                this.program_nameField = value;
            }
        }
        public EntityStateIPAddressStringType local_address {
            get {
                return this.local_addressField;
            }
            set {
                this.local_addressField = value;
            }
        }
        public EntityStateStringType local_full_address {
            get {
                return this.local_full_addressField;
            }
            set {
                this.local_full_addressField = value;
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
        public EntityStateIPAddressStringType foreign_address {
            get {
                return this.foreign_addressField;
            }
            set {
                this.foreign_addressField = value;
            }
        }
        public EntityStateStringType foreign_full_address {
            get {
                return this.foreign_full_addressField;
            }
            set {
                this.foreign_full_addressField = value;
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
        public EntityStateIntType pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
            }
        }
        public EntityStateStringType protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        public EntityStateStringType user_id {
            get {
                return this.user_idField;
            }
            set {
                this.user_idField = value;
            }
        }
    }

}

