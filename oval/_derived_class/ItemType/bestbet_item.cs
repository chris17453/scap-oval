using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class bestbet_item : ItemType {
        private EntityItemStringType sitecollectionurlField;
        private EntityItemStringType bestbeturlField;
        private EntityItemStringType titleField;
        private EntityItemStringType descriptionField;
        public EntityItemStringType sitecollectionurl {
            get {
                return this.sitecollectionurlField;
            }
            set {
                this.sitecollectionurlField = value;
            }
        }
        public EntityItemStringType bestbeturl {
            get {
                return this.bestbeturlField;
            }
            set {
                this.bestbeturlField = value;
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
        public EntityItemStringType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }

}

