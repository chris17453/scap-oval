using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx", IsNullable=false)]
    public class patch56_state : StateType {
        private EntityStateStringType patch_nameField;
        private EntityStateIntType knowledge_base_idField;
        private EntityStateIntType bundle_idField;
        private EntityStateClassificationType classificationField;
        private EntityStateSupportLevelType support_levelField;
        private EntityStateBoolType statusField;
        public EntityStateStringType patch_name {
            get {
                return this.patch_nameField;
            }
            set {
                this.patch_nameField = value;
            }
        }
        public EntityStateIntType knowledge_base_id {
            get {
                return this.knowledge_base_idField;
            }
            set {
                this.knowledge_base_idField = value;
            }
        }
        public EntityStateIntType bundle_id {
            get {
                return this.bundle_idField;
            }
            set {
                this.bundle_idField = value;
            }
        }
        public EntityStateClassificationType classification {
            get {
                return this.classificationField;
            }
            set {
                this.classificationField = value;
            }
        }
        public EntityStateSupportLevelType support_level {
            get {
                return this.support_levelField;
            }
            set {
                this.support_levelField = value;
            }
        }
        public EntityStateBoolType status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }

}

