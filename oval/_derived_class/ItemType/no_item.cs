using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#aix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#aix", IsNullable=false)]
    public class no_item : ItemType {
        private EntityItemStringType tunableField;
        private EntityItemAnySimpleType valueField;
        public EntityItemStringType tunable {
            get {
                return this.tunableField;
            }
            set {
                this.tunableField = value;
            }
        }
        public EntityItemAnySimpleType value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

