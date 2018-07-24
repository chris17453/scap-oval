using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    public class RpmVerifyPackageBehaviors {
    [XmlIgnore]
    public bool? nodepsField       { get; set; }
    public bool nodepsSpecified=>nodepsField.HasValue;
    [XmlIgnore]
    public bool? nodigestField       { get; set; }
    public bool nodigestSpecified=>nodigestField.HasValue;
    [XmlIgnore]
    public bool? noscriptsField       { get; set; }
    public bool noscriptsSpecified=>noscriptsField.HasValue;
    [XmlIgnore]
    public bool? nosignatureField       { get; set; }
    public bool nosignatureSpecified=>nosignatureField.HasValue;
        public RpmVerifyPackageBehaviors() {
           /* this.nodepsField = false;
            this.nodigestField = false;
            this.noscriptsField = false;
            this.nosignatureField = false;*/
        }
        [XmlAttribute]
        public bool nodeps {
            get {
                return this.nodepsField.Value;
            }
            set {
                this.nodepsField = value;
            }
        }
        [XmlAttribute]
        public bool nodigest {
            get {
                return this.nodigestField.Value;
            }
            set {
                this.nodigestField = value;
            }
        }
        [XmlAttribute]
        public bool noscripts {
            get {
                return this.noscriptsField.Value;
            }
            set {
                this.noscriptsField = value;
            }
        }
        [XmlAttribute]
        public bool nosignature {
            get {
                return this.nosignatureField.Value;
            }
            set {
                this.nosignatureField = value;
            }
        }
    }

}

