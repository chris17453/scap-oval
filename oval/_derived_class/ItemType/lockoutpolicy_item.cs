using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class lockoutpolicy_item : ItemType {
        private EntityItemIntType force_logoffField;
        private EntityItemIntType lockout_durationField;
        private EntityItemIntType lockout_observation_windowField;
        private EntityItemIntType lockout_thresholdField;
        public EntityItemIntType force_logoff {
            get {
                return this.force_logoffField;
            }
            set {
                this.force_logoffField = value;
            }
        }
        public EntityItemIntType lockout_duration {
            get {
                return this.lockout_durationField;
            }
            set {
                this.lockout_durationField = value;
            }
        }
        public EntityItemIntType lockout_observation_window {
            get {
                return this.lockout_observation_windowField;
            }
            set {
                this.lockout_observation_windowField = value;
            }
        }
        public EntityItemIntType lockout_threshold {
            get {
                return this.lockout_thresholdField;
            }
            set {
                this.lockout_thresholdField = value;
            }
        }
    }

}

