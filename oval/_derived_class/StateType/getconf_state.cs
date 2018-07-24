using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#hpux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#hpux", IsNullable=false)]
    public class getconf_state : StateType {
        private EntityStateStringType parameter_nameField;
        private EntityStateStringType pathnameField;
        private EntityStateAnySimpleType outputField;
        public EntityStateStringType parameter_name {
            get {
                return this.parameter_nameField;
            }
            set {
                this.parameter_nameField = value;
            }
        }
        public EntityStateStringType pathname {
            get {
                return this.pathnameField;
            }
            set {
                this.pathnameField = value;
            }
        }
        public EntityStateAnySimpleType output {
            get {
                return this.outputField;
            }
            set {
                this.outputField = value;
            }
        }
    }

}

