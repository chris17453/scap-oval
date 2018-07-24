using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa", IsNullable=false)]
    public class policy_map_item : ItemType {
        private EntityItemStringType nameField;
        private EntityItemInspectionType type_inspectField;
        private EntityItemStringType[] parametersField;
        private EntityItemStringType[] match_actionField;
        private EntityItemStringType used_inField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemInspectionType type_inspect {
            get {
                return this.type_inspectField;
            }
            set {
                this.type_inspectField = value;
            }
        }
        [XmlElementAttribute("parameters")]
        public EntityItemStringType[] parameters {
            get {
                return this.parametersField;
            }
            set {
                this.parametersField = value;
            }
        }
        [XmlElementAttribute("match_action")]
        public EntityItemStringType[] match_action {
            get {
                return this.match_actionField;
            }
            set {
                this.match_actionField = value;
            }
        }
        public EntityItemStringType used_in {
            get {
                return this.used_inField;
            }
            set {
                this.used_inField = value;
            }
        }
    }

}

