using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class spjobdefinition510_item : ItemType {
        private EntityItemStringType webappuriField;
        private EntityItemStringType displaynameField;
        private EntityItemBoolType isdisabledField;
        private EntityItemBoolType retryField;
        private EntityItemStringType titleField;
        public EntityItemStringType webappuri {
            get {
                return this.webappuriField;
            }
            set {
                this.webappuriField = value;
            }
        }
        public EntityItemStringType displayname {
            get {
                return this.displaynameField;
            }
            set {
                this.displaynameField = value;
            }
        }
        public EntityItemBoolType isdisabled {
            get {
                return this.isdisabledField;
            }
            set {
                this.isdisabledField = value;
            }
        }
        public EntityItemBoolType retry {
            get {
                return this.retryField;
            }
            set {
                this.retryField = value;
            }
        }
        public EntityItemStringType title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
    }

}

