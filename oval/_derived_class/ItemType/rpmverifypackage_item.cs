using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux", IsNullable=false)]
    public class rpmverifypackage_item : ItemType {
        private EntityItemStringType nameField;
        private rpmverifypackage_itemEpoch epochField;
        private rpmverifypackage_itemVersion versionField;
        private rpmverifypackage_itemRelease releaseField;
        private EntityItemStringType archField;
        private EntityItemStringType extended_nameField;
        private EntityItemBoolType dependency_check_passedField;
        private EntityItemBoolType digest_check_passedField;
        private EntityItemBoolType verification_script_successfulField;
        private EntityItemBoolType signature_check_passedField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public rpmverifypackage_itemEpoch epoch {
            get {
                return this.epochField;
            }
            set {
                this.epochField = value;
            }
        }
        public rpmverifypackage_itemVersion version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        public rpmverifypackage_itemRelease release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        public EntityItemStringType arch {
            get {
                return this.archField;
            }
            set {
                this.archField = value;
            }
        }
        public EntityItemStringType extended_name {
            get {
                return this.extended_nameField;
            }
            set {
                this.extended_nameField = value;
            }
        }
        public EntityItemBoolType dependency_check_passed {
            get {
                return this.dependency_check_passedField;
            }
            set {
                this.dependency_check_passedField = value;
            }
        }
        public EntityItemBoolType digest_check_passed {
            get {
                return this.digest_check_passedField;
            }
            set {
                this.digest_check_passedField = value;
            }
        }
        public EntityItemBoolType verification_script_successful {
            get {
                return this.verification_script_successfulField;
            }
            set {
                this.verification_script_successfulField = value;
            }
        }
        public EntityItemBoolType signature_check_passed {
            get {
                return this.signature_check_passedField;
            }
            set {
                this.signature_check_passedField = value;
            }
        }
    }

}

