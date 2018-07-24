using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class nvram_state : StateType {
        private EntityStateStringType nvram_varField;
        private EntityStateStringType nvram_valueField;
        public EntityStateStringType nvram_var {
            get {
                return this.nvram_varField;
            }
            set {
                this.nvram_varField = value;
            }
        }
        public EntityStateStringType nvram_value {
            get {
                return this.nvram_valueField;
            }
            set {
                this.nvram_valueField = value;
            }
        }
    }

}

