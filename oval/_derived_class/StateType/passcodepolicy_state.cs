using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#apple_ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#apple_ios", IsNullable=false)]
    public class passcodepolicy_state : StateType {
        private EntityStateBoolType allow_simpleField;
        private EntityStateBoolType force_pinField;
        private EntityStateIntType max_failed_attemptsField;
        private EntityStateIntType max_inactivityField;
        private EntityStateIntType max_pin_age_in_daysField;
        private EntityStateIntType min_complex_charsField;
        private EntityStateIntType min_lengthField;
        private EntityStateBoolType require_alphanumericField;
        private EntityStateIntType pin_historyField;
        private EntityStateIntType max_grace_periodField;
        public EntityStateBoolType allow_simple {
            get {
                return this.allow_simpleField;
            }
            set {
                this.allow_simpleField = value;
            }
        }
        public EntityStateBoolType force_pin {
            get {
                return this.force_pinField;
            }
            set {
                this.force_pinField = value;
            }
        }
        public EntityStateIntType max_failed_attempts {
            get {
                return this.max_failed_attemptsField;
            }
            set {
                this.max_failed_attemptsField = value;
            }
        }
        public EntityStateIntType max_inactivity {
            get {
                return this.max_inactivityField;
            }
            set {
                this.max_inactivityField = value;
            }
        }
        public EntityStateIntType max_pin_age_in_days {
            get {
                return this.max_pin_age_in_daysField;
            }
            set {
                this.max_pin_age_in_daysField = value;
            }
        }
        public EntityStateIntType min_complex_chars {
            get {
                return this.min_complex_charsField;
            }
            set {
                this.min_complex_charsField = value;
            }
        }
        public EntityStateIntType min_length {
            get {
                return this.min_lengthField;
            }
            set {
                this.min_lengthField = value;
            }
        }
        public EntityStateBoolType require_alphanumeric {
            get {
                return this.require_alphanumericField;
            }
            set {
                this.require_alphanumericField = value;
            }
        }
        public EntityStateIntType pin_history {
            get {
                return this.pin_historyField;
            }
            set {
                this.pin_historyField = value;
            }
        }
        public EntityStateIntType max_grace_period {
            get {
                return this.max_grace_periodField;
            }
            set {
                this.max_grace_periodField = value;
            }
        }
    }

}

