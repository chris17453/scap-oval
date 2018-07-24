using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public class virtualizationinfo_item : ItemType {
        private EntityItemStringType currentField;
        private EntityItemV12NEnvType[] supportedField;
        private EntityItemV12NEnvType parentField;
        private EntityItemLDOMRoleType[] ldomroleField;
        private EntityItemRecordType propertiesField;
        public EntityItemStringType current {
            get {
                return this.currentField;
            }
            set {
                this.currentField = value;
            }
        }
        [XmlElementAttribute("supported")]
        public EntityItemV12NEnvType[] supported {
            get {
                return this.supportedField;
            }
            set {
                this.supportedField = value;
            }
        }
        public EntityItemV12NEnvType parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }
        [XmlElementAttribute("ldom-role")]
        public EntityItemLDOMRoleType[] ldomrole {
            get {
                return this.ldomroleField;
            }
            set {
                this.ldomroleField = value;
            }
        }
        public EntityItemRecordType properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }
    }

}

