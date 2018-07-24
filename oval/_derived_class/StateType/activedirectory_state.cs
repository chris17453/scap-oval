using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class activedirectory_state : StateType {
        private EntityStateNamingContextType naming_contextField;
        private EntityStateStringType relative_dnField;
        private EntityStateStringType attributeField;
        private EntityStateStringType object_classField;
        private EntityStateAdstypeType adstypeField;
        private EntityStateAnySimpleType valueField;
        public EntityStateNamingContextType naming_context {
            get {
                return this.naming_contextField;
            }
            set {
                this.naming_contextField = value;
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
        public EntityStateAdstypeType adstype {
            get {
                return this.adstypeField;
            }
            set {
                this.adstypeField = value;
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

