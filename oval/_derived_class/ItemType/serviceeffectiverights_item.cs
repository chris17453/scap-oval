using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class serviceeffectiverights_item : ItemType {
        private EntityItemStringType service_nameField;
        private EntityItemStringType trustee_sidField;
        private EntityItemBoolType standard_deleteField;
        private EntityItemBoolType standard_read_controlField;
        private EntityItemBoolType standard_write_dacField;
        private EntityItemBoolType standard_write_ownerField;
        private EntityItemBoolType generic_readField;
        private EntityItemBoolType generic_writeField;
        private EntityItemBoolType generic_executeField;
        private EntityItemBoolType service_query_confField;
        private EntityItemBoolType service_change_confField;
        private EntityItemBoolType service_query_statField;
        private EntityItemBoolType service_enum_dependentsField;
        private EntityItemBoolType service_startField;
        private EntityItemBoolType service_stopField;
        private EntityItemBoolType service_pauseField;
        private EntityItemBoolType service_interrogateField;
        private EntityItemBoolType service_user_definedField;
        public EntityItemStringType service_name {
            get {
                return this.service_nameField;
            }
            set {
                this.service_nameField = value;
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
        public EntityItemBoolType service_query_conf {
            get {
                return this.service_query_confField;
            }
            set {
                this.service_query_confField = value;
            }
        }
        public EntityItemBoolType service_change_conf {
            get {
                return this.service_change_confField;
            }
            set {
                this.service_change_confField = value;
            }
        }
        public EntityItemBoolType service_query_stat {
            get {
                return this.service_query_statField;
            }
            set {
                this.service_query_statField = value;
            }
        }
        public EntityItemBoolType service_enum_dependents {
            get {
                return this.service_enum_dependentsField;
            }
            set {
                this.service_enum_dependentsField = value;
            }
        }
        public EntityItemBoolType service_start {
            get {
                return this.service_startField;
            }
            set {
                this.service_startField = value;
            }
        }
        public EntityItemBoolType service_stop {
            get {
                return this.service_stopField;
            }
            set {
                this.service_stopField = value;
            }
        }
        public EntityItemBoolType service_pause {
            get {
                return this.service_pauseField;
            }
            set {
                this.service_pauseField = value;
            }
        }
        public EntityItemBoolType service_interrogate {
            get {
                return this.service_interrogateField;
            }
            set {
                this.service_interrogateField = value;
            }
        }
        public EntityItemBoolType service_user_defined {
            get {
                return this.service_user_definedField;
            }
            set {
                this.service_user_definedField = value;
            }
        }
    }

}

