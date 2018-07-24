using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class cmdlet_state : StateType {
        private EntityStateStringType module_nameField;
        private EntityStateGUIDType module_idField;
        private EntityStateVersionType module_versionField;
        private EntityStateCmdletVerbType verbField;
        private EntityStateStringType nounField;
        private EntityStateRecordType parametersField;
        private EntityStateRecordType selectField;
        private EntityStateRecordType valueField;
        public EntityStateStringType module_name {
            get {
                return this.module_nameField;
            }
            set {
                this.module_nameField = value;
            }
        }
        public EntityStateGUIDType module_id {
            get {
                return this.module_idField;
            }
            set {
                this.module_idField = value;
            }
        }
        public EntityStateVersionType module_version {
            get {
                return this.module_versionField;
            }
            set {
                this.module_versionField = value;
            }
        }
        public EntityStateCmdletVerbType verb {
            get {
                return this.verbField;
            }
            set {
                this.verbField = value;
            }
        }
        public EntityStateStringType noun {
            get {
                return this.nounField;
            }
            set {
                this.nounField = value;
            }
        }
        public EntityStateRecordType parameters {
            get {
                return this.parametersField;
            }
            set {
                this.parametersField = value;
            }
        }
        public EntityStateRecordType select {
            get {
                return this.selectField;
            }
            set {
                this.selectField = value;
            }
        }
        public EntityStateRecordType value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

