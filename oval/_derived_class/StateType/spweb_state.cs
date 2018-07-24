using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class spweb_state : StateType {
        private EntityStateStringType webcollectionurlField;
        private EntityStateStringType sitecollectionurlField;
        private EntityStateStringType secondarysitecolladminField;
        private EntityStateBoolType secondsitecolladminenabledField;
        private EntityStateBoolType allowanonymousaccessField;
        public EntityStateStringType webcollectionurl {
            get {
                return this.webcollectionurlField;
            }
            set {
                this.webcollectionurlField = value;
            }
        }
        public EntityStateStringType sitecollectionurl {
            get {
                return this.sitecollectionurlField;
            }
            set {
                this.sitecollectionurlField = value;
            }
        }
        public EntityStateStringType secondarysitecolladmin {
            get {
                return this.secondarysitecolladminField;
            }
            set {
                this.secondarysitecolladminField = value;
            }
        }
        public EntityStateBoolType secondsitecolladminenabled {
            get {
                return this.secondsitecolladminenabledField;
            }
            set {
                this.secondsitecolladminenabledField = value;
            }
        }
        public EntityStateBoolType allowanonymousaccess {
            get {
                return this.allowanonymousaccessField;
            }
            set {
                this.allowanonymousaccessField = value;
            }
        }
    }

}

