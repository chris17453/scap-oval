using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class pwpolicy59_item : ItemType {
        private EntityItemStringType target_userField;
        private EntityItemStringType usernameField;
        private EntityItemStringType userpassField;
        private EntityItemStringType directory_nodeField;
        private EntityItemIntType maxCharsField;
        private EntityItemIntType maxFailedLoginAttemptsField;
        private EntityItemIntType minCharsField;
        private EntityItemBoolType passwordCannotBeNameField;
        private EntityItemBoolType requiresAlphaField;
        private EntityItemBoolType requiresNumericField;
        private EntityItemIntType maxMinutesUntilChangePasswordField;
        private EntityItemIntType minMinutesUntilChangePasswordField;
        private EntityItemBoolType requiresMixedCaseField;
        private EntityItemBoolType requiresSymbolField;
        private EntityItemIntType minutesUntilFailedLoginResetField;
        private EntityItemIntType usingHistoryField;
        private EntityItemBoolType canModifyPasswordforSelfField;
        private EntityItemBoolType usingExpirationDateField;
        private EntityItemBoolType usingHardExpirationDateField;
        private EntityItemStringType expirationDateGMTField;
        private EntityItemStringType hardExpireDateGMTField;
        private EntityItemIntType maxMinutesUntilDisabledField;
        private EntityItemIntType maxMinutesOfNonUseField;
        private EntityItemBoolType newPasswordRequiredField;
        private EntityItemBoolType notGuessablePatternField;
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType target_user {
            get {
                return this.target_userField;
            }
            set {
                this.target_userField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType userpass {
            get {
                return this.userpassField;
            }
            set {
                this.userpassField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
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
        public EntityItemIntType maxMinutesUntilChangePassword {
            get {
                return this.maxMinutesUntilChangePasswordField;
            }
            set {
                this.maxMinutesUntilChangePasswordField = value;
            }
        }
        public EntityItemIntType minMinutesUntilChangePassword {
            get {
                return this.minMinutesUntilChangePasswordField;
            }
            set {
                this.minMinutesUntilChangePasswordField = value;
            }
        }
        public EntityItemBoolType requiresMixedCase {
            get {
                return this.requiresMixedCaseField;
            }
            set {
                this.requiresMixedCaseField = value;
            }
        }
        public EntityItemBoolType requiresSymbol {
            get {
                return this.requiresSymbolField;
            }
            set {
                this.requiresSymbolField = value;
            }
        }
        public EntityItemIntType minutesUntilFailedLoginReset {
            get {
                return this.minutesUntilFailedLoginResetField;
            }
            set {
                this.minutesUntilFailedLoginResetField = value;
            }
        }
        public EntityItemIntType usingHistory {
            get {
                return this.usingHistoryField;
            }
            set {
                this.usingHistoryField = value;
            }
        }
        public EntityItemBoolType canModifyPasswordforSelf {
            get {
                return this.canModifyPasswordforSelfField;
            }
            set {
                this.canModifyPasswordforSelfField = value;
            }
        }
        public EntityItemBoolType usingExpirationDate {
            get {
                return this.usingExpirationDateField;
            }
            set {
                this.usingExpirationDateField = value;
            }
        }
        public EntityItemBoolType usingHardExpirationDate {
            get {
                return this.usingHardExpirationDateField;
            }
            set {
                this.usingHardExpirationDateField = value;
            }
        }
        public EntityItemStringType expirationDateGMT {
            get {
                return this.expirationDateGMTField;
            }
            set {
                this.expirationDateGMTField = value;
            }
        }
        public EntityItemStringType hardExpireDateGMT {
            get {
                return this.hardExpireDateGMTField;
            }
            set {
                this.hardExpireDateGMTField = value;
            }
        }
        public EntityItemIntType maxMinutesUntilDisabled {
            get {
                return this.maxMinutesUntilDisabledField;
            }
            set {
                this.maxMinutesUntilDisabledField = value;
            }
        }
        public EntityItemIntType maxMinutesOfNonUse {
            get {
                return this.maxMinutesOfNonUseField;
            }
            set {
                this.maxMinutesOfNonUseField = value;
            }
        }
        public EntityItemBoolType newPasswordRequired {
            get {
                return this.newPasswordRequiredField;
            }
            set {
                this.newPasswordRequiredField = value;
            }
        }
        public EntityItemBoolType notGuessablePattern {
            get {
                return this.notGuessablePatternField;
            }
            set {
                this.notGuessablePatternField = value;
            }
        }
    }

}

