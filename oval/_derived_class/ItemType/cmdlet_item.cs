using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class cmdlet_item : ItemType {
        private EntityItemStringType module_nameField;
        private EntityItemGUIDType module_idField;
        private EntityItemVersionType module_versionField;
        private EntityItemCmdletVerbType verbField;
        private EntityItemStringType nounField;
        private EntityItemRecordType parametersField;
        private EntityItemRecordType selectField;
        private EntityItemRecordType[] valueField;
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType module_name {
            get {
                return this.module_nameField;
            }
            set {
                this.module_nameField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemGUIDType module_id {
            get {
                return this.module_idField;
            }
            set {
                this.module_idField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemVersionType module_version {
            get {
                return this.module_versionField;
            }
            set {
                this.module_versionField = value;
            }
        }
        public EntityItemCmdletVerbType verb {
            get {
                return this.verbField;
            }
            set {
                this.verbField = value;
            }
        }
        public EntityItemStringType noun {
            get {
                return this.nounField;
            }
            set {
                this.nounField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemRecordType parameters {
            get {
                return this.parametersField;
            }
            set {
                this.parametersField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemRecordType select {
            get {
                return this.selectField;
            }
            set {
                this.selectField = value;
            }
        }
        [XmlElementAttribute("value")]
        public EntityItemRecordType[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

