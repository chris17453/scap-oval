using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class gconf_item : ItemType {
        private EntityItemStringType keyField;
        private EntityItemStringType sourceField;
        private EntityItemGconfTypeType typeField;
        private EntityItemBoolType is_writableField;
        private EntityItemStringType mod_userField;
        private EntityItemIntType mod_timeField;
        private EntityItemBoolType is_defaultField;
        private EntityItemAnySimpleType[] valueField;
        public EntityItemStringType key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        public EntityItemGconfTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public EntityItemBoolType is_writable {
            get {
                return this.is_writableField;
            }
            set {
                this.is_writableField = value;
            }
        }
        public EntityItemStringType mod_user {
            get {
                return this.mod_userField;
            }
            set {
                this.mod_userField = value;
            }
        }
        public EntityItemIntType mod_time {
            get {
                return this.mod_timeField;
            }
            set {
                this.mod_timeField = value;
            }
        }
        public EntityItemBoolType is_default {
            get {
                return this.is_defaultField;
            }
            set {
                this.is_defaultField = value;
            }
        }
        [XmlElementAttribute("value")]
        public EntityItemAnySimpleType[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

