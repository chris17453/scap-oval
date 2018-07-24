using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class dpkginfo_state : StateType {
        private EntityStateStringType nameField;
        private EntityStateStringType archField;
        private dpkginfo_stateEpoch epochField;
        private dpkginfo_stateRelease releaseField;
        private dpkginfo_stateVersion version1Field;
        private dpkginfo_stateEvr evrField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateStringType arch {
            get {
                return this.archField;
            }
            set {
                this.archField = value;
            }
        }
        public dpkginfo_stateEpoch epoch {
            get {
                return this.epochField;
            }
            set {
                this.epochField = value;
            }
        }
        public dpkginfo_stateRelease release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        [XmlElementAttribute("version")]
        public dpkginfo_stateVersion version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
        public dpkginfo_stateEvr evr {
            get {
                return this.evrField;
            }
            set {
                this.evrField = value;
            }
        }
    }

}

