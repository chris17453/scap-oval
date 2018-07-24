using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class systemdunitproperty_state : StateType {
        private EntityStateStringType unitField;
        private EntityStateStringType propertyField;
        private EntityStateAnySimpleType valueField;
        public EntityStateStringType unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }
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

