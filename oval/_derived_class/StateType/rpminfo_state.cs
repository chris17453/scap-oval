using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class rpminfo_state : StateType {
        private EntityStateStringType nameField;
        private EntityStateStringType archField;
        private rpminfo_stateEpoch epochField;
        private rpminfo_stateRelease releaseField;
        private rpminfo_stateVersion version1Field;
        private EntityStateEVRStringType evrField;
        private EntityStateStringType signature_keyidField;
        private EntityStateStringType extended_nameField;
        private EntityStateStringType filepathField;
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
        public rpminfo_stateEpoch epoch {
            get {
                return this.epochField;
            }
            set {
                this.epochField = value;
            }
        }
        public rpminfo_stateRelease release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        [XmlElementAttribute("version")]
        public rpminfo_stateVersion version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
        public EntityStateEVRStringType evr {
            get {
                return this.evrField;
            }
            set {
                this.evrField = value;
            }
        }
        public EntityStateStringType signature_keyid {
            get {
                return this.signature_keyidField;
            }
            set {
                this.signature_keyidField = value;
            }
        }
        public EntityStateStringType extended_name {
            get {
                return this.extended_nameField;
            }
            set {
                this.extended_nameField = value;
            }
        }
        public EntityStateStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
            }
        }
    }

}

