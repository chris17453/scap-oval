using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class spjobdefinition_state : StateType {
        private EntityStateStringType webappuriField;
        private EntityStateStringType displaynameField;
        private EntityStateBoolType isdisabledField;
        private EntityStateBoolType retryField;
        private EntityStateStringType titleField;
        public EntityStateStringType webappuri {
            get {
                return this.webappuriField;
            }
            set {
                this.webappuriField = value;
            }
        }
        public EntityStateStringType displayname {
            get {
                return this.displaynameField;
            }
            set {
                this.displaynameField = value;
            }
        }
        public EntityStateBoolType isdisabled {
            get {
                return this.isdisabledField;
            }
            set {
                this.isdisabledField = value;
            }
        }
        public EntityStateBoolType retry {
            get {
                return this.retryField;
            }
            set {
                this.retryField = value;
            }
        }
        public EntityStateStringType title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
    }

}

