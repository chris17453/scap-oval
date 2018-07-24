using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios", IsNullable=false)]
    public class snmp_item : ItemType {
        private EntityItemStringType access_listField;
        private EntityItemStringType community_nameField;
        public EntityItemStringType access_list {
            get {
                return this.access_listField;
            }
            set {
                this.access_listField = value;
            }
        }
        public EntityItemStringType community_name {
            get {
                return this.community_nameField;
            }
            set {
                this.community_nameField = value;
            }
        }
    }

}

