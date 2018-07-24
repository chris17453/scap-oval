using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="VariableType", Namespace="http://oval.mitre.org/XMLSchema/oval-variables-5")]
    public class VariableType1 {
        private string[] valueField;
        private string[] notesField;
        private string idField;
    [XmlIgnore]
    public SimpleDatatypeEnumeration? datatypeField       { get; set; }
    public bool datatypeSpecified=>datatypeField.HasValue;
        private string instanceField;
        private string commentField;
        public VariableType1() {
            /*this.instanceField = "1";*/
        }
        [XmlElementAttribute("value")]
        public string[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        [XmlArrayItemAttribute("note", IsNullable=false)]
        public string[] notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
            }
        }
        [XmlAttribute]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        [XmlAttribute]
        public SimpleDatatypeEnumeration datatype {
            get {
                return this.datatypeField.Value;
            }
            set {
                this.datatypeField = value;
            }
        }
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string instance {
            get {
                return this.instanceField;
            }
            set {
                this.instanceField = value;
            }
        }
        [XmlAttribute]
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

