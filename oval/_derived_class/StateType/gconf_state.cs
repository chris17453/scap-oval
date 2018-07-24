using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IsNullable=false)]
    public class gconf_state : StateType {
        private EntityStateStringType keyField;
        private EntityStateStringType sourceField;
        private EntityStateGconfTypeType typeField;
        private EntityStateBoolType is_writableField;
        private EntityStateStringType mod_userField;
        private EntityStateIntType mod_timeField;
        private EntityStateBoolType is_defaultField;
        private EntityStateAnySimpleType valueField;
        public EntityStateStringType key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        public EntityStateStringType source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        public EntityStateGconfTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public EntityStateBoolType is_writable {
            get {
                return this.is_writableField;
            }
            set {
                this.is_writableField = value;
            }
        }
        public EntityStateStringType mod_user {
            get {
                return this.mod_userField;
            }
            set {
                this.mod_userField = value;
            }
        }
        public EntityStateIntType mod_time {
            get {
                return this.mod_timeField;
            }
            set {
                this.mod_timeField = value;
            }
        }
        public EntityStateBoolType is_default {
            get {
                return this.is_defaultField;
            }
            set {
                this.is_defaultField = value;
            }
        }
        public EntityStateAnySimpleType value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

