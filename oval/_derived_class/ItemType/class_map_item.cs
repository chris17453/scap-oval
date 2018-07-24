using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa", IsNullable=false)]
    public class class_map_item : ItemType {
        private EntityItemStringType nameField;
        private EntityItemClassMapType typeField;
        private EntityItemInspectionType type_inspectField;
        private EntityItemMatchType match_all_anyField;
        private EntityItemStringType[] matchField;
        private EntityItemStringType[] used_in_class_mapField;
        private EntityItemStringType used_in_policy_mapField;
        private EntityItemStringType[] policy_map_actionField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemClassMapType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
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
        public EntityItemMatchType match_all_any {
            get {
                return this.match_all_anyField;
            }
            set {
                this.match_all_anyField = value;
            }
        }
        [XmlElementAttribute("match")]
        public EntityItemStringType[] match {
            get {
                return this.matchField;
            }
            set {
                this.matchField = value;
            }
        }
        [XmlElementAttribute("used_in_class_map")]
        public EntityItemStringType[] used_in_class_map {
            get {
                return this.used_in_class_mapField;
            }
            set {
                this.used_in_class_mapField = value;
            }
        }
        public EntityItemStringType used_in_policy_map {
            get {
                return this.used_in_policy_mapField;
            }
            set {
                this.used_in_policy_mapField = value;
            }
        }
        [XmlElementAttribute("policy_map_action")]
        public EntityItemStringType[] policy_map_action {
            get {
                return this.policy_map_actionField;
            }
            set {
                this.policy_map_actionField = value;
            }
        }
    }

}

