using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class user_state : StateType {
        private EntityStateStringType userField;
        private EntityStateBoolType enabledField;
        private EntityStateStringType groupField;
        private EntityStateIntType last_logonField;
        private EntityStateStringType full_nameField;
        private EntityStateStringType comment1Field;
        private EntityStateIntType password_age_daysField;
        private EntityStateBoolType lockoutField;
        private EntityStateBoolType passwd_notreqdField;
        private EntityStateBoolType dont_expire_passwdField;
        private EntityStateBoolType encrypted_text_password_allowedField;
        private EntityStateBoolType not_delegatedField;
        private EntityStateBoolType use_des_key_onlyField;
        private EntityStateBoolType dont_require_preauthField;
        private EntityStateBoolType password_expiredField;
        private EntityStateBoolType smartcard_requiredField;
        private EntityStateBoolType trusted_for_delegationField;
        private EntityStateBoolType trusted_to_authenticate_for_delegationField;
        public EntityStateStringType user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
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
        public EntityStateStringType group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        public EntityStateIntType last_logon {
            get {
                return this.last_logonField;
            }
            set {
                this.last_logonField = value;
            }
        }
        public EntityStateStringType full_name {
            get {
                return this.full_nameField;
            }
            set {
                this.full_nameField = value;
            }
        }
        [XmlElementAttribute("comment")]
        public EntityStateStringType comment1 {
            get {
                return this.comment1Field;
            }
            set {
                this.comment1Field = value;
            }
        }
        public EntityStateIntType password_age_days {
            get {
                return this.password_age_daysField;
            }
            set {
                this.password_age_daysField = value;
            }
        }
        public EntityStateBoolType lockout {
            get {
                return this.lockoutField;
            }
            set {
                this.lockoutField = value;
            }
        }
        public EntityStateBoolType passwd_notreqd {
            get {
                return this.passwd_notreqdField;
            }
            set {
                this.passwd_notreqdField = value;
            }
        }
        public EntityStateBoolType dont_expire_passwd {
            get {
                return this.dont_expire_passwdField;
            }
            set {
                this.dont_expire_passwdField = value;
            }
        }
        public EntityStateBoolType encrypted_text_password_allowed {
            get {
                return this.encrypted_text_password_allowedField;
            }
            set {
                this.encrypted_text_password_allowedField = value;
            }
        }
        public EntityStateBoolType not_delegated {
            get {
                return this.not_delegatedField;
            }
            set {
                this.not_delegatedField = value;
            }
        }
        public EntityStateBoolType use_des_key_only {
            get {
                return this.use_des_key_onlyField;
            }
            set {
                this.use_des_key_onlyField = value;
            }
        }
        public EntityStateBoolType dont_require_preauth {
            get {
                return this.dont_require_preauthField;
            }
            set {
                this.dont_require_preauthField = value;
            }
        }
        public EntityStateBoolType password_expired {
            get {
                return this.password_expiredField;
            }
            set {
                this.password_expiredField = value;
            }
        }
        public EntityStateBoolType smartcard_required {
            get {
                return this.smartcard_requiredField;
            }
            set {
                this.smartcard_requiredField = value;
            }
        }
        public EntityStateBoolType trusted_for_delegation {
            get {
                return this.trusted_for_delegationField;
            }
            set {
                this.trusted_for_delegationField = value;
            }
        }
        public EntityStateBoolType trusted_to_authenticate_for_delegation {
            get {
                return this.trusted_to_authenticate_for_delegationField;
            }
            set {
                this.trusted_to_authenticate_for_delegationField = value;
            }
        }
    }

}

