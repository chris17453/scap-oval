using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class regkeyauditedpermissions_state : StateType {
        private EntityStateRegistryHiveType hiveField;
        private EntityStateStringType keyField;
        private EntityStateStringType trustee_nameField;
        private EntityStateAuditType standard_deleteField;
        private EntityStateAuditType standard_read_controlField;
        private EntityStateAuditType standard_write_dacField;
        private EntityStateAuditType standard_write_ownerField;
        private EntityStateAuditType standard_synchronizeField;
        private EntityStateAuditType access_system_securityField;
        private EntityStateAuditType generic_readField;
        private EntityStateAuditType generic_writeField;
        private EntityStateAuditType generic_executeField;
        private EntityStateAuditType generic_allField;
        private EntityStateAuditType key_query_valueField;
        private EntityStateAuditType key_set_valueField;
        private EntityStateAuditType key_create_sub_keyField;
        private EntityStateAuditType key_enumerate_sub_keysField;
        private EntityStateAuditType key_notifyField;
        private EntityStateAuditType key_create_linkField;
        private EntityStateAuditType key_wow64_64keyField;
        private EntityStateAuditType key_wow64_32keyField;
        private EntityStateAuditType key_wow64_resField;
        private EntityStateWindowsViewType1 windows_viewField;
        public EntityStateRegistryHiveType hive {
            get {
                return this.hiveField;
            }
            set {
                this.hiveField = value;
            }
        }
        public EntityStateStringType key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        public EntityStateStringType trustee_name {
            get {
                return this.trustee_nameField;
            }
            set {
                this.trustee_nameField = value;
            }
        }
        public EntityStateAuditType standard_delete {
            get {
                return this.standard_deleteField;
            }
            set {
                this.standard_deleteField = value;
            }
        }
        public EntityStateAuditType standard_read_control {
            get {
                return this.standard_read_controlField;
            }
            set {
                this.standard_read_controlField = value;
            }
        }
        public EntityStateAuditType standard_write_dac {
            get {
                return this.standard_write_dacField;
            }
            set {
                this.standard_write_dacField = value;
            }
        }
        public EntityStateAuditType standard_write_owner {
            get {
                return this.standard_write_ownerField;
            }
            set {
                this.standard_write_ownerField = value;
            }
        }
        public EntityStateAuditType standard_synchronize {
            get {
                return this.standard_synchronizeField;
            }
            set {
                this.standard_synchronizeField = value;
            }
        }
        public EntityStateAuditType access_system_security {
            get {
                return this.access_system_securityField;
            }
            set {
                this.access_system_securityField = value;
            }
        }
        public EntityStateAuditType generic_read {
            get {
                return this.generic_readField;
            }
            set {
                this.generic_readField = value;
            }
        }
        public EntityStateAuditType generic_write {
            get {
                return this.generic_writeField;
            }
            set {
                this.generic_writeField = value;
            }
        }
        public EntityStateAuditType generic_execute {
            get {
                return this.generic_executeField;
            }
            set {
                this.generic_executeField = value;
            }
        }
        public EntityStateAuditType generic_all {
            get {
                return this.generic_allField;
            }
            set {
                this.generic_allField = value;
            }
        }
        public EntityStateAuditType key_query_value {
            get {
                return this.key_query_valueField;
            }
            set {
                this.key_query_valueField = value;
            }
        }
        public EntityStateAuditType key_set_value {
            get {
                return this.key_set_valueField;
            }
            set {
                this.key_set_valueField = value;
            }
        }
        public EntityStateAuditType key_create_sub_key {
            get {
                return this.key_create_sub_keyField;
            }
            set {
                this.key_create_sub_keyField = value;
            }
        }
        public EntityStateAuditType key_enumerate_sub_keys {
            get {
                return this.key_enumerate_sub_keysField;
            }
            set {
                this.key_enumerate_sub_keysField = value;
            }
        }
        public EntityStateAuditType key_notify {
            get {
                return this.key_notifyField;
            }
            set {
                this.key_notifyField = value;
            }
        }
        public EntityStateAuditType key_create_link {
            get {
                return this.key_create_linkField;
            }
            set {
                this.key_create_linkField = value;
            }
        }
        public EntityStateAuditType key_wow64_64key {
            get {
                return this.key_wow64_64keyField;
            }
            set {
                this.key_wow64_64keyField = value;
            }
        }
        public EntityStateAuditType key_wow64_32key {
            get {
                return this.key_wow64_32keyField;
            }
            set {
                this.key_wow64_32keyField = value;
            }
        }
        public EntityStateAuditType key_wow64_res {
            get {
                return this.key_wow64_resField;
            }
            set {
                this.key_wow64_resField = value;
            }
        }
        public EntityStateWindowsViewType1 windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

