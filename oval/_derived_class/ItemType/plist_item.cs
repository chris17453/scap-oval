using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class plist_item : ItemType {
        private EntityItemStringType keyField;
        private EntityItemStringType app_idField;
        private EntityItemStringType filepathField;
        private EntityItemIntType instanceField;
        private EntityItemPlistTypeType typeField;
        private EntityItemAnySimpleType[] valueField;
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        public EntityItemStringType app_id {
            get {
                return this.app_idField;
            }
            set {
                this.app_idField = value;
            }
        }
        public EntityItemStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
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
        public EntityItemPlistTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        [XmlElementAttribute("value")]
        public EntityItemAnySimpleType[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

