using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class group_sid_item : ItemType {
        private EntityItemStringType group_sidField;
        private EntityItemStringType[] user_sidField;
        private EntityItemStringType[] subgroup_sidField;
        public EntityItemStringType group_sid {
            get {
                return this.group_sidField;
            }
            set {
                this.group_sidField = value;
            }
        }
        [XmlElementAttribute("user_sid")]
        public EntityItemStringType[] user_sid {
            get {
                return this.user_sidField;
            }
            set {
                this.user_sidField = value;
            }
        }
        [XmlElementAttribute("subgroup_sid")]
        public EntityItemStringType[] subgroup_sid {
            get {
                return this.subgroup_sidField;
            }
            set {
                this.subgroup_sidField = value;
            }
        }
    }

}

