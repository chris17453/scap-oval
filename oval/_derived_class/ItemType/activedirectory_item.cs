using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class activedirectory_item : ItemType {
        private EntityItemNamingContextType naming_contextField;
        private EntityItemStringType relative_dnField;
        private EntityItemStringType attributeField;
        private EntityItemStringType object_classField;
        private EntityItemAdstypeType adstypeField;
        private EntityItemAnySimpleType[] valueField;
        public EntityItemNamingContextType naming_context {
            get {
                return this.naming_contextField;
            }
            set {
                this.naming_contextField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType relative_dn {
            get {
                return this.relative_dnField;
            }
            set {
                this.relative_dnField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType attribute {
            get {
                return this.attributeField;
            }
            set {
                this.attributeField = value;
            }
        }
        public EntityItemStringType object_class {
            get {
                return this.object_classField;
            }
            set {
                this.object_classField = value;
            }
        }
        public EntityItemAdstypeType adstype {
            get {
                return this.adstypeField;
            }
            set {
                this.adstypeField = value;
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

