using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class fileeffectiverights_item : ItemType {
        private EntityItemStringType filepathField;
        private EntityItemStringType pathField;
        private EntityItemStringType filenameField;
        private EntityItemStringType trustee_sidField;
        private EntityItemStringType trustee_nameField;
        private EntityItemBoolType standard_deleteField;
        private EntityItemBoolType standard_read_controlField;
        private EntityItemBoolType standard_write_dacField;
        private EntityItemBoolType standard_write_ownerField;
        private EntityItemBoolType standard_synchronizeField;
        private EntityItemBoolType access_system_securityField;
        private EntityItemBoolType generic_readField;
        private EntityItemBoolType generic_writeField;
        private EntityItemBoolType generic_executeField;
        private EntityItemBoolType generic_allField;
        private EntityItemBoolType file_read_dataField;
        private EntityItemBoolType file_write_dataField;
        private EntityItemBoolType file_append_dataField;
        private EntityItemBoolType file_read_eaField;
        private EntityItemBoolType file_write_eaField;
        private EntityItemBoolType file_executeField;
        private EntityItemBoolType file_delete_childField;
        private EntityItemBoolType file_read_attributesField;
        private EntityItemBoolType file_write_attributesField;
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
        public EntityItemBoolType standard_delete {
            get {
                return this.standard_deleteField;
            }
            set {
                this.standard_deleteField = value;
            }
        }
        public EntityItemBoolType standard_read_control {
            get {
                return this.standard_read_controlField;
            }
            set {
                this.standard_read_controlField = value;
            }
        }
        public EntityItemBoolType standard_write_dac {
            get {
                return this.standard_write_dacField;
            }
            set {
                this.standard_write_dacField = value;
            }
        }
        public EntityItemBoolType standard_write_owner {
            get {
                return this.standard_write_ownerField;
            }
            set {
                this.standard_write_ownerField = value;
            }
        }
        public EntityItemBoolType standard_synchronize {
            get {
                return this.standard_synchronizeField;
            }
            set {
                this.standard_synchronizeField = value;
            }
        }
        public EntityItemBoolType access_system_security {
            get {
                return this.access_system_securityField;
            }
            set {
                this.access_system_securityField = value;
            }
        }
        public EntityItemBoolType generic_read {
            get {
                return this.generic_readField;
            }
            set {
                this.generic_readField = value;
            }
        }
        public EntityItemBoolType generic_write {
            get {
                return this.generic_writeField;
            }
            set {
                this.generic_writeField = value;
            }
        }
        public EntityItemBoolType generic_execute {
            get {
                return this.generic_executeField;
            }
            set {
                this.generic_executeField = value;
            }
        }
        public EntityItemBoolType generic_all {
            get {
                return this.generic_allField;
            }
            set {
                this.generic_allField = value;
            }
        }
        public EntityItemBoolType file_read_data {
            get {
                return this.file_read_dataField;
            }
            set {
                this.file_read_dataField = value;
            }
        }
        public EntityItemBoolType file_write_data {
            get {
                return this.file_write_dataField;
            }
            set {
                this.file_write_dataField = value;
            }
        }
        public EntityItemBoolType file_append_data {
            get {
                return this.file_append_dataField;
            }
            set {
                this.file_append_dataField = value;
            }
        }
        public EntityItemBoolType file_read_ea {
            get {
                return this.file_read_eaField;
            }
            set {
                this.file_read_eaField = value;
            }
        }
        public EntityItemBoolType file_write_ea {
            get {
                return this.file_write_eaField;
            }
            set {
                this.file_write_eaField = value;
            }
        }
        public EntityItemBoolType file_execute {
            get {
                return this.file_executeField;
            }
            set {
                this.file_executeField = value;
            }
        }
        public EntityItemBoolType file_delete_child {
            get {
                return this.file_delete_childField;
            }
            set {
                this.file_delete_childField = value;
            }
        }
        public EntityItemBoolType file_read_attributes {
            get {
                return this.file_read_attributesField;
            }
            set {
                this.file_read_attributesField = value;
            }
        }
        public EntityItemBoolType file_write_attributes {
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

