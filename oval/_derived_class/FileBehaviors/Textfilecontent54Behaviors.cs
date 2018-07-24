using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    public class Textfilecontent54Behaviors : FileBehaviors {
    [XmlIgnore]
    public bool? ignore_caseField       { get; set; }
    public bool ignore_caseSpecified=>ignore_caseField.HasValue;
    [XmlIgnore]
    public bool? multilineField       { get; set; }
    public bool multilineSpecified=>multilineField.HasValue;
    [XmlIgnore]
    public bool? singlelineField       { get; set; }
    public bool singlelineSpecified=>singlelineField.HasValue;
        public Textfilecontent54Behaviors() {
            /*this.ignore_caseField = false;
            this.multilineField = true;
            this.singlelineField = false;*/
        }
        [XmlAttribute]
        public bool ignore_case {
            get {
                return this.ignore_caseField.Value;
            }
            set {
                this.ignore_caseField = value;
            }
        }
        [XmlAttribute]
        public bool multiline {
            get {
                return this.multilineField.Value;
            }
            set {
                this.multilineField = value;
            }
        }
        [XmlAttribute]
        public bool singleline {
            get {
                return this.singlelineField.Value;
            }
            set {
                this.singlelineField = value;
            }
        }
    }

}

