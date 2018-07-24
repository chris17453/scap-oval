using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#apple_ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#apple_ios", IsNullable=false)]
    public class profile_state : StateType {
        private EntityStateBoolType has_removal_passcodeField;
        private EntityStateBoolType is_encryptedField;
        private EntityStateRecordType payloadField;
        private EntityStateStringType descriptionField;
        private EntityStateStringType display_nameField;
        private EntityStateStringType identifierField;
        private EntityStateStringType organizationField;
        private EntityStateBoolType removal_disallowedField;
        private EntityStateStringType uuidField;
        private EntityStateIntType version1Field;
        public EntityStateBoolType has_removal_passcode {
            get {
                return this.has_removal_passcodeField;
            }
            set {
                this.has_removal_passcodeField = value;
            }
        }
        public EntityStateBoolType is_encrypted {
            get {
                return this.is_encryptedField;
            }
            set {
                this.is_encryptedField = value;
            }
        }
        public EntityStateRecordType payload {
            get {
                return this.payloadField;
            }
            set {
                this.payloadField = value;
            }
        }
        public EntityStateStringType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        public EntityStateStringType display_name {
            get {
                return this.display_nameField;
            }
            set {
                this.display_nameField = value;
            }
        }
        public EntityStateStringType identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        public EntityStateStringType organization {
            get {
                return this.organizationField;
            }
            set {
                this.organizationField = value;
            }
        }
        public EntityStateBoolType removal_disallowed {
            get {
                return this.removal_disallowedField;
            }
            set {
                this.removal_disallowedField = value;
            }
        }
        public EntityStateStringType uuid {
            get {
                return this.uuidField;
            }
            set {
                this.uuidField = value;
            }
        }
        [XmlElementAttribute("version")]
        public EntityStateIntType version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
    }

}

