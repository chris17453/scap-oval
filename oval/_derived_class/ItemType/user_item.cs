using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class user_item : ItemType {
        private EntityItemStringType userField;
        private EntityItemBoolType enabledField;
        private EntityItemStringType[] groupField;
        private EntityItemIntType last_logonField;
        private EntityItemStringType full_nameField;
        private EntityItemStringType commentField;
        private EntityItemIntType password_age_daysField;
        private EntityItemBoolType lockoutField;
        private EntityItemBoolType passwd_notreqdField;
        private EntityItemBoolType dont_expire_passwdField;
        private EntityItemBoolType encrypted_text_password_allowedField;
        private EntityItemBoolType not_delegatedField;
        private EntityItemBoolType use_des_key_onlyField;
        private EntityItemBoolType dont_require_preauthField;
        private EntityItemBoolType password_expiredField;
        private EntityItemBoolType smartcard_requiredField;
        private EntityItemBoolType trusted_for_delegationField;
        private EntityItemBoolType trusted_to_authenticate_for_delegationField;
        public EntityItemStringType user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
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
        [XmlElementAttribute("group")]
        public EntityItemStringType[] group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        public EntityItemIntType last_logon {
            get {
                return this.last_logonField;
            }
            set {
                this.last_logonField = value;
            }
        }
        public EntityItemStringType full_name {
            get {
                return this.full_nameField;
            }
            set {
                this.full_nameField = value;
            }
        }
        public EntityItemStringType comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        public EntityItemIntType password_age_days {
            get {
                return this.password_age_daysField;
            }
            set {
                this.password_age_daysField = value;
            }
        }
        public EntityItemBoolType lockout {
            get {
                return this.lockoutField;
            }
            set {
                this.lockoutField = value;
            }
        }
        public EntityItemBoolType passwd_notreqd {
            get {
                return this.passwd_notreqdField;
            }
            set {
                this.passwd_notreqdField = value;
            }
        }
        public EntityItemBoolType dont_expire_passwd {
            get {
                return this.dont_expire_passwdField;
            }
            set {
                this.dont_expire_passwdField = value;
            }
        }
        public EntityItemBoolType encrypted_text_password_allowed {
            get {
                return this.encrypted_text_password_allowedField;
            }
            set {
                this.encrypted_text_password_allowedField = value;
            }
        }
        public EntityItemBoolType not_delegated {
            get {
                return this.not_delegatedField;
            }
            set {
                this.not_delegatedField = value;
            }
        }
        public EntityItemBoolType use_des_key_only {
            get {
                return this.use_des_key_onlyField;
            }
            set {
                this.use_des_key_onlyField = value;
            }
        }
        public EntityItemBoolType dont_require_preauth {
            get {
                return this.dont_require_preauthField;
            }
            set {
                this.dont_require_preauthField = value;
            }
        }
        public EntityItemBoolType password_expired {
            get {
                return this.password_expiredField;
            }
            set {
                this.password_expiredField = value;
            }
        }
        public EntityItemBoolType smartcard_required {
            get {
                return this.smartcard_requiredField;
            }
            set {
                this.smartcard_requiredField = value;
            }
        }
        public EntityItemBoolType trusted_for_delegation {
            get {
                return this.trusted_for_delegationField;
            }
            set {
                this.trusted_for_delegationField = value;
            }
        }
        public EntityItemBoolType trusted_to_authenticate_for_delegation {
            get {
                return this.trusted_to_authenticate_for_delegationField;
            }
            set {
                this.trusted_to_authenticate_for_delegationField = value;
            }
        }
    }

}

