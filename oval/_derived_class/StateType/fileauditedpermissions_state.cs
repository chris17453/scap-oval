using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class fileauditedpermissions_state : StateType {
        private EntityStateStringType pathField;
        private EntityStateStringType filenameField;
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
        private EntityStateAuditType file_read_dataField;
        private EntityStateAuditType file_write_dataField;
        private EntityStateAuditType file_append_dataField;
        private EntityStateAuditType file_read_eaField;
        private EntityStateAuditType file_write_eaField;
        private EntityStateAuditType file_executeField;
        private EntityStateAuditType file_delete_childField;
        private EntityStateAuditType file_read_attributesField;
        private EntityStateAuditType file_write_attributesField;
        private EntityStateWindowsViewType1 windows_viewField;
        public EntityStateStringType path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        public EntityStateStringType filename {
            get {
                return this.filenameField;
            }
            set {
                this.filenameField = value;
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
        public EntityStateAuditType file_read_data {
            get {
                return this.file_read_dataField;
            }
            set {
                this.file_read_dataField = value;
            }
        }
        public EntityStateAuditType file_write_data {
            get {
                return this.file_write_dataField;
            }
            set {
                this.file_write_dataField = value;
            }
        }
        public EntityStateAuditType file_append_data {
            get {
                return this.file_append_dataField;
            }
            set {
                this.file_append_dataField = value;
            }
        }
        public EntityStateAuditType file_read_ea {
            get {
                return this.file_read_eaField;
            }
            set {
                this.file_read_eaField = value;
            }
        }
        public EntityStateAuditType file_write_ea {
            get {
                return this.file_write_eaField;
            }
            set {
                this.file_write_eaField = value;
            }
        }
        public EntityStateAuditType file_execute {
            get {
                return this.file_executeField;
            }
            set {
                this.file_executeField = value;
            }
        }
        public EntityStateAuditType file_delete_child {
            get {
                return this.file_delete_childField;
            }
            set {
                this.file_delete_childField = value;
            }
        }
        public EntityStateAuditType file_read_attributes {
            get {
                return this.file_read_attributesField;
            }
            set {
                this.file_read_attributesField = value;
            }
        }
        public EntityStateAuditType file_write_attributes {
            get {
                return this.file_write_attributesField;
            }
            set {
                this.file_write_attributesField = value;
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

