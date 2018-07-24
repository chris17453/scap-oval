using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    public class DirectiveType {
    [XmlIgnore]
    public bool? reportedField       { get; set; }
    public bool reportedSpecified=>reportedField.HasValue;
    [XmlIgnore]
    public ContentEnumeration? contentField       { get; set; }
    public bool contentSpecified=>contentField.HasValue;
        public DirectiveType() {
            //this.contentField = ContentEnumeration.full;
        }
        [XmlAttribute]
        public bool reported {
            get {
                return this.reportedField.Value;
            }
            set {
                this.reportedField = value;
            }
        }
        [XmlAttribute]
        public ContentEnumeration content {
            get {
                return this.contentField.Value;
            }
            set {
                this.contentField = value;
            }
        }
    }

}

