using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class spsite_item : ItemType {
        private EntityItemStringType sitecollectionurlField;
        private EntityItemStringType quotanameField;
        private EntityItemStringType urlField;
        public EntityItemStringType sitecollectionurl {
            get {
                return this.sitecollectionurlField;
            }
            set {
                this.sitecollectionurlField = value;
            }
        }
        public EntityItemStringType quotaname {
            get {
                return this.quotanameField;
            }
            set {
                this.quotanameField = value;
            }
        }
        public EntityItemStringType url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
    }

}

