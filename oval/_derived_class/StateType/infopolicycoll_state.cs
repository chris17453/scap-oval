using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class infopolicycoll_state : StateType {
        private EntityStateStringType sitecollectionurlField;
        private EntityStateStringType id1Field;
        private EntityStateStringType nameField;
        private EntityStateStringType descriptionField;
        private EntityStateStringType longdescriptionField;
        public EntityStateStringType sitecollectionurl {
            get {
                return this.sitecollectionurlField;
            }
            set {
                this.sitecollectionurlField = value;
            }
        }
        [XmlElementAttribute("id")]
        public EntityStateStringType id1 {
            get {
                return this.id1Field;
            }
            set {
                this.id1Field = value;
            }
        }
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateStringType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        public EntityStateStringType longdescription {
            get {
                return this.longdescriptionField;
            }
            set {
                this.longdescriptionField = value;
            }
        }
    }

}

