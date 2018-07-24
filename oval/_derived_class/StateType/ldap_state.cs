using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent", IsNullable=false)]
    public class ldap_state : StateType {
        private EntityStateStringType suffixField;
        private EntityStateStringType relative_dnField;
        private EntityStateStringType attributeField;
        private EntityStateStringType object_classField;
        private EntityStateLdaptypeType ldaptypeField;
        private EntityStateAnySimpleType valueField;
        public EntityStateStringType suffix {
            get {
                return this.suffixField;
            }
            set {
                this.suffixField = value;
            }
        }
        public EntityStateStringType relative_dn {
            get {
                return this.relative_dnField;
            }
            set {
                this.relative_dnField = value;
            }
        }
        public EntityStateStringType attribute {
            get {
                return this.attributeField;
            }
            set {
                this.attributeField = value;
            }
        }
        public EntityStateStringType object_class {
            get {
                return this.object_classField;
            }
            set {
                this.object_classField = value;
            }
        }
        public EntityStateLdaptypeType ldaptype {
            get {
                return this.ldaptypeField;
            }
            set {
                this.ldaptypeField = value;
            }
        }
        public EntityStateAnySimpleType value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

