using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class spweb_item : ItemType {
        private EntityItemStringType webcollectionurlField;
        private EntityItemStringType sitecollectionurlField;
        private EntityItemStringType secondarysitecolladminField;
        private EntityItemBoolType secondsitecolladminenabledField;
        private EntityItemBoolType allowanonymousaccessField;
        public EntityItemStringType webcollectionurl {
            get {
                return this.webcollectionurlField;
            }
            set {
                this.webcollectionurlField = value;
            }
        }
        public EntityItemStringType sitecollectionurl {
            get {
                return this.sitecollectionurlField;
            }
            set {
                this.sitecollectionurlField = value;
            }
        }
        public EntityItemStringType secondarysitecolladmin {
            get {
                return this.secondarysitecolladminField;
            }
            set {
                this.secondarysitecolladminField = value;
            }
        }
        public EntityItemBoolType secondsitecolladminenabled {
            get {
                return this.secondsitecolladminenabledField;
            }
            set {
                this.secondsitecolladminenabledField = value;
            }
        }
        public EntityItemBoolType allowanonymousaccess {
            get {
                return this.allowanonymousaccessField;
            }
            set {
                this.allowanonymousaccessField = value;
            }
        }
    }

}

