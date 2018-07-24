using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx", IsNullable=false)]
    public class visdkmanagedobject_state : StateType {
        private EntityStateStringType propertyField;
        private EntityStateAnySimpleType valueField;
        public EntityStateStringType property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
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

