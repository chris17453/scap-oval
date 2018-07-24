using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
    [XmlRootAttribute("notes", Namespace="http://oval.mitre.org/XMLSchema/oval-common-5", IsNullable=false)]
    public class NotesType {
        private string[] noteField;
        [XmlElementAttribute("note")]
        public string[] note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }
    }

}

