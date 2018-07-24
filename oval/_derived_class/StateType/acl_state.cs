using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class acl_state : StateType {
        private EntityStateStringType nameField;
        private EntityStateAccessListIPVersionType ip_versionField;
        private EntityStateAccessListUseType useField;
        private EntityStateStringType used_inField;
        private EntityStateAccessListInterfaceDirectionType interface_directionField;
        private EntityStateStringType acl_config_linesField;
        private EntityStateStringType config_lineField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateAccessListIPVersionType ip_version {
            get {
                return this.ip_versionField;
            }
            set {
                this.ip_versionField = value;
            }
        }
        public EntityStateAccessListUseType use {
            get {
                return this.useField;
            }
            set {
                this.useField = value;
            }
        }
        public EntityStateStringType used_in {
            get {
                return this.used_inField;
            }
            set {
                this.used_inField = value;
            }
        }
        public EntityStateAccessListInterfaceDirectionType interface_direction {
            get {
                return this.interface_directionField;
            }
            set {
                this.interface_directionField = value;
            }
        }
        public EntityStateStringType acl_config_lines {
            get {
                return this.acl_config_linesField;
            }
            set {
                this.acl_config_linesField = value;
            }
        }
        public EntityStateStringType config_line {
            get {
                return this.config_lineField;
            }
            set {
                this.config_lineField = value;
            }
        }
    }

}

