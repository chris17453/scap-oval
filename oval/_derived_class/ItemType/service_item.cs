using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class service_item : ItemType {
        private EntityItemStringType service_nameField;
        private EntityItemStringType display_nameField;
        private EntityItemStringType descriptionField;
        private EntityItemServiceTypeType[] service_typeField;
        private EntityItemServiceStartTypeType start_typeField;
        private EntityItemServiceCurrentStateType current_stateField;
        private EntityItemServiceControlsAcceptedType[] controls_acceptedField;
        private EntityItemStringType start_nameField;
        private EntityItemStringType pathField;
        private EntityItemIntType pidField;
        private EntityItemBoolType service_flagField;
        private EntityItemStringType[] dependenciesField;
        public EntityItemStringType service_name {
            get {
                return this.service_nameField;
            }
            set {
                this.service_nameField = value;
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
        public EntityItemStringType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        [XmlElementAttribute("service_type")]
        public EntityItemServiceTypeType[] service_type {
            get {
                return this.service_typeField;
            }
            set {
                this.service_typeField = value;
            }
        }
        public EntityItemServiceStartTypeType start_type {
            get {
                return this.start_typeField;
            }
            set {
                this.start_typeField = value;
            }
        }
        public EntityItemServiceCurrentStateType current_state {
            get {
                return this.current_stateField;
            }
            set {
                this.current_stateField = value;
            }
        }
        [XmlElementAttribute("controls_accepted")]
        public EntityItemServiceControlsAcceptedType[] controls_accepted {
            get {
                return this.controls_acceptedField;
            }
            set {
                this.controls_acceptedField = value;
            }
        }
        public EntityItemStringType start_name {
            get {
                return this.start_nameField;
            }
            set {
                this.start_nameField = value;
            }
        }
        public EntityItemStringType path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        public EntityItemIntType pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
            }
        }
        public EntityItemBoolType service_flag {
            get {
                return this.service_flagField;
            }
            set {
                this.service_flagField = value;
            }
        }
        [XmlElementAttribute("dependencies")]
        public EntityItemStringType[] dependencies {
            get {
                return this.dependenciesField;
            }
            set {
                this.dependenciesField = value;
            }
        }
    }

}

