using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class launchd_state : StateType {
        private EntityStateStringType labelField;
        private EntityStateIntType pidField;
        private EntityStateIntType statusField;
        public EntityStateStringType label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        public EntityStateIntType pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
            }
        }
        public EntityStateIntType status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }

}

