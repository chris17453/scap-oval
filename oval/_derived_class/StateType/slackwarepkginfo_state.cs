using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class slackwarepkginfo_state : StateType {
        private EntityStateStringType nameField;
        private slackwarepkginfo_stateVersion version1Field;
        private EntityStateStringType architectureField;
        private EntityStateStringType revisionField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        [XmlElementAttribute("version")]
        public slackwarepkginfo_stateVersion version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
        public EntityStateStringType architecture {
            get {
                return this.architectureField;
            }
            set {
                this.architectureField = value;
            }
        }
        public EntityStateStringType revision {
            get {
                return this.revisionField;
            }
            set {
                this.revisionField = value;
            }
        }
    }

}

