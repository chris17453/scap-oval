using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class registry_state : StateType {
        private EntityStateRegistryHiveType hiveField;
        private EntityStateStringType keyField;
        private EntityStateStringType nameField;
        private EntityStateIntType last_write_timeField;
        private EntityStateRegistryTypeType typeField;
        private EntityStateAnySimpleType valueField;
        private EntityStateAnySimpleType expanded_valueField;
        private EntityStateWindowsViewType1 windows_viewField;
        public EntityStateRegistryHiveType hive {
            get {
                return this.hiveField;
            }
            set {
                this.hiveField = value;
            }
        }
        public EntityStateStringType key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateIntType last_write_time {
            get {
                return this.last_write_timeField;
            }
            set {
                this.last_write_timeField = value;
            }
        }
        public EntityStateRegistryTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
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
        public EntityStateAnySimpleType expanded_value {
            get {
                return this.expanded_valueField;
            }
            set {
                this.expanded_valueField = value;
            }
        }
        public EntityStateWindowsViewType1 windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

