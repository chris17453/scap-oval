using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class ntuser_state : StateType {
        private EntityStateStringType keyField;
        private EntityStateStringType nameField;
        private EntityStateStringType sidField;
        private EntityStateStringType usernameField;
        private EntityStateNTUserAccountTypeType account_typeField;
        private EntityStateBoolType logged_onField;
        private EntityStateBoolType enabledField;
        private EntityStateIntType date_modifiedField;
        private EntityStateIntType days_since_modifiedField;
        private EntityStateStringType filepathField;
        private EntityStateIntType last_write_timeField;
        private EntityStateRegistryTypeType typeField;
        private EntityStateAnySimpleType valueField;
        public EntityStateStringType key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateStringType sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        public EntityStateStringType username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        public EntityStateNTUserAccountTypeType account_type {
            get {
                return this.account_typeField;
            }
            set {
                this.account_typeField = value;
            }
        }
        public EntityStateBoolType logged_on {
            get {
                return this.logged_onField;
            }
            set {
                this.logged_onField = value;
            }
        }
        public EntityStateBoolType enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        public EntityStateIntType date_modified {
            get {
                return this.date_modifiedField;
            }
            set {
                this.date_modifiedField = value;
            }
        }
        public EntityStateIntType days_since_modified {
            get {
                return this.days_since_modifiedField;
            }
            set {
                this.days_since_modifiedField = value;
            }
        }
        public EntityStateStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
            }
        }
        public EntityStateIntType last_write_time {
            get {
                return this.last_write_timeField;
            }
            set {
                this.last_write_timeField = value;
            }
        }
        public EntityStateRegistryTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public EntityStateAnySimpleType value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

