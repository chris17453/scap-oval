using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe")]
    [XmlRootAttribute("global_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe", IsNullable=false)]
    public class global_item1 : ItemType {
        private EntityItemStringType global_commandField;
        public EntityItemStringType global_command {
            get {
                return this.global_commandField;
            }
            set {
                this.global_commandField = value;
            }
        }
    }

}

