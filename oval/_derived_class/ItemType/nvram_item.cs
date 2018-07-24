using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class nvram_item : ItemType {
        private EntityItemStringType nvram_varField;
        private EntityItemStringType nvram_valueField;
        public EntityItemStringType nvram_var {
            get {
                return this.nvram_varField;
            }
            set {
                this.nvram_varField = value;
            }
        }
        public EntityItemStringType nvram_value {
            get {
                return this.nvram_valueField;
            }
            set {
                this.nvram_valueField = value;
            }
        }
    }

}

