using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class userright_item : ItemType {
        private EntityItemUserRightType userrightField;
        private EntityItemStringType trustee_nameField;
        private EntityItemStringType trustee_sidField;
        public EntityItemUserRightType userright {
            get {
                return this.userrightField;
            }
            set {
                this.userrightField = value;
            }
        }
        public EntityItemStringType trustee_name {
            get {
                return this.trustee_nameField;
            }
            set {
                this.trustee_nameField = value;
            }
        }
        public EntityItemStringType trustee_sid {
            get {
                return this.trustee_sidField;
            }
            set {
                this.trustee_sidField = value;
            }
        }
    }

}

