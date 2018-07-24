using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class sppolicyfeature_state : StateType {
        private EntityStateStringType farmnameField;
        private EntityStateStringType configpageField;
        private EntityStateStringType defaultcustomdataField;
        private EntityStateStringType descriptionField;
        private EntityStateStringType globalconfigpageField;
        private EntityStateStringType globalcustomdataField;
        private EntityStateStringType groupField;
        private EntityStateStringType nameField;
        private EntityStateStringType publisherField;
        private EntityStatePolicyFeatureStateType stateField;
        public EntityStateStringType farmname {
            get {
                return this.farmnameField;
            }
            set {
                this.farmnameField = value;
            }
        }
        public EntityStateStringType configpage {
            get {
                return this.configpageField;
            }
            set {
                this.configpageField = value;
            }
        }
        public EntityStateStringType defaultcustomdata {
            get {
                return this.defaultcustomdataField;
            }
            set {
                this.defaultcustomdataField = value;
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
        public EntityStateStringType globalconfigpage {
            get {
                return this.globalconfigpageField;
            }
            set {
                this.globalconfigpageField = value;
            }
        }
        public EntityStateStringType globalcustomdata {
            get {
                return this.globalcustomdataField;
            }
            set {
                this.globalcustomdataField = value;
            }
        }
        public EntityStateStringType group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
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
        public EntityStateStringType publisher {
            get {
                return this.publisherField;
            }
            set {
                this.publisherField = value;
            }
        }
        public EntityStatePolicyFeatureStateType state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
    }

}

