using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class registry_item : ItemType {
        private EntityItemRegistryHiveType hiveField;
        private EntityItemStringType keyField;
        private EntityItemStringType nameField;
        private EntityItemIntType last_write_timeField;
        private EntityItemRegistryTypeType typeField;
        private EntityItemAnySimpleType[] valueField;
        private EntityItemAnySimpleType expanded_valueField;
        private EntityItemWindowsViewType1 windows_viewField;
        public EntityItemRegistryHiveType hive {
            get {
                return this.hiveField;
            }
            set {
                this.hiveField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemIntType last_write_time {
            get {
                return this.last_write_timeField;
            }
            set {
                this.last_write_timeField = value;
            }
        }
        public EntityItemRegistryTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
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
        public EntityItemAnySimpleType expanded_value {
            get {
                return this.expanded_valueField;
            }
            set {
                this.expanded_valueField = value;
            }
        }
        public EntityItemWindowsViewType1 windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

