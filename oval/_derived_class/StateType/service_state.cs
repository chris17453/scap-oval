using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class service_state : StateType {
        private EntityStateStringType service_nameField;
        private EntityStateStringType display_nameField;
        private EntityStateStringType descriptionField;
        private EntityStateServiceTypeType service_typeField;
        private EntityStateServiceStartTypeType start_typeField;
        private EntityStateServiceCurrentStateType current_stateField;
        private EntityStateServiceControlsAcceptedType controls_acceptedField;
        private EntityStateStringType start_nameField;
        private EntityStateStringType pathField;
        private EntityStateIntType pidField;
        private EntityStateBoolType service_flagField;
        private EntityStateStringType dependenciesField;
        public EntityStateStringType service_name {
            get {
                return this.service_nameField;
            }
            set {
                this.service_nameField = value;
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
        public EntityStateStringType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        public EntityStateServiceTypeType service_type {
            get {
                return this.service_typeField;
            }
            set {
                this.service_typeField = value;
            }
        }
        public EntityStateServiceStartTypeType start_type {
            get {
                return this.start_typeField;
            }
            set {
                this.start_typeField = value;
            }
        }
        public EntityStateServiceCurrentStateType current_state {
            get {
                return this.current_stateField;
            }
            set {
                this.current_stateField = value;
            }
        }
        public EntityStateServiceControlsAcceptedType controls_accepted {
            get {
                return this.controls_acceptedField;
            }
            set {
                this.controls_acceptedField = value;
            }
        }
        public EntityStateStringType start_name {
            get {
                return this.start_nameField;
            }
            set {
                this.start_nameField = value;
            }
        }
        public EntityStateStringType path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        public EntityStateIntType pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
            }
        }
        public EntityStateBoolType service_flag {
            get {
                return this.service_flagField;
            }
            set {
                this.service_flagField = value;
            }
        }
        public EntityStateStringType dependencies {
            get {
                return this.dependenciesField;
            }
            set {
                this.dependenciesField = value;
            }
        }
    }

}

