using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class corestorage_item : ItemType {
        private EntityItemStringType uuidField;
        private EntityItemStringType xpathField;
        private EntityItemAnySimpleType[] value_ofField;
        public EntityItemStringType uuid {
            get {
                return this.uuidField;
            }
            set {
                this.uuidField = value;
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

