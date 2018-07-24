using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class sccs_item : ItemType {
        private EntityItemStringType filepathField;
        private EntityItemStringType pathField;
        private EntityItemStringType filenameField;
        private EntityItemStringType module_nameField;
        private EntityItemStringType module_typeField;
        private EntityItemStringType releaseField;
        private EntityItemStringType levelField;
        private EntityItemStringType branchField;
        private EntityItemStringType sequenceField;
        private EntityItemStringType what_stringField;
        public EntityItemStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
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
        public EntityItemStringType filename {
            get {
                return this.filenameField;
            }
            set {
                this.filenameField = value;
            }
        }
        public EntityItemStringType module_name {
            get {
                return this.module_nameField;
            }
            set {
                this.module_nameField = value;
            }
        }
        public EntityItemStringType module_type {
            get {
                return this.module_typeField;
            }
            set {
                this.module_typeField = value;
            }
        }
        public EntityItemStringType release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        public EntityItemStringType level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
        public EntityItemStringType branch {
            get {
                return this.branchField;
            }
            set {
                this.branchField = value;
            }
        }
        public EntityItemStringType sequence {
            get {
                return this.sequenceField;
            }
            set {
                this.sequenceField = value;
            }
        }
        public EntityItemStringType what_string {
            get {
                return this.what_stringField;
            }
            set {
                this.what_stringField = value;
            }
        }
    }

}

