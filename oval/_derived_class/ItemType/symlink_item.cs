using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class symlink_item : ItemType {
        private EntityItemStringType filepathField;
        private EntityItemStringType canonical_pathField;
        public EntityItemStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
            }
        }
        public EntityItemStringType canonical_path {
            get {
                return this.canonical_pathField;
            }
            set {
                this.canonical_pathField = value;
            }
        }
    }

}

