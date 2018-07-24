using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class userright_state : StateType {
        private EntityStateUserRightType userrightField;
        private EntityStateStringType trustee_nameField;
        private EntityStateStringType trustee_sidField;
        public EntityStateUserRightType userright {
            get {
                return this.userrightField;
            }
            set {
                this.userrightField = value;
            }
        }
        public EntityStateStringType trustee_name {
            get {
                return this.trustee_nameField;
            }
            set {
                this.trustee_nameField = value;
            }
        }
        public EntityStateStringType trustee_sid {
            get {
                return this.trustee_sidField;
            }
            set {
                this.trustee_sidField = value;
            }
        }
    }

}

