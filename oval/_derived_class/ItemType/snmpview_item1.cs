using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe")]
    [XmlRootAttribute("snmpview_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe", IsNullable=false)]
    public class snmpview_item1 : ItemType {
        private EntityItemStringType nameField;
        private EntityItemStringType mib_familyField;
        private EntityItemBoolType includeField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemStringType mib_family {
            get {
                return this.mib_familyField;
            }
            set {
                this.mib_familyField = value;
            }
        }
        public EntityItemBoolType include {
            get {
                return this.includeField;
            }
            set {
                this.includeField = value;
            }
        }
    }

}

