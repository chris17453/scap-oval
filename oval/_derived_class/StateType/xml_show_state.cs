using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#junos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#junos", IsNullable=false)]
    public class xml_show_state : StateType {
        private EntityStateStringType subcommandField;
        private EntityStateStringType xpathField;
        private EntityStateAnySimpleType value_ofField;
        public EntityStateStringType subcommand {
            get {
                return this.subcommandField;
            }
            set {
                this.subcommandField = value;
            }
        }
        public EntityStateStringType xpath {
            get {
                return this.xpathField;
            }
            set {
                this.xpathField = value;
            }
        }
        public EntityStateAnySimpleType value_of {
            get {
                return this.value_ofField;
            }
            set {
                this.value_ofField = value;
            }
        }
    }

}

