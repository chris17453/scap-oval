using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public class facet_item : ItemType {
        private EntityItemStringType pathField;
        private EntityItemStringType nameField;
        private EntityItemBoolType valueField;
        public EntityItemStringType path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemBoolType value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

