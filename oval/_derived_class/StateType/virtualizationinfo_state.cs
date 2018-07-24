using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris", IsNullable=false)]
    public class virtualizationinfo_state : StateType {
        private EntityStateStringType currentField;
        private EntityStateV12NEnvType supportedField;
        private EntityStateV12NEnvType parentField;
        private EntityStateLDOMRoleType ldomroleField;
        private EntityStateRecordType propertiesField;
        public EntityStateStringType current {
            get {
                return this.currentField;
            }
            set {
                this.currentField = value;
            }
        }
        public EntityStateV12NEnvType supported {
            get {
                return this.supportedField;
            }
            set {
                this.supportedField = value;
            }
        }
        public EntityStateV12NEnvType parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }
        [XmlElementAttribute("ldom-role")]
        public EntityStateLDOMRoleType ldomrole {
            get {
                return this.ldomroleField;
            }
            set {
                this.ldomroleField = value;
            }
        }
        public EntityStateRecordType properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }
    }

}

