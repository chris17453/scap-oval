using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#hpux")]
    [XmlRootAttribute("ndd_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#hpux", IsNullable=false)]
    public class ndd_item1 : ItemType {
        private EntityItemStringType deviceField;
        private EntityItemStringType parameterField;
        private EntityItemAnySimpleType valueField;
        public EntityItemStringType device {
            get {
                return this.deviceField;
            }
            set {
                this.deviceField = value;
            }
        }
        public EntityItemStringType parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
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

