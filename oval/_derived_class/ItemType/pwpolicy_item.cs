using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class pwpolicy_item : ItemType {
        private EntityItemStringType usernameField;
        private EntityItemStringType userpassField;
        private EntityItemStringType directory_nodeField;
        private EntityItemIntType maxCharsField;
        private EntityItemIntType maxFailedLoginAttemptsField;
        private EntityItemIntType minCharsField;
        private EntityItemBoolType passwordCannotBeNameField;
        private EntityItemBoolType requiresAlphaField;
        private EntityItemBoolType requiresNumericField;
        public EntityItemStringType username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        public EntityItemStringType userpass {
            get {
                return this.userpassField;
            }
            set {
                this.userpassField = value;
            }
        }
        public EntityItemStringType directory_node {
            get {
                return this.directory_nodeField;
            }
            set {
                this.directory_nodeField = value;
            }
        }
        public EntityItemIntType maxChars {
            get {
                return this.maxCharsField;
            }
            set {
                this.maxCharsField = value;
            }
        }
        public EntityItemIntType maxFailedLoginAttempts {
            get {
                return this.maxFailedLoginAttemptsField;
            }
            set {
                this.maxFailedLoginAttemptsField = value;
            }
        }
        public EntityItemIntType minChars {
            get {
                return this.minCharsField;
            }
            set {
                this.minCharsField = value;
            }
        }
        public EntityItemBoolType passwordCannotBeName {
            get {
                return this.passwordCannotBeNameField;
            }
            set {
                this.passwordCannotBeNameField = value;
            }
        }
        public EntityItemBoolType requiresAlpha {
            get {
                return this.requiresAlphaField;
            }
            set {
                this.requiresAlphaField = value;
            }
        }
        public EntityItemBoolType requiresNumeric {
            get {
                return this.requiresNumericField;
            }
            set {
                this.requiresNumericField = value;
            }
        }
    }

}

