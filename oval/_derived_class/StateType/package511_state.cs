using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris", IsNullable=false)]
    public class package511_state : StateType {
        private EntityStateStringType publisherField;
        private EntityStateStringType nameField;
        private EntityStateVersionType version1Field;
        private EntityStateStringType timestampField;
        private EntityStateStringType fmriField;
        private EntityStateStringType summaryField;
        private EntityStateStringType descriptionField;
        private EntityStateStringType categoryField;
        private EntityStateBoolType updates_availableField;
        public EntityStateStringType publisher {
            get {
                return this.publisherField;
            }
            set {
                this.publisherField = value;
            }
        }
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        [XmlElementAttribute("version")]
        public EntityStateVersionType version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
        public EntityStateStringType timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
            }
        }
        public EntityStateStringType fmri {
            get {
                return this.fmriField;
            }
            set {
                this.fmriField = value;
            }
        }
        public EntityStateStringType summary {
            get {
                return this.summaryField;
            }
            set {
                this.summaryField = value;
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
        public EntityStateStringType category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        public EntityStateBoolType updates_available {
            get {
                return this.updates_availableField;
            }
            set {
                this.updates_availableField = value;
            }
        }
    }

}

