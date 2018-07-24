using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class regkeyauditedpermissions_item : ItemType {
        private EntityItemRegistryHiveType hiveField;
        private EntityItemStringType keyField;
        private EntityItemStringType trustee_sidField;
        private EntityItemStringType trustee_nameField;
        private EntityItemAuditType standard_deleteField;
        private EntityItemAuditType standard_read_controlField;
        private EntityItemAuditType standard_write_dacField;
        private EntityItemAuditType standard_write_ownerField;
        private EntityItemAuditType standard_synchronizeField;
        private EntityItemAuditType access_system_securityField;
        private EntityItemAuditType generic_readField;
        private EntityItemAuditType generic_writeField;
        private EntityItemAuditType generic_executeField;
        private EntityItemAuditType generic_allField;
        private EntityItemAuditType key_query_valueField;
        private EntityItemAuditType key_set_valueField;
        private EntityItemAuditType key_create_sub_keyField;
        private EntityItemAuditType key_enumerate_sub_keysField;
        private EntityItemAuditType key_notifyField;
        private EntityItemAuditType key_create_linkField;
        private EntityItemAuditType key_wow64_64keyField;
        private EntityItemAuditType key_wow64_32keyField;
        private EntityItemAuditType key_wow64_resField;
        private EntityItemWindowsViewType1 windows_viewField;
        public EntityItemRegistryHiveType hive {
            get {
                return this.hiveField;
            }
            set {
                this.hiveField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        public EntityItemStringType trustee_sid {
            get {
                return this.trustee_sidField;
            }
            set {
                this.trustee_sidField = value;
            }
        }
        public EntityItemStringType trustee_name {
            get {
                return this.trustee_nameField;
            }
            set {
                this.trustee_nameField = value;
            }
        }
        public EntityItemAuditType standard_delete {
            get {
                return this.standard_deleteField;
            }
            set {
                this.standard_deleteField = value;
            }
        }
        public EntityItemAuditType standard_read_control {
            get {
                return this.standard_read_controlField;
            }
            set {
                this.standard_read_controlField = value;
            }
        }
        public EntityItemAuditType standard_write_dac {
            get {
                return this.standard_write_dacField;
            }
            set {
                this.standard_write_dacField = value;
            }
        }
        public EntityItemAuditType standard_write_owner {
            get {
                return this.standard_write_ownerField;
            }
            set {
                this.standard_write_ownerField = value;
            }
        }
        public EntityItemAuditType standard_synchronize {
            get {
                return this.standard_synchronizeField;
            }
            set {
                this.standard_synchronizeField = value;
            }
        }
        public EntityItemAuditType access_system_security {
            get {
                return this.access_system_securityField;
            }
            set {
                this.access_system_securityField = value;
            }
        }
        public EntityItemAuditType generic_read {
            get {
                return this.generic_readField;
            }
            set {
                this.generic_readField = value;
            }
        }
        public EntityItemAuditType generic_write {
            get {
                return this.generic_writeField;
            }
            set {
                this.generic_writeField = value;
            }
        }
        public EntityItemAuditType generic_execute {
            get {
                return this.generic_executeField;
            }
            set {
                this.generic_executeField = value;
            }
        }
        public EntityItemAuditType generic_all {
            get {
                return this.generic_allField;
            }
            set {
                this.generic_allField = value;
            }
        }
        public EntityItemAuditType key_query_value {
            get {
                return this.key_query_valueField;
            }
            set {
                this.key_query_valueField = value;
            }
        }
        public EntityItemAuditType key_set_value {
            get {
                return this.key_set_valueField;
            }
            set {
                this.key_set_valueField = value;
            }
        }
        public EntityItemAuditType key_create_sub_key {
            get {
                return this.key_create_sub_keyField;
            }
            set {
                this.key_create_sub_keyField = value;
            }
        }
        public EntityItemAuditType key_enumerate_sub_keys {
            get {
                return this.key_enumerate_sub_keysField;
            }
            set {
                this.key_enumerate_sub_keysField = value;
            }
        }
        public EntityItemAuditType key_notify {
            get {
                return this.key_notifyField;
            }
            set {
                this.key_notifyField = value;
            }
        }
        public EntityItemAuditType key_create_link {
            get {
                return this.key_create_linkField;
            }
            set {
                this.key_create_linkField = value;
            }
        }
        public EntityItemAuditType key_wow64_64key {
            get {
                return this.key_wow64_64keyField;
            }
            set {
                this.key_wow64_64keyField = value;
            }
        }
        public EntityItemAuditType key_wow64_32key {
            get {
                return this.key_wow64_32keyField;
            }
            set {
                this.key_wow64_32keyField = value;
            }
        }
        public EntityItemAuditType key_wow64_res {
            get {
                return this.key_wow64_resField;
            }
            set {
                this.key_wow64_resField = value;
            }
        }
        public EntityItemWindowsViewType1 windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

