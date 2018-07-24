using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#hpux")]
    [XmlRootAttribute("patch_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#hpux", IsNullable=false)]
    public class patch_item2 : ItemType {
        private EntityItemStringType patch_nameField;
        private EntityItemStringType swtypeField;
        private EntityItemStringType area_patchedField;
        private EntityItemStringType patch_baseField;
        public EntityItemStringType patch_name {
            get {
                return this.patch_nameField;
            }
            set {
                this.patch_nameField = value;
            }
        }
        public EntityItemStringType swtype {
            get {
                return this.swtypeField;
            }
            set {
                this.swtypeField = value;
            }
        }
        public EntityItemStringType area_patched {
            get {
                return this.area_patchedField;
            }
            set {
                this.area_patchedField = value;
            }
        }
        public EntityItemStringType patch_base {
            get {
                return this.patch_baseField;
            }
            set {
                this.patch_baseField = value;
            }
        }
    }

}

