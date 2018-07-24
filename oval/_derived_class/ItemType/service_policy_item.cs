using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa", IsNullable=false)]
    public class service_policy_item : ItemType {
        private EntityItemStringType nameField;
        private EntityItemApplyServicePolicyType appliedField;
        private EntityItemStringType interfaceField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemApplyServicePolicyType applied {
            get {
                return this.appliedField;
            }
            set {
                this.appliedField = value;
            }
        }
        public EntityItemStringType @interface {
            get {
                return this.interfaceField;
            }
            set {
                this.interfaceField = value;
            }
        }
    }

}

