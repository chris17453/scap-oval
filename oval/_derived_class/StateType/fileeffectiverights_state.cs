using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class fileeffectiverights_state : StateType {
        private EntityStateStringType pathField;
        private EntityStateStringType filenameField;
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
        private EntityStateBoolType file_read_dataField;
        private EntityStateBoolType file_write_dataField;
        private EntityStateBoolType file_append_dataField;
        private EntityStateBoolType file_read_eaField;
        private EntityStateBoolType file_write_eaField;
        private EntityStateBoolType file_executeField;
        private EntityStateBoolType file_delete_childField;
        private EntityStateBoolType file_read_attributesField;
        private EntityStateBoolType file_write_attributesField;
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
        public EntityStateBoolType file_read_data {
            get {
                return this.file_read_dataField;
            }
            set {
                this.file_read_dataField = value;
            }
        }
        public EntityStateBoolType file_write_data {
            get {
                return this.file_write_dataField;
            }
            set {
                this.file_write_dataField = value;
            }
        }
        public EntityStateBoolType file_append_data {
            get {
                return this.file_append_dataField;
            }
            set {
                this.file_append_dataField = value;
            }
        }
        public EntityStateBoolType file_read_ea {
            get {
                return this.file_read_eaField;
            }
            set {
                this.file_read_eaField = value;
            }
        }
        public EntityStateBoolType file_write_ea {
            get {
                return this.file_write_eaField;
            }
            set {
                this.file_write_eaField = value;
            }
        }
        public EntityStateBoolType file_execute {
            get {
                return this.file_executeField;
            }
            set {
                this.file_executeField = value;
            }
        }
        public EntityStateBoolType file_delete_child {
            get {
                return this.file_delete_childField;
            }
            set {
                this.file_delete_childField = value;
            }
        }
        public EntityStateBoolType file_read_attributes {
            get {
                return this.file_read_attributesField;
            }
            set {
                this.file_read_attributesField = value;
            }
        }
        public EntityStateBoolType file_write_attributes {
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

