using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class group_item : ItemType {
        private EntityItemStringType groupField;
        private EntityItemStringType[] userField;
        private EntityItemStringType[] subgroupField;
        public EntityItemStringType group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        [XmlElementAttribute("user")]
        public EntityItemStringType[] user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
        [XmlElementAttribute("subgroup")]
        public EntityItemStringType[] subgroup {
            get {
                return this.subgroupField;
            }
            set {
                this.subgroupField = value;
            }
        }
    }

}

