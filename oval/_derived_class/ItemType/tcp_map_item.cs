using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa", IsNullable=false)]
    public class tcp_map_item : ItemType {
        private EntityItemStringType nameField;
        private EntityItemStringType[] optionsField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        [XmlElementAttribute("options")]
        public EntityItemStringType[] options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }
    }

}

