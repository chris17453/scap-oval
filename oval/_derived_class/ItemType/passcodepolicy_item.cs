using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#apple_ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#apple_ios", IsNullable=false)]
    public class passcodepolicy_item : ItemType {
        private EntityItemBoolType allow_simpleField;
        private EntityItemBoolType force_pinField;
        private EntityItemIntType max_failed_attemptsField;
        private EntityItemIntType max_inactivityField;
        private EntityItemIntType max_pin_age_in_daysField;
        private EntityItemIntType min_complex_charsField;
        private EntityItemIntType min_lengthField;
        private EntityItemBoolType require_alphanumericField;
        private EntityItemIntType pin_historyField;
        private EntityItemIntType max_grace_periodField;
        public EntityItemBoolType allow_simple {
            get {
                return this.allow_simpleField;
            }
            set {
                this.allow_simpleField = value;
            }
        }
        public EntityItemBoolType force_pin {
            get {
                return this.force_pinField;
            }
            set {
                this.force_pinField = value;
            }
        }
        public EntityItemIntType max_failed_attempts {
            get {
                return this.max_failed_attemptsField;
            }
            set {
                this.max_failed_attemptsField = value;
            }
        }
        public EntityItemIntType max_inactivity {
            get {
                return this.max_inactivityField;
            }
            set {
                this.max_inactivityField = value;
            }
        }
        public EntityItemIntType max_pin_age_in_days {
            get {
                return this.max_pin_age_in_daysField;
            }
            set {
                this.max_pin_age_in_daysField = value;
            }
        }
        public EntityItemIntType min_complex_chars {
            get {
                return this.min_complex_charsField;
            }
            set {
                this.min_complex_charsField = value;
            }
        }
        public EntityItemIntType min_length {
            get {
                return this.min_lengthField;
            }
            set {
                this.min_lengthField = value;
            }
        }
        public EntityItemBoolType require_alphanumeric {
            get {
                return this.require_alphanumericField;
            }
            set {
                this.require_alphanumericField = value;
            }
        }
        public EntityItemIntType pin_history {
            get {
                return this.pin_historyField;
            }
            set {
                this.pin_historyField = value;
            }
        }
        public EntityItemIntType max_grace_period {
            get {
                return this.max_grace_periodField;
            }
            set {
                this.max_grace_periodField = value;
            }
        }
    }

}

