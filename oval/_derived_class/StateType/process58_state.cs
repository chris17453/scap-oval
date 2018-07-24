using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class process58_state : StateType {
        private EntityStateStringType command_lineField;
        private EntityStateIntType pidField;
        private EntityStateIntType ppidField;
        private process58_statePriority priorityField;
        private EntityStateStringType image_pathField;
        private EntityStateStringType current_dirField;
        private EntityStateIntType creation_timeField;
        private EntityStateBoolType dep_enabledField;
        private EntityStateStringType primary_window_textField;
        private EntityStateStringType nameField;
        public EntityStateStringType command_line {
            get {
                return this.command_lineField;
            }
            set {
                this.command_lineField = value;
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
        public EntityStateIntType ppid {
            get {
                return this.ppidField;
            }
            set {
                this.ppidField = value;
            }
        }
        public process58_statePriority priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
        public EntityStateStringType image_path {
            get {
                return this.image_pathField;
            }
            set {
                this.image_pathField = value;
            }
        }
        public EntityStateStringType current_dir {
            get {
                return this.current_dirField;
            }
            set {
                this.current_dirField = value;
            }
        }
        public EntityStateIntType creation_time {
            get {
                return this.creation_timeField;
            }
            set {
                this.creation_timeField = value;
            }
        }
        public EntityStateBoolType dep_enabled {
            get {
                return this.dep_enabledField;
            }
            set {
                this.dep_enabledField = value;
            }
        }
        public EntityStateStringType primary_window_text {
            get {
                return this.primary_window_textField;
            }
            set {
                this.primary_window_textField = value;
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
    }

}

