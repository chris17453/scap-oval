using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx")]
    [XmlRootAttribute("patch_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx", IsNullable=false)]
    public class patch_state1 : StateType {
        private EntityStateStringType patch_numberField;
        private EntityStateBoolType statusField;
        public EntityStateStringType patch_number {
            get {
                return this.patch_numberField;
            }
            set {
                this.patch_numberField = value;
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

