﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class printereffectiverights_state : StateType {
        private EntityStateStringType printer_nameField;
        private EntityStateStringType trustee_sidField;
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
        private EntityStateBoolType printer_access_administerField;
        private EntityStateBoolType printer_access_useField;
        private EntityStateBoolType job_access_administerField;
        private EntityStateBoolType job_access_readField;
        public EntityStateStringType printer_name {
            get {
                return this.printer_nameField;
            }
            set {
                this.printer_nameField = value;
            }
        }
        public EntityStateStringType trustee_sid {
            get {
                return this.trustee_sidField;
            }
            set {
                this.trustee_sidField = value;
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
        public EntityStateBoolType printer_access_administer {
            get {
                return this.printer_access_administerField;
            }
            set {
                this.printer_access_administerField = value;
            }
        }
        public EntityStateBoolType printer_access_use {
            get {
                return this.printer_access_useField;
            }
            set {
                this.printer_access_useField = value;
            }
        }
        public EntityStateBoolType job_access_administer {
            get {
                return this.job_access_administerField;
            }
            set {
                this.job_access_administerField = value;
            }
        }
        public EntityStateBoolType job_access_read {
            get {
                return this.job_access_readField;
            }
            set {
                this.job_access_readField = value;
            }
        }
    }

}

