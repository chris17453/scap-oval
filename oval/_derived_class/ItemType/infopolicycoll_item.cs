using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class infopolicycoll_item : ItemType {
        private EntityItemStringType sitecollectionurlField;
        private EntityItemStringType id1Field;
        private EntityItemStringType nameField;
        private EntityItemStringType descriptionField;
        private EntityItemStringType longdescriptionField;
        public EntityItemStringType sitecollectionurl {
            get {
                return this.sitecollectionurlField;
            }
            set {
                this.sitecollectionurlField = value;
            }
        }
        [XmlElementAttribute("id")]
        public EntityItemStringType id1 {
            get {
                return this.id1Field;
            }
            set {
                this.id1Field = value;
            }
        }
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemStringType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        public EntityItemStringType longdescription {
            get {
                return this.longdescriptionField;
            }
            set {
                this.longdescriptionField = value;
            }
        }
    }

}

