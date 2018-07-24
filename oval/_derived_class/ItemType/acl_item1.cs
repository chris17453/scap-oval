using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe")]
    [XmlRootAttribute("acl_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe", IsNullable=false)]
    public class acl_item1 : ItemType {
        private EntityItemStringType nameField;
        private EntityItemAccessListIPVersionType1 ip_versionField;
        private EntityItemAccessListUseType1 useField;
        private EntityItemStringType used_inField;
        private EntityItemAccessListInterfaceDirectionType1 interface_directionField;
        private EntityItemStringType acl_config_linesField;
        private EntityItemStringType[] config_lineField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemAccessListIPVersionType1 ip_version {
            get {
                return this.ip_versionField;
            }
            set {
                this.ip_versionField = value;
            }
        }
        public EntityItemAccessListUseType1 use {
            get {
                return this.useField;
            }
            set {
                this.useField = value;
            }
        }
        public EntityItemStringType used_in {
            get {
                return this.used_inField;
            }
            set {
                this.used_inField = value;
            }
        }
        public EntityItemAccessListInterfaceDirectionType1 interface_direction {
            get {
                return this.interface_directionField;
            }
            set {
                this.interface_directionField = value;
            }
        }
        public EntityItemStringType acl_config_lines {
            get {
                return this.acl_config_linesField;
            }
            set {
                this.acl_config_linesField = value;
            }
        }
        [XmlElementAttribute("config_line")]
        public EntityItemStringType[] config_line {
            get {
                return this.config_lineField;
            }
            set {
                this.config_lineField = value;
            }
        }
    }

}

