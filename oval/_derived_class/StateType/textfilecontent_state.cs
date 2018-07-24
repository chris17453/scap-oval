using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent", IsNullable=false)]
    public class textfilecontent_state : StateType {
        private EntityStateStringType pathField;
        private EntityStateStringType filenameField;
        private EntityStateStringType lineField;
        private EntityStateAnySimpleType subexpressionField;
        private EntityStateWindowsViewType windows_viewField;
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
        public EntityStateStringType line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }
        public EntityStateAnySimpleType subexpression {
            get {
                return this.subexpressionField;
            }
            set {
                this.subexpressionField = value;
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

