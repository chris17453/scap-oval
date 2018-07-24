using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
 //   [XmlRoot ("glob_to_regex")]
    public class GlobToRegexFunctionType : recursive_base {
    [XmlIgnore]
    public bool? glob_noescapeField       { get; set; }
    public bool glob_noescapeSpecified=>glob_noescapeField.HasValue;
        public GlobToRegexFunctionType() {
            //this.glob_noescapeField = false;
        }
        [XmlAttribute]
        public bool glob_noescape {
            get {
                return this.glob_noescapeField.Value;
            }
            set {
                this.glob_noescapeField = value;
            }
        }
    }

}

