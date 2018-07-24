using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux", IsNullable=false)]
    public class systemdunitproperty_item : ItemType {
        private EntityItemStringType unitField;
        private EntityItemStringType propertyField;
        private EntityItemAnySimpleType[] valueField;
        public EntityItemStringType unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }
        public EntityItemStringType property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
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

