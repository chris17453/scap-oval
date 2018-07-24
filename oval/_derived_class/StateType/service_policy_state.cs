using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa", IsNullable=false)]
    public class service_policy_state : StateType {
        private EntityStateStringType nameField;
        private EntityStateApplyServicePolicyType appliedField;
        private EntityStateStringType interfaceField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateApplyServicePolicyType applied {
            get {
                return this.appliedField;
            }
            set {
                this.appliedField = value;
            }
        }
        public EntityStateStringType @interface {
            get {
                return this.interfaceField;
            }
            set {
                this.interfaceField = value;
            }
        }
    }

}

