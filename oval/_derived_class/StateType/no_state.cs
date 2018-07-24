using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#aix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#aix", IsNullable=false)]
    public class no_state : StateType {
        private EntityStateStringType tunableField;
        private EntityStateAnySimpleType valueField;
        public EntityStateStringType tunable {
            get {
                return this.tunableField;
            }
            set {
                this.tunableField = value;
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

