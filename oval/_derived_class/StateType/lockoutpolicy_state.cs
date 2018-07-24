using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class lockoutpolicy_state : StateType {
        private EntityStateIntType force_logoffField;
        private EntityStateIntType lockout_durationField;
        private EntityStateIntType lockout_observation_windowField;
        private EntityStateIntType lockout_thresholdField;
        public EntityStateIntType force_logoff {
            get {
                return this.force_logoffField;
            }
            set {
                this.force_logoffField = value;
            }
        }
        public EntityStateIntType lockout_duration {
            get {
                return this.lockout_durationField;
            }
            set {
                this.lockout_durationField = value;
            }
        }
        public EntityStateIntType lockout_observation_window {
            get {
                return this.lockout_observation_windowField;
            }
            set {
                this.lockout_observation_windowField = value;
            }
        }
        public EntityStateIntType lockout_threshold {
            get {
                return this.lockout_thresholdField;
            }
            set {
                this.lockout_thresholdField = value;
            }
        }
    }

}

