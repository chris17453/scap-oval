using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    [XmlRootAttribute("inetlisteningserver_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux", IsNullable=false)]
    public class inetlisteningserver_item1 : ItemType {
        private EntityItemStringType protocolField;
        private EntityItemIPAddressStringType local_addressField;
        private EntityItemIntType local_portField;
        private EntityItemStringType local_full_addressField;
        private EntityItemStringType program_nameField;
        private EntityItemIPAddressStringType foreign_addressField;
        private EntityItemIntType foreign_portField;
        private EntityItemStringType foreign_full_addressField;
        private EntityItemIntType pidField;
        private EntityItemIntType user_idField;
        public EntityItemStringType protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
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
        public EntityItemIntType local_port {
            get {
                return this.local_portField;
            }
            set {
                this.local_portField = value;
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
        public EntityItemStringType program_name {
            get {
                return this.program_nameField;
            }
            set {
                this.program_nameField = value;
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
        public EntityItemIntType foreign_port {
            get {
                return this.foreign_portField;
            }
            set {
                this.foreign_portField = value;
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
        public EntityItemIntType pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
            }
        }
        public EntityItemIntType user_id {
            get {
                return this.user_idField;
            }
            set {
                this.user_idField = value;
            }
        }
    }

}

