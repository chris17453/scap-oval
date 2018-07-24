using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class softwareupdate_state : StateType {
        private EntityStateBoolType scheduleField;
        private EntityStateStringType software_titleField;
        public EntityStateBoolType schedule {
            get {
                return this.scheduleField;
            }
            set {
                this.scheduleField = value;
            }
        }
        public EntityStateStringType software_title {
            get {
                return this.software_titleField;
            }
            set {
                this.software_titleField = value;
            }
        }
    }

}

