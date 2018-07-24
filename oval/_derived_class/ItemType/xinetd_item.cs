using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class xinetd_item : ItemType {
        private EntityItemStringType protocolField;
        private EntityItemStringType service_nameField;
        private EntityItemStringType[] flagsField;
        private EntityItemStringType[] no_accessField;
        private EntityItemIPAddressStringType[] only_fromField;
        private EntityItemIntType portField;
        private EntityItemStringType serverField;
        private EntityItemStringType server_argumentsField;
        private EntityItemStringType socket_typeField;
        private EntityItemXinetdTypeStatusType[] typeField;
        private EntityItemStringType userField;
        private EntityItemBoolType waitField;
        private EntityItemBoolType disabledField;
        public EntityItemStringType protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        public EntityItemStringType service_name {
            get {
                return this.service_nameField;
            }
            set {
                this.service_nameField = value;
            }
        }
        [XmlElementAttribute("flags")]
        public EntityItemStringType[] flags {
            get {
                return this.flagsField;
            }
            set {
                this.flagsField = value;
            }
        }
        [XmlElementAttribute("no_access")]
        public EntityItemStringType[] no_access {
            get {
                return this.no_accessField;
            }
            set {
                this.no_accessField = value;
            }
        }
        [XmlElementAttribute("only_from")]
        public EntityItemIPAddressStringType[] only_from {
            get {
                return this.only_fromField;
            }
            set {
                this.only_fromField = value;
            }
        }
        public EntityItemIntType port {
            get {
                return this.portField;
            }
            set {
                this.portField = value;
            }
        }
        public EntityItemStringType server {
            get {
                return this.serverField;
            }
            set {
                this.serverField = value;
            }
        }
        public EntityItemStringType server_arguments {
            get {
                return this.server_argumentsField;
            }
            set {
                this.server_argumentsField = value;
            }
        }
        public EntityItemStringType socket_type {
            get {
                return this.socket_typeField;
            }
            set {
                this.socket_typeField = value;
            }
        }
        [XmlElementAttribute("type")]
        public EntityItemXinetdTypeStatusType[] type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public EntityItemStringType user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
        public EntityItemBoolType wait {
            get {
                return this.waitField;
            }
            set {
                this.waitField = value;
            }
        }
        public EntityItemBoolType disabled {
            get {
                return this.disabledField;
            }
            set {
                this.disabledField = value;
            }
        }
    }

}

