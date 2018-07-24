using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class spgroup_test : TestType {
        private ObjectRefType objectField;
        private StateRefType stateField;
        public ObjectRefType @object {
            get {
                return this.objectField;
            }
            set {
                this.objectField = value;
            }
        }
        public StateRefType state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
    }

}

