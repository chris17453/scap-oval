using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class ntuser_item : ItemType {
        private EntityItemStringType keyField;
        private EntityItemStringType nameField;
        private EntityItemStringType sidField;
        private EntityItemStringType usernameField;
        private EntityItemNTUserAccountTypeType account_typeField;
        private EntityItemBoolType logged_onField;
        private EntityItemBoolType enabledField;
        private EntityItemIntType date_modifiedField;
        private EntityItemIntType days_since_modifiedField;
        private EntityItemStringType filepathField;
        private EntityItemIntType last_write_timeField;
        private EntityItemRegistryTypeType typeField;
        private EntityItemAnySimpleType[] valueField;
        public EntityItemStringType key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemStringType sid {
            get {
                return this.sidField;
            }
            set {
                this.sidField = value;
            }
        }
        public EntityItemStringType username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        public EntityItemNTUserAccountTypeType account_type {
            get {
                return this.account_typeField;
            }
            set {
                this.account_typeField = value;
            }
        }
        public EntityItemBoolType logged_on {
            get {
                return this.logged_onField;
            }
            set {
                this.logged_onField = value;
            }
        }
        public EntityItemBoolType enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        public EntityItemIntType date_modified {
            get {
                return this.date_modifiedField;
            }
            set {
                this.date_modifiedField = value;
            }
        }
        public EntityItemIntType days_since_modified {
            get {
                return this.days_since_modifiedField;
            }
            set {
                this.days_since_modifiedField = value;
            }
        }
        public EntityItemStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
            }
        }
        public EntityItemIntType last_write_time {
            get {
                return this.last_write_timeField;
            }
            set {
                this.last_write_timeField = value;
            }
        }
        public EntityItemRegistryTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        [XmlElementAttribute("value")]
        public EntityItemAnySimpleType[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

