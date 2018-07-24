using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa", IsNullable=false)]
    public class class_map_state : StateType {
        private EntityStateStringType nameField;
        private EntityStateClassMapType typeField;
        private EntityStateInspectionType type_inspectField;
        private EntityStateMatchType match_all_anyField;
        private EntityStateStringType matchField;
        private EntityStateStringType used_in_class_mapField;
        private EntityStateStringType used_in_policy_mapField;
        private EntityStateStringType policy_map_actionField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateClassMapType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
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
        public EntityStateMatchType match_all_any {
            get {
                return this.match_all_anyField;
            }
            set {
                this.match_all_anyField = value;
            }
        }
        public EntityStateStringType match {
            get {
                return this.matchField;
            }
            set {
                this.matchField = value;
            }
        }
        public EntityStateStringType used_in_class_map {
            get {
                return this.used_in_class_mapField;
            }
            set {
                this.used_in_class_mapField = value;
            }
        }
        public EntityStateStringType used_in_policy_map {
            get {
                return this.used_in_policy_mapField;
            }
            set {
                this.used_in_policy_mapField = value;
            }
        }
        public EntityStateStringType policy_map_action {
            get {
                return this.policy_map_actionField;
            }
            set {
                this.policy_map_actionField = value;
            }
        }
    }

}

