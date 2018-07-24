using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#catos")]
    [XmlRootAttribute("line_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#catos", IsNullable=false)]
    public class line_state3 : StateType {
        private EntityStateStringType show_subcommandField;
        private EntityStateStringType config_lineField;
        public EntityStateStringType show_subcommand {
            get {
                return this.show_subcommandField;
            }
            set {
                this.show_subcommandField = value;
            }
        }
        public EntityStateStringType config_line {
            get {
                return this.config_lineField;
            }
            set {
                this.config_lineField = value;
            }
        }
    }

}

