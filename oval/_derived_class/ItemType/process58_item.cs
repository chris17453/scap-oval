using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class process58_item : ItemType {
        private EntityItemStringType command_lineField;
        private EntityItemStringType exec_timeField;
        private EntityItemIntType pidField;
        private EntityItemIntType ppidField;
        private EntityItemIntType priorityField;
        private EntityItemIntType ruidField;
        private EntityItemStringType scheduling_classField;
        private EntityItemStringType start_timeField;
        private EntityItemStringType ttyField;
        private EntityItemIntType user_idField;
        private EntityItemBoolType exec_shieldField;
        private EntityItemIntType loginuidField;
        private EntityItemCapabilityType[] posix_capabilityField;
        private EntityItemStringType selinux_domain_labelField;
        private EntityItemIntType session_idField;
        public EntityItemStringType command_line {
            get {
                return this.command_lineField;
            }
            set {
                this.command_lineField = value;
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
        public EntityItemBoolType exec_shield {
            get {
                return this.exec_shieldField;
            }
            set {
                this.exec_shieldField = value;
            }
        }
        public EntityItemIntType loginuid {
            get {
                return this.loginuidField;
            }
            set {
                this.loginuidField = value;
            }
        }
        [XmlElementAttribute("posix_capability")]
        public EntityItemCapabilityType[] posix_capability {
            get {
                return this.posix_capabilityField;
            }
            set {
                this.posix_capabilityField = value;
            }
        }
        public EntityItemStringType selinux_domain_label {
            get {
                return this.selinux_domain_labelField;
            }
            set {
                this.selinux_domain_labelField = value;
            }
        }
        public EntityItemIntType session_id {
            get {
                return this.session_idField;
            }
            set {
                this.session_idField = value;
            }
        }
    }

}

