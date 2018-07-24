using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class fileauditedpermissions_item : ItemType {
        private EntityItemStringType filepathField;
        private EntityItemStringType pathField;
        private EntityItemStringType filenameField;
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
        private EntityItemAuditType file_read_dataField;
        private EntityItemAuditType file_write_dataField;
        private EntityItemAuditType file_append_dataField;
        private EntityItemAuditType file_read_eaField;
        private EntityItemAuditType file_write_eaField;
        private EntityItemAuditType file_executeField;
        private EntityItemAuditType file_delete_childField;
        private EntityItemAuditType file_read_attributesField;
        private EntityItemAuditType file_write_attributesField;
        private EntityItemWindowsViewType1 windows_viewField;
        public EntityItemStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
            }
        }
        public EntityItemStringType path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType filename {
            get {
                return this.filenameField;
            }
            set {
                this.filenameField = value;
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
        public EntityItemAuditType file_read_data {
            get {
                return this.file_read_dataField;
            }
            set {
                this.file_read_dataField = value;
            }
        }
        public EntityItemAuditType file_write_data {
            get {
                return this.file_write_dataField;
            }
            set {
                this.file_write_dataField = value;
            }
        }
        public EntityItemAuditType file_append_data {
            get {
                return this.file_append_dataField;
            }
            set {
                this.file_append_dataField = value;
            }
        }
        public EntityItemAuditType file_read_ea {
            get {
                return this.file_read_eaField;
            }
            set {
                this.file_read_eaField = value;
            }
        }
        public EntityItemAuditType file_write_ea {
            get {
                return this.file_write_eaField;
            }
            set {
                this.file_write_eaField = value;
            }
        }
        public EntityItemAuditType file_execute {
            get {
                return this.file_executeField;
            }
            set {
                this.file_executeField = value;
            }
        }
        public EntityItemAuditType file_delete_child {
            get {
                return this.file_delete_childField;
            }
            set {
                this.file_delete_childField = value;
            }
        }
        public EntityItemAuditType file_read_attributes {
            get {
                return this.file_read_attributesField;
            }
            set {
                this.file_read_attributesField = value;
            }
        }
        public EntityItemAuditType file_write_attributes {
            get {
                return this.file_write_attributesField;
            }
            set {
                this.file_write_attributesField = value;
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

