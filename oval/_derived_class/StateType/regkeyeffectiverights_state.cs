using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class regkeyeffectiverights_state : StateType {
        private EntityStateRegistryHiveType hiveField;
        private EntityStateStringType keyField;
        private EntityStateStringType trustee_nameField;
        private EntityStateBoolType standard_deleteField;
        private EntityStateBoolType standard_read_controlField;
        private EntityStateBoolType standard_write_dacField;
        private EntityStateBoolType standard_write_ownerField;
        private EntityStateBoolType standard_synchronizeField;
        private EntityStateBoolType access_system_securityField;
        private EntityStateBoolType generic_readField;
        private EntityStateBoolType generic_writeField;
        private EntityStateBoolType generic_executeField;
        private EntityStateBoolType generic_allField;
        private EntityStateBoolType key_query_valueField;
        private EntityStateBoolType key_set_valueField;
        private EntityStateBoolType key_create_sub_keyField;
        private EntityStateBoolType key_enumerate_sub_keysField;
        private EntityStateBoolType key_notifyField;
        private EntityStateBoolType key_create_linkField;
        private EntityStateBoolType key_wow64_64keyField;
        private EntityStateBoolType key_wow64_32keyField;
        private EntityStateBoolType key_wow64_resField;
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
        public EntityStateBoolType standard_delete {
            get {
                return this.standard_deleteField;
            }
            set {
                this.standard_deleteField = value;
            }
        }
        public EntityStateBoolType standard_read_control {
            get {
                return this.standard_read_controlField;
            }
            set {
                this.standard_read_controlField = value;
            }
        }
        public EntityStateBoolType standard_write_dac {
            get {
                return this.standard_write_dacField;
            }
            set {
                this.standard_write_dacField = value;
            }
        }
        public EntityStateBoolType standard_write_owner {
            get {
                return this.standard_write_ownerField;
            }
            set {
                this.standard_write_ownerField = value;
            }
        }
        public EntityStateBoolType standard_synchronize {
            get {
                return this.standard_synchronizeField;
            }
            set {
                this.standard_synchronizeField = value;
            }
        }
        public EntityStateBoolType access_system_security {
            get {
                return this.access_system_securityField;
            }
            set {
                this.access_system_securityField = value;
            }
        }
        public EntityStateBoolType generic_read {
            get {
                return this.generic_readField;
            }
            set {
                this.generic_readField = value;
            }
        }
        public EntityStateBoolType generic_write {
            get {
                return this.generic_writeField;
            }
            set {
                this.generic_writeField = value;
            }
        }
        public EntityStateBoolType generic_execute {
            get {
                return this.generic_executeField;
            }
            set {
                this.generic_executeField = value;
            }
        }
        public EntityStateBoolType generic_all {
            get {
                return this.generic_allField;
            }
            set {
                this.generic_allField = value;
            }
        }
        public EntityStateBoolType key_query_value {
            get {
                return this.key_query_valueField;
            }
            set {
                this.key_query_valueField = value;
            }
        }
        public EntityStateBoolType key_set_value {
            get {
                return this.key_set_valueField;
            }
            set {
                this.key_set_valueField = value;
            }
        }
        public EntityStateBoolType key_create_sub_key {
            get {
                return this.key_create_sub_keyField;
            }
            set {
                this.key_create_sub_keyField = value;
            }
        }
        public EntityStateBoolType key_enumerate_sub_keys {
            get {
                return this.key_enumerate_sub_keysField;
            }
            set {
                this.key_enumerate_sub_keysField = value;
            }
        }
        public EntityStateBoolType key_notify {
            get {
                return this.key_notifyField;
            }
            set {
                this.key_notifyField = value;
            }
        }
        public EntityStateBoolType key_create_link {
            get {
                return this.key_create_linkField;
            }
            set {
                this.key_create_linkField = value;
            }
        }
        public EntityStateBoolType key_wow64_64key {
            get {
                return this.key_wow64_64keyField;
            }
            set {
                this.key_wow64_64keyField = value;
            }
        }
        public EntityStateBoolType key_wow64_32key {
            get {
                return this.key_wow64_32keyField;
            }
            set {
                this.key_wow64_32keyField = value;
            }
        }
        public EntityStateBoolType key_wow64_res {
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

