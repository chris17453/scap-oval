using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class sid_sid_state : StateType {
        private EntityStateStringType trustee_sidField;
        private EntityStateStringType trustee_nameField;
        private EntityStateStringType trustee_domainField;
        public EntityStateStringType trustee_sid {
            get {
                return this.trustee_sidField;
            }
            set {
                this.trustee_sidField = value;
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
        public EntityStateStringType trustee_domain {
            get {
                return this.trustee_domainField;
            }
            set {
                this.trustee_domainField = value;
            }
        }
    }

}

