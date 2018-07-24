using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios")]
    [XmlRootAttribute("line_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios", IsNullable=false)]
    public class line_item1 : ItemType {
        private EntityItemStringType show_subcommandField;
        private EntityItemStringType config_lineField;
        public EntityItemStringType show_subcommand {
            get {
                return this.show_subcommandField;
            }
            set {
                this.show_subcommandField = value;
            }
        }
        public EntityItemStringType config_line {
            get {
                return this.config_lineField;
            }
            set {
                this.config_lineField = value;
            }
        }
    }

}

