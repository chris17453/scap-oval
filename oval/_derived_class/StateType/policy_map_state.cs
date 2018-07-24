using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa", IsNullable=false)]
    public class policy_map_state : StateType {
        private EntityStateStringType nameField;
        private EntityStateInspectionType type_inspectField;
        private EntityStateStringType parametersField;
        private EntityStateStringType match_actionField;
        private EntityStateStringType used_inField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateInspectionType type_inspect {
            get {
                return this.type_inspectField;
            }
            set {
                this.type_inspectField = value;
            }
        }
        public EntityStateStringType parameters {
            get {
                return this.parametersField;
            }
            set {
                this.parametersField = value;
            }
        }
        public EntityStateStringType match_action {
            get {
                return this.match_actionField;
            }
            set {
                this.match_actionField = value;
            }
        }
        public EntityStateStringType used_in {
            get {
                return this.used_inField;
            }
            set {
                this.used_inField = value;
            }
        }
    }

}

