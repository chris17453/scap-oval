using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe")]
    [XmlRootAttribute("snmpview_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe", IsNullable=false)]
    public class snmpview_state1 : StateType {
        private EntityStateStringType nameField;
        private EntityStateStringType mib_familyField;
        private EntityStateBoolType includeField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateStringType mib_family {
            get {
                return this.mib_familyField;
            }
            set {
                this.mib_familyField = value;
            }
        }
        public EntityStateBoolType include {
            get {
                return this.includeField;
            }
            set {
                this.includeField = value;
            }
        }
    }

}

