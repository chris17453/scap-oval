using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class process_state : StateType {
        private EntityStateStringType command_lineField;
        private EntityStateIntType pidField;
        private EntityStateIntType ppidField;
        private process_statePriority priorityField;
        private EntityStateStringType image_pathField;
        private EntityStateStringType current_dirField;
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
        public process_statePriority priority {
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
    }

}

