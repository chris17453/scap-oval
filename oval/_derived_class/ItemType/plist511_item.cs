using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class plist511_item : ItemType {
        private EntityItemStringType app_idField;
        private EntityItemStringType filepathField;
        private EntityItemStringType xpathField;
        private EntityItemAnySimpleType[] value_ofField;
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
        public EntityItemStringType xpath {
            get {
                return this.xpathField;
            }
            set {
                this.xpathField = value;
            }
        }
        [XmlElementAttribute("value_of")]
        public EntityItemAnySimpleType[] value_of {
            get {
                return this.value_ofField;
            }
            set {
                this.value_ofField = value;
            }
        }
    }

}

