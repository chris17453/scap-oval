using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class user_sid_item : ItemType {
        private EntityItemStringType user_sidField;
        private EntityItemBoolType enabledField;
        private EntityItemStringType[] group_sidField;
        private EntityItemIntType last_logonField;
        public EntityItemStringType user_sid {
            get {
                return this.user_sidField;
            }
            set {
                this.user_sidField = value;
            }
        }
        public EntityItemBoolType enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        [XmlElementAttribute("group_sid")]
        public EntityItemStringType[] group_sid {
            get {
                return this.group_sidField;
            }
            set {
                this.group_sidField = value;
            }
        }
        public EntityItemIntType last_logon {
            get {
                return this.last_logonField;
            }
            set {
                this.last_logonField = value;
            }
        }
    }

}

