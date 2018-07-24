using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class softwareupdate_item : ItemType {
        private EntityItemBoolType scheduleField;
        private EntityItemStringType[] software_titleField;
        public EntityItemBoolType schedule {
            get {
                return this.scheduleField;
            }
            set {
                this.scheduleField = value;
            }
        }
        [XmlElementAttribute("software_title")]
        public EntityItemStringType[] software_title {
            get {
                return this.software_titleField;
            }
            set {
                this.software_titleField = value;
            }
        }
    }

}

