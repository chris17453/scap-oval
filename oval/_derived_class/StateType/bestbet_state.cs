using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class bestbet_state : StateType {
        private EntityStateStringType sitecollectionurlField;
        private EntityStateStringType bestbeturlField;
        private EntityStateStringType titleField;
        private EntityStateStringType descriptionField;
        public EntityStateStringType sitecollectionurl {
            get {
                return this.sitecollectionurlField;
            }
            set {
                this.sitecollectionurlField = value;
            }
        }
        public EntityStateStringType bestbeturl {
            get {
                return this.bestbeturlField;
            }
            set {
                this.bestbeturlField = value;
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
        public EntityStateStringType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }

}

