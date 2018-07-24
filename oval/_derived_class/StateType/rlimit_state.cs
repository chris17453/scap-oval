using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class rlimit_state : StateType {
        private EntityStateIntType cpu_currentField;
        private EntityStateIntType cpu_maxField;
        private EntityStateIntType filesize_currentField;
        private EntityStateIntType filesize_maxField;
        private EntityStateIntType data_currentField;
        private EntityStateIntType data_maxField;
        private EntityStateIntType stack_currentField;
        private EntityStateIntType stack_maxField;
        private EntityStateIntType core_currentField;
        private EntityStateIntType core_maxField;
        private EntityStateIntType rss_currentField;
        private EntityStateIntType rss_maxField;
        private EntityStateIntType memlock_currentField;
        private EntityStateIntType memlock_maxField;
        private EntityStateIntType maxproc_currentField;
        private EntityStateIntType maxproc_maxField;
        private EntityStateIntType maxfiles_currentField;
        private EntityStateIntType maxfiles_maxField;
        public EntityStateIntType cpu_current {
            get {
                return this.cpu_currentField;
            }
            set {
                this.cpu_currentField = value;
            }
        }
        public EntityStateIntType cpu_max {
            get {
                return this.cpu_maxField;
            }
            set {
                this.cpu_maxField = value;
            }
        }
        public EntityStateIntType filesize_current {
            get {
                return this.filesize_currentField;
            }
            set {
                this.filesize_currentField = value;
            }
        }
        public EntityStateIntType filesize_max {
            get {
                return this.filesize_maxField;
            }
            set {
                this.filesize_maxField = value;
            }
        }
        public EntityStateIntType data_current {
            get {
                return this.data_currentField;
            }
            set {
                this.data_currentField = value;
            }
        }
        public EntityStateIntType data_max {
            get {
                return this.data_maxField;
            }
            set {
                this.data_maxField = value;
            }
        }
        public EntityStateIntType stack_current {
            get {
                return this.stack_currentField;
            }
            set {
                this.stack_currentField = value;
            }
        }
        public EntityStateIntType stack_max {
            get {
                return this.stack_maxField;
            }
            set {
                this.stack_maxField = value;
            }
        }
        public EntityStateIntType core_current {
            get {
                return this.core_currentField;
            }
            set {
                this.core_currentField = value;
            }
        }
        public EntityStateIntType core_max {
            get {
                return this.core_maxField;
            }
            set {
                this.core_maxField = value;
            }
        }
        public EntityStateIntType rss_current {
            get {
                return this.rss_currentField;
            }
            set {
                this.rss_currentField = value;
            }
        }
        public EntityStateIntType rss_max {
            get {
                return this.rss_maxField;
            }
            set {
                this.rss_maxField = value;
            }
        }
        public EntityStateIntType memlock_current {
            get {
                return this.memlock_currentField;
            }
            set {
                this.memlock_currentField = value;
            }
        }
        public EntityStateIntType memlock_max {
            get {
                return this.memlock_maxField;
            }
            set {
                this.memlock_maxField = value;
            }
        }
        public EntityStateIntType maxproc_current {
            get {
                return this.maxproc_currentField;
            }
            set {
                this.maxproc_currentField = value;
            }
        }
        public EntityStateIntType maxproc_max {
            get {
                return this.maxproc_maxField;
            }
            set {
                this.maxproc_maxField = value;
            }
        }
        public EntityStateIntType maxfiles_current {
            get {
                return this.maxfiles_currentField;
            }
            set {
                this.maxfiles_currentField = value;
            }
        }
        public EntityStateIntType maxfiles_max {
            get {
                return this.maxfiles_maxField;
            }
            set {
                this.maxfiles_maxField = value;
            }
        }
    }

}

