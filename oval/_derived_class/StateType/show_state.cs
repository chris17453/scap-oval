using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#junos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#junos", IsNullable=false)]
    public class show_state : StateType {
        private EntityStateStringType subcommandField;
        private EntityStateStringType valueField;
        public EntityStateStringType subcommand {
            get {
                return this.subcommandField;
            }
            set {
                this.subcommandField = value;
            }
        }
        public EntityStateStringType value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

