using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#esx")]
    [XmlRootAttribute("patch_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#esx", IsNullable=false)]
    public class patch_item1 : ItemType {
        private EntityItemStringType patch_numberField;
        private EntityItemStringType patch_nameField;
        private EntityItemIntType knowledge_base_idField;
        private EntityItemIntType bundle_idField;
        private EntityItemClassificationType classificationField;
        private EntityItemSupportLevelType support_levelField;
        private EntityItemBoolType status1Field;
        public EntityItemStringType patch_number {
            get {
                return this.patch_numberField;
            }
            set {
                this.patch_numberField = value;
            }
        }
        public EntityItemStringType patch_name {
            get {
                return this.patch_nameField;
            }
            set {
                this.patch_nameField = value;
            }
        }
        public EntityItemIntType knowledge_base_id {
            get {
                return this.knowledge_base_idField;
            }
            set {
                this.knowledge_base_idField = value;
            }
        }
        public EntityItemIntType bundle_id {
            get {
                return this.bundle_idField;
            }
            set {
                this.bundle_idField = value;
            }
        }
        public EntityItemClassificationType classification {
            get {
                return this.classificationField;
            }
            set {
                this.classificationField = value;
            }
        }
        public EntityItemSupportLevelType support_level {
            get {
                return this.support_levelField;
            }
            set {
                this.support_levelField = value;
            }
        }
        [XmlElementAttribute("status")]
        public EntityItemBoolType status1 {
            get {
                return this.status1Field;
            }
            set {
                this.status1Field = value;
            }
        }
    }

}

