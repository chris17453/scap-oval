using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class spsite_state : StateType {
        private EntityStateStringType sitecollectionurlField;
        private EntityStateStringType quotanameField;
        private EntityStateStringType urlField;
        public EntityStateStringType sitecollectionurl {
            get {
                return this.sitecollectionurlField;
            }
            set {
                this.sitecollectionurlField = value;
            }
        }
        public EntityStateStringType quotaname {
            get {
                return this.quotanameField;
            }
            set {
                this.quotanameField = value;
            }
        }
        public EntityStateStringType url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
    }

}

