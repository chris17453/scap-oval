using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#apple_ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#apple_ios", IsNullable=false)]
    public class profile_item : ItemType {
        private EntityItemBoolType has_removal_passcodeField;
        private EntityItemBoolType is_encryptedField;
        private EntityItemRecordType[] payloadField;
        private EntityItemStringType descriptionField;
        private EntityItemStringType display_nameField;
        private EntityItemStringType identifierField;
        private EntityItemStringType organizationField;
        private EntityItemBoolType removal_disallowedField;
        private EntityItemStringType uuidField;
        private EntityItemIntType versionField;
        public EntityItemBoolType has_removal_passcode {
            get {
                return this.has_removal_passcodeField;
            }
            set {
                this.has_removal_passcodeField = value;
            }
        }
        public EntityItemBoolType is_encrypted {
            get {
                return this.is_encryptedField;
            }
            set {
                this.is_encryptedField = value;
            }
        }
        [XmlElementAttribute("payload")]
        public EntityItemRecordType[] payload {
            get {
                return this.payloadField;
            }
            set {
                this.payloadField = value;
            }
        }
        public EntityItemStringType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        public EntityItemStringType display_name {
            get {
                return this.display_nameField;
            }
            set {
                this.display_nameField = value;
            }
        }
        public EntityItemStringType identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        public EntityItemStringType organization {
            get {
                return this.organizationField;
            }
            set {
                this.organizationField = value;
            }
        }
        public EntityItemBoolType removal_disallowed {
            get {
                return this.removal_disallowedField;
            }
            set {
                this.removal_disallowedField = value;
            }
        }
        public EntityItemStringType uuid {
            get {
                return this.uuidField;
            }
            set {
                this.uuidField = value;
            }
        }
        public EntityItemIntType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }

}

