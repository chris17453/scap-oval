using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#independent", IsNullable=false)]
    public class filehash_item : ItemType {
        private EntityItemStringType filepathField;
        private EntityItemStringType pathField;
        private EntityItemStringType filenameField;
        private EntityItemStringType md5Field;
        private EntityItemStringType sha1Field;
        private EntityItemWindowsViewType windows_viewField;
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
        public EntityItemStringType md5 {
            get {
                return this.md5Field;
            }
            set {
                this.md5Field = value;
            }
        }
        public EntityItemStringType sha1 {
            get {
                return this.sha1Field;
            }
            set {
                this.sha1Field = value;
            }
        }
        public EntityItemWindowsViewType windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

