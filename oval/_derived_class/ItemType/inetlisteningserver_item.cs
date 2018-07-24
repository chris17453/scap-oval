using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class inetlisteningserver_item : ItemType {
        private EntityItemStringType program_nameField;
        private EntityItemIPAddressStringType local_addressField;
        private EntityItemStringType local_full_addressField;
        private EntityItemIntType local_portField;
        private EntityItemIPAddressStringType foreign_addressField;
        private EntityItemStringType foreign_full_addressField;
        private EntityItemStringType foreign_portField;
        private EntityItemIntType pidField;
        private EntityItemStringType protocolField;
        private EntityItemStringType user_idField;
        public EntityItemStringType program_name {
            get {
                return this.program_nameField;
            }
            set {
                this.program_nameField = value;
            }
        }
        public EntityItemIPAddressStringType local_address {
            get {
                return this.local_addressField;
            }
            set {
                this.local_addressField = value;
            }
        }
        public EntityItemStringType local_full_address {
            get {
                return this.local_full_addressField;
            }
            set {
                this.local_full_addressField = value;
            }
        }
        public EntityItemIntType local_port {
            get {
                return this.local_portField;
            }
            set {
                this.local_portField = value;
            }
        }
        public EntityItemIPAddressStringType foreign_address {
            get {
                return this.foreign_addressField;
            }
            set {
                this.foreign_addressField = value;
            }
        }
        public EntityItemStringType foreign_full_address {
            get {
                return this.foreign_full_addressField;
            }
            set {
                this.foreign_full_addressField = value;
            }
        }
        public EntityItemStringType foreign_port {
            get {
                return this.foreign_portField;
            }
            set {
                this.foreign_portField = value;
            }
        }
        public EntityItemIntType pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
            }
        }
        public EntityItemStringType protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        public EntityItemStringType user_id {
            get {
                return this.user_idField;
            }
            set {
                this.user_idField = value;
            }
        }
    }

}

