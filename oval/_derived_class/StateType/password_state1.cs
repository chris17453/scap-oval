using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android")]
    [XmlRootAttribute("password_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android", IsNullable=false)]
    public class password_state1 : StateType {
        private EntityStateIntType max_num_failed_user_authField;
        private EntityStateIntType password_histField;
        private EntityStatePasswordQualityType password_qualityField;
        private EntityStateIntType password_min_lengthField;
        private EntityStateIntType password_min_lettersField;
        private EntityStateIntType password_min_lower_case_lettersField;
        private EntityStateIntType password_min_non_lettersField;
        private EntityStateIntType password_min_numericField;
        private EntityStateIntType password_min_symbolsField;
        private EntityStateIntType password_min_upper_case_lettersField;
        private EntityStateIntType password_expiration_timeoutField;
        private EntityStateBoolType password_visibleField;
        private EntityStateBoolType active_password_sufficientField;
        private EntityStateIntType current_failed_password_attemptsField;
        private EntityStateIntType screen_lock_timeoutField;
        private EntityStateKeyguardDisabledFeaturesType keyguard_disabled_featuresField;
        public EntityStateIntType max_num_failed_user_auth {
            get {
                return this.max_num_failed_user_authField;
            }
            set {
                this.max_num_failed_user_authField = value;
            }
        }
        public EntityStateIntType password_hist {
            get {
                return this.password_histField;
            }
            set {
                this.password_histField = value;
            }
        }
        public EntityStatePasswordQualityType password_quality {
            get {
                return this.password_qualityField;
            }
            set {
                this.password_qualityField = value;
            }
        }
        public EntityStateIntType password_min_length {
            get {
                return this.password_min_lengthField;
            }
            set {
                this.password_min_lengthField = value;
            }
        }
        public EntityStateIntType password_min_letters {
            get {
                return this.password_min_lettersField;
            }
            set {
                this.password_min_lettersField = value;
            }
        }
        public EntityStateIntType password_min_lower_case_letters {
            get {
                return this.password_min_lower_case_lettersField;
            }
            set {
                this.password_min_lower_case_lettersField = value;
            }
        }
        public EntityStateIntType password_min_non_letters {
            get {
                return this.password_min_non_lettersField;
            }
            set {
                this.password_min_non_lettersField = value;
            }
        }
        public EntityStateIntType password_min_numeric {
            get {
                return this.password_min_numericField;
            }
            set {
                this.password_min_numericField = value;
            }
        }
        public EntityStateIntType password_min_symbols {
            get {
                return this.password_min_symbolsField;
            }
            set {
                this.password_min_symbolsField = value;
            }
        }
        public EntityStateIntType password_min_upper_case_letters {
            get {
                return this.password_min_upper_case_lettersField;
            }
            set {
                this.password_min_upper_case_lettersField = value;
            }
        }
        public EntityStateIntType password_expiration_timeout {
            get {
                return this.password_expiration_timeoutField;
            }
            set {
                this.password_expiration_timeoutField = value;
            }
        }
        public EntityStateBoolType password_visible {
            get {
                return this.password_visibleField;
            }
            set {
                this.password_visibleField = value;
            }
        }
        public EntityStateBoolType active_password_sufficient {
            get {
                return this.active_password_sufficientField;
            }
            set {
                this.active_password_sufficientField = value;
            }
        }
        public EntityStateIntType current_failed_password_attempts {
            get {
                return this.current_failed_password_attemptsField;
            }
            set {
                this.current_failed_password_attemptsField = value;
            }
        }
        public EntityStateIntType screen_lock_timeout {
            get {
                return this.screen_lock_timeoutField;
            }
            set {
                this.screen_lock_timeoutField = value;
            }
        }
        public EntityStateKeyguardDisabledFeaturesType keyguard_disabled_features {
            get {
                return this.keyguard_disabled_featuresField;
            }
            set {
                this.keyguard_disabled_featuresField = value;
            }
        }
    }

}

