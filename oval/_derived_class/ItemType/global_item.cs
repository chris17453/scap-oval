using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios", IsNullable=false)]
    public class global_item : ItemType {
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

