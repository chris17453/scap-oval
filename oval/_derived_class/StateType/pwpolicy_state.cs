using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class pwpolicy_state : StateType {
        private EntityStateStringType usernameField;
        private EntityStateStringType userpassField;
        private EntityStateStringType directory_nodeField;
        private EntityStateIntType maxCharsField;
        private EntityStateIntType maxFailedLoginAttemptsField;
        private EntityStateIntType minCharsField;
        private EntityStateBoolType passwordCannotBeNameField;
        private EntityStateBoolType requiresAlphaField;
        private EntityStateBoolType requiresNumericField;
        public EntityStateStringType username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        public EntityStateStringType userpass {
            get {
                return this.userpassField;
            }
            set {
                this.userpassField = value;
            }
        }
        public EntityStateStringType directory_node {
            get {
                return this.directory_nodeField;
            }
            set {
                this.directory_nodeField = value;
            }
        }
        public EntityStateIntType maxChars {
            get {
                return this.maxCharsField;
            }
            set {
                this.maxCharsField = value;
            }
        }
        public EntityStateIntType maxFailedLoginAttempts {
            get {
                return this.maxFailedLoginAttemptsField;
            }
            set {
                this.maxFailedLoginAttemptsField = value;
            }
        }
        public EntityStateIntType minChars {
            get {
                return this.minCharsField;
            }
            set {
                this.minCharsField = value;
            }
        }
        public EntityStateBoolType passwordCannotBeName {
            get {
                return this.passwordCannotBeNameField;
            }
            set {
                this.passwordCannotBeNameField = value;
            }
        }
        public EntityStateBoolType requiresAlpha {
            get {
                return this.requiresAlphaField;
            }
            set {
                this.requiresAlphaField = value;
            }
        }
        public EntityStateBoolType requiresNumeric {
            get {
                return this.requiresNumericField;
            }
            set {
                this.requiresNumericField = value;
            }
        }
    }

}

