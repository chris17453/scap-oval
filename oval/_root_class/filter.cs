using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5", IsNullable=false)]
    public class filter {
    [XmlIgnore]
    public FilterActionEnumeration? actionField       { get; set; }
    public bool actionSpecified=>actionField.HasValue;
        private string valueField;
        public filter() {
            //this.actionField = FilterActionEnumeration.exclude;
        }
        [XmlAttribute]
        public FilterActionEnumeration action {
            get {
                return this.actionField.Value;
            }
            set {
                this.actionField = value;
            }
        }
        [XmlTextAttribute]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

