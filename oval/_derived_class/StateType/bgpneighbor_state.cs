using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class bgpneighbor_state : StateType {
        private EntityStateStringType neighborField;
        private EntityStateStringType passwordField;
        public EntityStateStringType neighbor {
            get {
                return this.neighborField;
            }
            set {
                this.neighborField = value;
            }
        }
        public EntityStateStringType password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
    }

}

