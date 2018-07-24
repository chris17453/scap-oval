using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class printereffectiverights_item : ItemType {
        private EntityItemStringType printer_nameField;
        private EntityItemStringType trustee_sidField;
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
        private EntityItemBoolType printer_access_administerField;
        private EntityItemBoolType printer_access_useField;
        private EntityItemBoolType job_access_administerField;
        private EntityItemBoolType job_access_readField;
        public EntityItemStringType printer_name {
            get {
                return this.printer_nameField;
            }
            set {
                this.printer_nameField = value;
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
        public EntityItemBoolType printer_access_administer {
            get {
                return this.printer_access_administerField;
            }
            set {
                this.printer_access_administerField = value;
            }
        }
        public EntityItemBoolType printer_access_use {
            get {
                return this.printer_access_useField;
            }
            set {
                this.printer_access_useField = value;
            }
        }
        public EntityItemBoolType job_access_administer {
            get {
                return this.job_access_administerField;
            }
            set {
                this.job_access_administerField = value;
            }
        }
        public EntityItemBoolType job_access_read {
            get {
                return this.job_access_readField;
            }
            set {
                this.job_access_readField = value;
            }
        }
    }

}

