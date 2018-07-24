using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class rlimit_item : ItemType {
        private EntityItemIntType cpu_currentField;
        private EntityItemIntType cpu_maxField;
        private EntityItemIntType filesize_currentField;
        private EntityItemIntType filesize_maxField;
        private EntityItemIntType data_currentField;
        private EntityItemIntType data_maxField;
        private EntityItemIntType stack_currentField;
        private EntityItemIntType stack_maxField;
        private EntityItemIntType core_currentField;
        private EntityItemIntType core_maxField;
        private EntityItemIntType rss_currentField;
        private EntityItemIntType rss_maxField;
        private EntityItemIntType memlock_currentField;
        private EntityItemIntType memlock_maxField;
        private EntityItemIntType maxproc_currentField;
        private EntityItemIntType maxproc_maxField;
        private EntityItemIntType maxfiles_currentField;
        private EntityItemIntType maxfiles_maxField;
        public EntityItemIntType cpu_current {
            get {
                return this.cpu_currentField;
            }
            set {
                this.cpu_currentField = value;
            }
        }
        public EntityItemIntType cpu_max {
            get {
                return this.cpu_maxField;
            }
            set {
                this.cpu_maxField = value;
            }
        }
        public EntityItemIntType filesize_current {
            get {
                return this.filesize_currentField;
            }
            set {
                this.filesize_currentField = value;
            }
        }
        public EntityItemIntType filesize_max {
            get {
                return this.filesize_maxField;
            }
            set {
                this.filesize_maxField = value;
            }
        }
        public EntityItemIntType data_current {
            get {
                return this.data_currentField;
            }
            set {
                this.data_currentField = value;
            }
        }
        public EntityItemIntType data_max {
            get {
                return this.data_maxField;
            }
            set {
                this.data_maxField = value;
            }
        }
        public EntityItemIntType stack_current {
            get {
                return this.stack_currentField;
            }
            set {
                this.stack_currentField = value;
            }
        }
        public EntityItemIntType stack_max {
            get {
                return this.stack_maxField;
            }
            set {
                this.stack_maxField = value;
            }
        }
        public EntityItemIntType core_current {
            get {
                return this.core_currentField;
            }
            set {
                this.core_currentField = value;
            }
        }
        public EntityItemIntType core_max {
            get {
                return this.core_maxField;
            }
            set {
                this.core_maxField = value;
            }
        }
        public EntityItemIntType rss_current {
            get {
                return this.rss_currentField;
            }
            set {
                this.rss_currentField = value;
            }
        }
        public EntityItemIntType rss_max {
            get {
                return this.rss_maxField;
            }
            set {
                this.rss_maxField = value;
            }
        }
        public EntityItemIntType memlock_current {
            get {
                return this.memlock_currentField;
            }
            set {
                this.memlock_currentField = value;
            }
        }
        public EntityItemIntType memlock_max {
            get {
                return this.memlock_maxField;
            }
            set {
                this.memlock_maxField = value;
            }
        }
        public EntityItemIntType maxproc_current {
            get {
                return this.maxproc_currentField;
            }
            set {
                this.maxproc_currentField = value;
            }
        }
        public EntityItemIntType maxproc_max {
            get {
                return this.maxproc_maxField;
            }
            set {
                this.maxproc_maxField = value;
            }
        }
        public EntityItemIntType maxfiles_current {
            get {
                return this.maxfiles_currentField;
            }
            set {
                this.maxfiles_currentField = value;
            }
        }
        public EntityItemIntType maxfiles_max {
            get {
                return this.maxfiles_maxField;
            }
            set {
                this.maxfiles_maxField = value;
            }
        }
    }

}

