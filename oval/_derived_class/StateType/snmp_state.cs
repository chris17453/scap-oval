using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class snmp_state : StateType {
        private EntityStateStringType access_listField;
        private EntityStateStringType community_nameField;
        public EntityStateStringType access_list {
            get {
                return this.access_listField;
            }
            set {
                this.access_listField = value;
            }
        }
        public EntityStateStringType community_name {
            get {
                return this.community_nameField;
            }
            set {
                this.community_nameField = value;
            }
        }
    }

}

