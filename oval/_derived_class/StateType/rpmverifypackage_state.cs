using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class rpmverifypackage_state : StateType {
        private EntityStateStringType nameField;
        private rpmverifypackage_stateEpoch epochField;
        private rpmverifypackage_stateVersion version1Field;
        private rpmverifypackage_stateRelease releaseField;
        private EntityStateStringType archField;
        private EntityStateStringType extended_nameField;
        private EntityStateBoolType dependency_check_passedField;
        private EntityStateBoolType digest_check_passedField;
        private EntityStateBoolType verification_script_successfulField;
        private EntityStateBoolType signature_check_passedField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public rpmverifypackage_stateEpoch epoch {
            get {
                return this.epochField;
            }
            set {
                this.epochField = value;
            }
        }
        [XmlElementAttribute("version")]
        public rpmverifypackage_stateVersion version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
        public rpmverifypackage_stateRelease release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
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
        public EntityStateStringType extended_name {
            get {
                return this.extended_nameField;
            }
            set {
                this.extended_nameField = value;
            }
        }
        public EntityStateBoolType dependency_check_passed {
            get {
                return this.dependency_check_passedField;
            }
            set {
                this.dependency_check_passedField = value;
            }
        }
        public EntityStateBoolType digest_check_passed {
            get {
                return this.digest_check_passedField;
            }
            set {
                this.digest_check_passedField = value;
            }
        }
        public EntityStateBoolType verification_script_successful {
            get {
                return this.verification_script_successfulField;
            }
            set {
                this.verification_script_successfulField = value;
            }
        }
        public EntityStateBoolType signature_check_passed {
            get {
                return this.signature_check_passedField;
            }
            set {
                this.signature_check_passedField = value;
            }
        }
    }

}

