using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent", IsNullable=false)]
    public class filehash_state : StateType {
        private EntityStateStringType filepathField;
        private EntityStateStringType pathField;
        private EntityStateStringType filenameField;
        private EntityStateStringType md5Field;
        private EntityStateStringType sha1Field;
        private EntityStateWindowsViewType windows_viewField;
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
        public EntityStateStringType md5 {
            get {
                return this.md5Field;
            }
            set {
                this.md5Field = value;
            }
        }
        public EntityStateStringType sha1 {
            get {
                return this.sha1Field;
            }
            set {
                this.sha1Field = value;
            }
        }
        public EntityStateWindowsViewType windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

