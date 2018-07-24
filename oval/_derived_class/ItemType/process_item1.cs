using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute("process_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class process_item1 : ItemType {
        private EntityItemStringType commandField;
        private EntityItemStringType exec_timeField;
        private EntityItemIntType pidField;
        private EntityItemIntType ppidField;
        private EntityItemIntType priorityField;
        private EntityItemIntType ruidField;
        private EntityItemStringType scheduling_classField;
        private EntityItemStringType start_timeField;
        private EntityItemStringType ttyField;
        private EntityItemIntType user_idField;
        public EntityItemStringType command {
            get {
                return this.commandField;
            }
            set {
                this.commandField = value;
            }
        }
        public EntityItemStringType exec_time {
            get {
                return this.exec_timeField;
            }
            set {
                this.exec_timeField = value;
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
        public EntityItemIntType priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
        public EntityItemIntType ruid {
            get {
                return this.ruidField;
            }
            set {
                this.ruidField = value;
            }
        }
        public EntityItemStringType scheduling_class {
            get {
                return this.scheduling_classField;
            }
            set {
                this.scheduling_classField = value;
            }
        }
        public EntityItemStringType start_time {
            get {
                return this.start_timeField;
            }
            set {
                this.start_timeField = value;
            }
        }
        public EntityItemStringType tty {
            get {
                return this.ttyField;
            }
            set {
                this.ttyField = value;
            }
        }
        public EntityItemIntType user_id {
            get {
                return this.user_idField;
            }
            set {
                this.user_idField = value;
            }
        }
    }

}

