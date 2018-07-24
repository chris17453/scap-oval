using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios", IsNullable=false)]
    public class tclsh_item : ItemType {
        private EntityItemBoolType availableField;
        public EntityItemBoolType available {
            get {
                return this.availableField;
            }
            set {
                this.availableField = value;
            }
        }
    }

}

