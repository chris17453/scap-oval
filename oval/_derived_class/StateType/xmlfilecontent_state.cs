using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent", IsNullable=false)]
    public class xmlfilecontent_state : StateType {
        private EntityStateStringType filepathField;
        private EntityStateStringType pathField;
        private EntityStateStringType filenameField;
        private EntityStateStringType xpathField;
        private EntityStateAnySimpleType value_ofField;
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
        public EntityStateStringType xpath {
            get {
                return this.xpathField;
            }
            set {
                this.xpathField = value;
            }
        }
        public EntityStateAnySimpleType value_of {
            get {
                return this.value_ofField;
            }
            set {
                this.value_ofField = value;
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

