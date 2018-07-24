using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class global_state : StateType {
        private EntityStateStringType global_commandField;
        public EntityStateStringType global_command {
            get {
                return this.global_commandField;
            }
            set {
                this.global_commandField = value;
            }
        }
    }

}

