using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class process_item : ItemType {
        private EntityItemStringType command_lineField;
        private EntityItemIntType pidField;
        private EntityItemIntType ppidField;
        private process_itemPriority priorityField;
        private EntityItemStringType image_pathField;
        private EntityItemStringType current_dirField;
        private EntityItemIntType creation_timeField;
        private EntityItemBoolType dep_enabledField;
        private EntityItemStringType primary_window_textField;
        private EntityItemStringType nameField;
        public EntityItemStringType command_line {
            get {
                return this.command_lineField;
            }
            set {
                this.command_lineField = value;
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
        public EntityItemIntType ppid {
            get {
                return this.ppidField;
            }
            set {
                this.ppidField = value;
            }
        }
        public process_itemPriority priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
        public EntityItemStringType image_path {
            get {
                return this.image_pathField;
            }
            set {
                this.image_pathField = value;
            }
        }
        public EntityItemStringType current_dir {
            get {
                return this.current_dirField;
            }
            set {
                this.current_dirField = value;
            }
        }
        public EntityItemIntType creation_time {
            get {
                return this.creation_timeField;
            }
            set {
                this.creation_timeField = value;
            }
        }
        public EntityItemBoolType dep_enabled {
            get {
                return this.dep_enabledField;
            }
            set {
                this.dep_enabledField = value;
            }
        }
        public EntityItemStringType primary_window_text {
            get {
                return this.primary_window_textField;
            }
            set {
                this.primary_window_textField = value;
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
    }

}

