using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#hpux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#hpux", IsNullable=false)]
    public class patch53_state : StateType {
        private EntityStateStringType swtypeField;
        private EntityStateStringType area_patchedField;
        private EntityStateStringType patch_baseField;
        public EntityStateStringType swtype {
            get {
                return this.swtypeField;
            }
            set {
                this.swtypeField = value;
            }
        }
        public EntityStateStringType area_patched {
            get {
                return this.area_patchedField;
            }
            set {
                this.area_patchedField = value;
            }
        }
        public EntityStateStringType patch_base {
            get {
                return this.patch_baseField;
            }
            set {
                this.patch_baseField = value;
            }
        }
    }

}

