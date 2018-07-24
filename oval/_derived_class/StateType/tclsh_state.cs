using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class tclsh_state : StateType {
        private EntityStateBoolType availableField;
        public EntityStateBoolType available {
            get {
                return this.availableField;
            }
            set {
                this.availableField = value;
            }
        }
    }

}

