using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IsNullable=false)]
    public class xinetd_state : StateType {
        private EntityStateStringType protocolField;
        private EntityStateStringType service_nameField;
        private EntityStateStringType flagsField;
        private EntityStateStringType no_accessField;
        private EntityStateIPAddressStringType only_fromField;
        private EntityStateIntType portField;
        private EntityStateStringType serverField;
        private EntityStateStringType server_argumentsField;
        private EntityStateStringType socket_typeField;
        private EntityStateXinetdTypeStatusType typeField;
        private EntityStateStringType userField;
        private EntityStateBoolType waitField;
        private EntityStateBoolType disabledField;
        public EntityStateStringType protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        public EntityStateStringType service_name {
            get {
                return this.service_nameField;
            }
            set {
                this.service_nameField = value;
            }
        }
        public EntityStateStringType flags {
            get {
                return this.flagsField;
            }
            set {
                this.flagsField = value;
            }
        }
        public EntityStateStringType no_access {
            get {
                return this.no_accessField;
            }
            set {
                this.no_accessField = value;
            }
        }
        public EntityStateIPAddressStringType only_from {
            get {
                return this.only_fromField;
            }
            set {
                this.only_fromField = value;
            }
        }
        public EntityStateIntType port {
            get {
                return this.portField;
            }
            set {
                this.portField = value;
            }
        }
        public EntityStateStringType server {
            get {
                return this.serverField;
            }
            set {
                this.serverField = value;
            }
        }
        public EntityStateStringType server_arguments {
            get {
                return this.server_argumentsField;
            }
            set {
                this.server_argumentsField = value;
            }
        }
        public EntityStateStringType socket_type {
            get {
                return this.socket_typeField;
            }
            set {
                this.socket_typeField = value;
            }
        }
        public EntityStateXinetdTypeStatusType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public EntityStateStringType user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
        public EntityStateBoolType wait {
            get {
                return this.waitField;
            }
            set {
                this.waitField = value;
            }
        }
        public EntityStateBoolType disabled {
            get {
                return this.disabledField;
            }
            set {
                this.disabledField = value;
            }
        }
    }

}

