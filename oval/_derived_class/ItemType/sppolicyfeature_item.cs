using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class sppolicyfeature_item : ItemType {
        private EntityItemStringType farmnameField;
        private EntityItemStringType configpageField;
        private EntityItemStringType defaultcustomdataField;
        private EntityItemStringType descriptionField;
        private EntityItemStringType globalconfigpageField;
        private EntityItemStringType globalcustomdataField;
        private EntityItemStringType groupField;
        private EntityItemStringType nameField;
        private EntityItemStringType publisherField;
        private EntityItemPolicyFeatureStateType stateField;
        public EntityItemStringType farmname {
            get {
                return this.farmnameField;
            }
            set {
                this.farmnameField = value;
            }
        }
        public EntityItemStringType configpage {
            get {
                return this.configpageField;
            }
            set {
                this.configpageField = value;
            }
        }
        public EntityItemStringType defaultcustomdata {
            get {
                return this.defaultcustomdataField;
            }
            set {
                this.defaultcustomdataField = value;
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
        public EntityItemStringType globalconfigpage {
            get {
                return this.globalconfigpageField;
            }
            set {
                this.globalconfigpageField = value;
            }
        }
        public EntityItemStringType globalcustomdata {
            get {
                return this.globalcustomdataField;
            }
            set {
                this.globalcustomdataField = value;
            }
        }
        public EntityItemStringType group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
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
        public EntityItemStringType publisher {
            get {
                return this.publisherField;
            }
            set {
                this.publisherField = value;
            }
        }
        public EntityItemPolicyFeatureStateType state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
    }

}

