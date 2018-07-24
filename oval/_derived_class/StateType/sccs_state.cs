using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IsNullable=false)]
    public class sccs_state : StateType {
        private EntityStateStringType filepathField;
        private EntityStateStringType pathField;
        private EntityStateStringType filenameField;
        private EntityStateStringType module_nameField;
        private EntityStateStringType module_typeField;
        private EntityStateStringType releaseField;
        private EntityStateStringType levelField;
        private EntityStateStringType branchField;
        private EntityStateStringType sequenceField;
        private EntityStateStringType what_stringField;
        public EntityStateStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
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
        public EntityStateStringType filename {
            get {
                return this.filenameField;
            }
            set {
                this.filenameField = value;
            }
        }
        public EntityStateStringType module_name {
            get {
                return this.module_nameField;
            }
            set {
                this.module_nameField = value;
            }
        }
        public EntityStateStringType module_type {
            get {
                return this.module_typeField;
            }
            set {
                this.module_typeField = value;
            }
        }
        public EntityStateStringType release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        public EntityStateStringType level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
        public EntityStateStringType branch {
            get {
                return this.branchField;
            }
            set {
                this.branchField = value;
            }
        }
        public EntityStateStringType sequence {
            get {
                return this.sequenceField;
            }
            set {
                this.sequenceField = value;
            }
        }
        public EntityStateStringType what_string {
            get {
                return this.what_stringField;
            }
            set {
                this.what_stringField = value;
            }
        }
    }

}

