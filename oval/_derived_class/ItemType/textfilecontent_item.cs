using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#independent", IsNullable=false)]
    public class textfilecontent_item : ItemType {
        private EntityItemStringType filepathField;
        private EntityItemStringType pathField;
        private EntityItemStringType filenameField;
        private EntityItemStringType patternField;
        private EntityItemIntType instanceField;
        private EntityItemStringType lineField;
        private EntityItemAnySimpleType textField;
        private EntityItemAnySimpleType[] subexpressionField;
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
        public EntityItemStringType pattern {
            get {
                return this.patternField;
            }
            set {
                this.patternField = value;
            }
        }
        public EntityItemIntType instance {
            get {
                return this.instanceField;
            }
            set {
                this.instanceField = value;
            }
        }
        public EntityItemStringType line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }
        public EntityItemAnySimpleType text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        [XmlElementAttribute("subexpression")]
        public EntityItemAnySimpleType[] subexpression {
            get {
                return this.subexpressionField;
            }
            set {
                this.subexpressionField = value;
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

