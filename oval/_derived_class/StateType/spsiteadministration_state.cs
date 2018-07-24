using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class spsiteadministration_state : StateType {
        private EntityStateStringType sitecollectionurlField;
        private EntityStateIntType storagemaxlevelField;
        private EntityStateIntType storagewarninglevelField;
        public EntityStateStringType sitecollectionurl {
            get {
                return this.sitecollectionurlField;
            }
            set {
                this.sitecollectionurlField = value;
            }
        }
        public EntityStateIntType storagemaxlevel {
            get {
                return this.storagemaxlevelField;
            }
            set {
                this.storagemaxlevelField = value;
            }
        }
        public EntityStateIntType storagewarninglevel {
            get {
                return this.storagewarninglevelField;
            }
            set {
                this.storagewarninglevelField = value;
            }
        }
    }

}

