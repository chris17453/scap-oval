using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris")]
    public class PackageCheckBehaviors {
    [XmlIgnore]
    public bool? fileattributes_onlyField       { get; set; }
    public bool fileattributes_onlySpecified=>fileattributes_onlyField.HasValue;
    [XmlIgnore]
    public bool? filecontents_onlyField       { get; set; }
    public bool filecontents_onlySpecified=>filecontents_onlyField.HasValue;
    [XmlIgnore]
    public bool? no_volatileeditableField       { get; set; }
    public bool no_volatileeditableSpecified=>no_volatileeditableField.HasValue;
        public PackageCheckBehaviors() {
            //this.fileattributes_onlyField = false;
            //this.filecontents_onlyField = false;
            //this.no_volatileeditableField = false;
        }
        [XmlAttribute]
        public bool fileattributes_only {
            get {
                return this.fileattributes_onlyField.Value;
            }
            set {
                this.fileattributes_onlyField = value;
            }
        }
        [XmlAttribute]
        public bool filecontents_only {
            get {
                return this.filecontents_onlyField.Value;
            }
            set {
                this.filecontents_onlyField = value;
            }
        }
        [XmlAttribute]
        public bool no_volatileeditable {
            get {
                return this.no_volatileeditableField.Value;
            }
            set {
                this.no_volatileeditableField = value;
            }
        }
    }

}

