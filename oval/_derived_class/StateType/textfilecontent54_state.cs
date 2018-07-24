using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent", IsNullable=false)]
    public class textfilecontent54_state : StateType {
        private EntityStateStringType filepathField;
        private EntityStateStringType pathField;
        private EntityStateStringType filenameField;
        private EntityStateStringType patternField;
        private EntityStateIntType instanceField;
        private EntityStateAnySimpleType textField;
        private EntityStateAnySimpleType subexpressionField;
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
        public EntityStateStringType pattern {
            get {
                return this.patternField;
            }
            set {
                this.patternField = value;
            }
        }
        public EntityStateIntType instance {
            get {
                return this.instanceField;
            }
            set {
                this.instanceField = value;
            }
        }
        public EntityStateAnySimpleType text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
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

