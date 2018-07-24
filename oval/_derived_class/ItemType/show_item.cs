using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#junos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#junos", IsNullable=false)]
    public class show_item : ItemType {
        private EntityItemStringType subcommandField;
        private EntityItemStringType valueField;
        public EntityItemStringType subcommand {
            get {
                return this.subcommandField;
            }
            set {
                this.subcommandField = value;
            }
        }
        public EntityItemStringType value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

