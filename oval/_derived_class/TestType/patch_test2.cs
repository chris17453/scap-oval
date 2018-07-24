using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#hpux")]
    [XmlRootAttribute("patch_test", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#hpux", IsNullable=false)]
    public class patch_test2 : TestType {
        private ObjectRefType objectField;
        private StateRefType[] stateField;
        public ObjectRefType @object {
            get {
                return this.objectField;
            }
            set {
                this.objectField = value;
            }
        }
        [XmlElementAttribute("state")]
        public StateRefType[] state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
    }

}

