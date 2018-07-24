using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#independent", IsNullable=false)]
    public class ldap57_item : ItemType {
        private EntityItemStringType suffixField;
        private EntityItemStringType relative_dnField;
        private EntityItemStringType attributeField;
        private EntityItemStringType object_classField;
        private EntityItemLdaptypeType ldaptypeField;
        private EntityItemRecordType[] valueField;
        public EntityItemStringType suffix {
            get {
                return this.suffixField;
            }
            set {
                this.suffixField = value;
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
        public EntityItemLdaptypeType ldaptype {
            get {
                return this.ldaptypeField;
            }
            set {
                this.ldaptypeField = value;
            }
        }
        [XmlElementAttribute("value")]
        public EntityItemRecordType[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

