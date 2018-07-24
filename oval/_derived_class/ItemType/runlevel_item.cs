using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class runlevel_item : ItemType {
        private EntityItemStringType service_nameField;
        private EntityItemStringType runlevelField;
        private EntityItemBoolType startField;
        private EntityItemBoolType killField;
        public EntityItemStringType service_name {
            get {
                return this.service_nameField;
            }
            set {
                this.service_nameField = value;
            }
        }
        public EntityItemStringType runlevel {
            get {
                return this.runlevelField;
            }
            set {
                this.runlevelField = value;
            }
        }
        public EntityItemBoolType start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
            }
        }
        public EntityItemBoolType kill {
            get {
                return this.killField;
            }
            set {
                this.killField = value;
            }
        }
    }

}

