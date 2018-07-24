using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class spsiteadministration_item : ItemType {
        private EntityItemStringType sitecollectionurlField;
        private EntityItemIntType storagemaxlevelField;
        private EntityItemIntType storagewarninglevelField;
        public EntityItemStringType sitecollectionurl {
            get {
                return this.sitecollectionurlField;
            }
            set {
                this.sitecollectionurlField = value;
            }
        }
        public EntityItemIntType storagemaxlevel {
            get {
                return this.storagemaxlevelField;
            }
            set {
                this.storagemaxlevelField = value;
            }
        }
        public EntityItemIntType storagewarninglevel {
            get {
                return this.storagewarninglevelField;
            }
            set {
                this.storagewarninglevelField = value;
            }
        }
    }

}

