using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    [XmlRootAttribute("process_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IsNullable=false)]
    public class process_state1 : StateType {
        private EntityStateStringType commandField;
        private EntityStateStringType exec_timeField;
        private EntityStateIntType pidField;
        private EntityStateIntType ppidField;
        private EntityStateIntType priorityField;
        private EntityStateIntType ruidField;
        private EntityStateStringType scheduling_classField;
        private EntityStateStringType start_timeField;
        private EntityStateStringType ttyField;
        private EntityStateIntType user_idField;
        public EntityStateStringType command {
            get {
                return this.commandField;
            }
            set {
                this.commandField = value;
            }
        }
        public EntityStateStringType exec_time {
            get {
                return this.exec_timeField;
            }
            set {
                this.exec_timeField = value;
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
        public EntityStateIntType priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
        public EntityStateIntType ruid {
            get {
                return this.ruidField;
            }
            set {
                this.ruidField = value;
            }
        }
        public EntityStateStringType scheduling_class {
            get {
                return this.scheduling_classField;
            }
            set {
                this.scheduling_classField = value;
            }
        }
        public EntityStateStringType start_time {
            get {
                return this.start_timeField;
            }
            set {
                this.start_timeField = value;
            }
        }
        public EntityStateStringType tty {
            get {
                return this.ttyField;
            }
            set {
                this.ttyField = value;
            }
        }
        public EntityStateIntType user_id {
            get {
                return this.user_idField;
            }
            set {
                this.user_idField = value;
            }
        }
    }

}

