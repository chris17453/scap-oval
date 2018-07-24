using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public class package511_item : ItemType {
        private EntityItemStringType publisherField;
        private EntityItemStringType nameField;
        private EntityItemVersionType versionField;
        private EntityItemStringType timestampField;
        private EntityItemStringType fmriField;
        private EntityItemStringType summaryField;
        private EntityItemStringType descriptionField;
        private EntityItemStringType categoryField;
        private EntityItemBoolType updates_availableField;
        public EntityItemStringType publisher {
            get {
                return this.publisherField;
            }
            set {
                this.publisherField = value;
            }
        }
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemVersionType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        public EntityItemStringType timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
            }
        }
        public EntityItemStringType fmri {
            get {
                return this.fmriField;
            }
            set {
                this.fmriField = value;
            }
        }
        public EntityItemStringType summary {
            get {
                return this.summaryField;
            }
            set {
                this.summaryField = value;
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
        public EntityItemStringType category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        public EntityItemBoolType updates_available {
            get {
                return this.updates_availableField;
            }
            set {
                this.updates_availableField = value;
            }
        }
    }

}

