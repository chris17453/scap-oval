using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa", IsNullable=false)]
    public class snmp_user_item : ItemType {
        private EntityItemStringType nameField;
        private EntityItemStringType groupField;
        private EntityItemSNMPPrivStringType2 privField;
        private EntityItemSNMPAuthStringType2 authField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemStringType group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        public EntityItemSNMPPrivStringType2 priv {
            get {
                return this.privField;
            }
            set {
                this.privField = value;
            }
        }
        public EntityItemSNMPAuthStringType2 auth {
            get {
                return this.authField;
            }
            set {
                this.authField = value;
            }
        }
    }

}

