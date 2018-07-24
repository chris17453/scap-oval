using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#esx")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#esx", IsNullable=false)]
    public class visdkmanagedobject_item : ItemType {
        private EntityItemStringType propertyField;
        private EntityItemAnySimpleType[] valueField;
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

