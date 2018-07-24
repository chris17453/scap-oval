using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
    [XmlRootAttribute("deprecated_info", Namespace="http://oval.mitre.org/XMLSchema/oval-common-5", IsNullable=false)]
    public class DeprecatedInfoType {
        private string versionField;
        private string reasonField;
        private string commentField;
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        public string reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
    }

}

