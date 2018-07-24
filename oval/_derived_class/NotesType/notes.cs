using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5", IsNullable=false)]
    public class notes : NotesType {
        private string[] note1Field;
        [XmlElementAttribute("note")]
        public string[] note1 {
            get {
                return this.note1Field;
            }
            set {
                this.note1Field = value;
            }
        }
    }

}

