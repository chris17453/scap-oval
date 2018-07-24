using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class pwpolicy59_state : StateType {
        private EntityStateStringType target_userField;
        private EntityStateStringType usernameField;
        private EntityStateStringType userpassField;
        private EntityStateStringType directory_nodeField;
        private EntityStateIntType maxCharsField;
        private EntityStateIntType maxFailedLoginAttemptsField;
        private EntityStateIntType minCharsField;
        private EntityStateBoolType passwordCannotBeNameField;
        private EntityStateBoolType requiresAlphaField;
        private EntityStateBoolType requiresNumericField;
        private EntityStateIntType maxMinutesUntilChangePasswordField;
        private EntityStateIntType minMinutesUntilChangePasswordField;
        private EntityStateBoolType requiresMixedCaseField;
        private EntityStateBoolType requiresSymbolField;
        private EntityStateIntType minutesUntilFailedLoginResetField;
        private EntityStateIntType usingHistoryField;
        private EntityStateBoolType canModifyPasswordforSelfField;
        private EntityStateBoolType usingExpirationDateField;
        private EntityStateBoolType usingHardExpirationDateField;
        private EntityStateStringType expirationDateGMTField;
        private EntityStateStringType hardExpireDateGMTField;
        private EntityStateIntType maxMinutesUntilDisabledField;
        private EntityStateIntType maxMinutesOfNonUseField;
        private EntityStateBoolType newPasswordRequiredField;
        private EntityStateBoolType notGuessablePatternField;
        public EntityStateStringType target_user {
            get {
                return this.target_userField;
            }
            set {
                this.target_userField = value;
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
        public EntityStateIntType maxMinutesUntilChangePassword {
            get {
                return this.maxMinutesUntilChangePasswordField;
            }
            set {
                this.maxMinutesUntilChangePasswordField = value;
            }
        }
        public EntityStateIntType minMinutesUntilChangePassword {
            get {
                return this.minMinutesUntilChangePasswordField;
            }
            set {
                this.minMinutesUntilChangePasswordField = value;
            }
        }
        public EntityStateBoolType requiresMixedCase {
            get {
                return this.requiresMixedCaseField;
            }
            set {
                this.requiresMixedCaseField = value;
            }
        }
        public EntityStateBoolType requiresSymbol {
            get {
                return this.requiresSymbolField;
            }
            set {
                this.requiresSymbolField = value;
            }
        }
        public EntityStateIntType minutesUntilFailedLoginReset {
            get {
                return this.minutesUntilFailedLoginResetField;
            }
            set {
                this.minutesUntilFailedLoginResetField = value;
            }
        }
        public EntityStateIntType usingHistory {
            get {
                return this.usingHistoryField;
            }
            set {
                this.usingHistoryField = value;
            }
        }
        public EntityStateBoolType canModifyPasswordforSelf {
            get {
                return this.canModifyPasswordforSelfField;
            }
            set {
                this.canModifyPasswordforSelfField = value;
            }
        }
        public EntityStateBoolType usingExpirationDate {
            get {
                return this.usingExpirationDateField;
            }
            set {
                this.usingExpirationDateField = value;
            }
        }
        public EntityStateBoolType usingHardExpirationDate {
            get {
                return this.usingHardExpirationDateField;
            }
            set {
                this.usingHardExpirationDateField = value;
            }
        }
        public EntityStateStringType expirationDateGMT {
            get {
                return this.expirationDateGMTField;
            }
            set {
                this.expirationDateGMTField = value;
            }
        }
        public EntityStateStringType hardExpireDateGMT {
            get {
                return this.hardExpireDateGMTField;
            }
            set {
                this.hardExpireDateGMTField = value;
            }
        }
        public EntityStateIntType maxMinutesUntilDisabled {
            get {
                return this.maxMinutesUntilDisabledField;
            }
            set {
                this.maxMinutesUntilDisabledField = value;
            }
        }
        public EntityStateIntType maxMinutesOfNonUse {
            get {
                return this.maxMinutesOfNonUseField;
            }
            set {
                this.maxMinutesOfNonUseField = value;
            }
        }
        public EntityStateBoolType newPasswordRequired {
            get {
                return this.newPasswordRequiredField;
            }
            set {
                this.newPasswordRequiredField = value;
            }
        }
        public EntityStateBoolType notGuessablePattern {
            get {
                return this.notGuessablePatternField;
            }
            set {
                this.notGuessablePatternField = value;
            }
        }
    }

}

