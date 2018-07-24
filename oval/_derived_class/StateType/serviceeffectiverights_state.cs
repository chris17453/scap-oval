using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class serviceeffectiverights_state : StateType {
        private EntityStateStringType service_nameField;
        private EntityStateStringType trustee_sidField;
        private EntityStateBoolType standard_deleteField;
        private EntityStateBoolType standard_read_controlField;
        private EntityStateBoolType standard_write_dacField;
        private EntityStateBoolType standard_write_ownerField;
        private EntityStateBoolType generic_readField;
        private EntityStateBoolType generic_writeField;
        private EntityStateBoolType generic_executeField;
        private EntityStateBoolType service_query_confField;
        private EntityStateBoolType service_change_confField;
        private EntityStateBoolType service_query_statField;
        private EntityStateBoolType service_enum_dependentsField;
        private EntityStateBoolType service_startField;
        private EntityStateBoolType service_stopField;
        private EntityStateBoolType service_pauseField;
        private EntityStateBoolType service_interrogateField;
        private EntityStateBoolType service_user_definedField;
        public EntityStateStringType service_name {
            get {
                return this.service_nameField;
            }
            set {
                this.service_nameField = value;
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
        public EntityStateBoolType service_query_conf {
            get {
                return this.service_query_confField;
            }
            set {
                this.service_query_confField = value;
            }
        }
        public EntityStateBoolType service_change_conf {
            get {
                return this.service_change_confField;
            }
            set {
                this.service_change_confField = value;
            }
        }
        public EntityStateBoolType service_query_stat {
            get {
                return this.service_query_statField;
            }
            set {
                this.service_query_statField = value;
            }
        }
        public EntityStateBoolType service_enum_dependents {
            get {
                return this.service_enum_dependentsField;
            }
            set {
                this.service_enum_dependentsField = value;
            }
        }
        public EntityStateBoolType service_start {
            get {
                return this.service_startField;
            }
            set {
                this.service_startField = value;
            }
        }
        public EntityStateBoolType service_stop {
            get {
                return this.service_stopField;
            }
            set {
                this.service_stopField = value;
            }
        }
        public EntityStateBoolType service_pause {
            get {
                return this.service_pauseField;
            }
            set {
                this.service_pauseField = value;
            }
        }
        public EntityStateBoolType service_interrogate {
            get {
                return this.service_interrogateField;
            }
            set {
                this.service_interrogateField = value;
            }
        }
        public EntityStateBoolType service_user_defined {
            get {
                return this.service_user_definedField;
            }
            set {
                this.service_user_definedField = value;
            }
        }
    }

}

