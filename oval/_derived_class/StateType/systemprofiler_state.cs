using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class systemprofiler_state : StateType {
        private EntityStateDataTypeType data_typeField;
        private EntityStateStringType xpathField;
        private EntityStateAnySimpleType value_ofField;
        public EntityStateDataTypeType data_type {
            get {
                return this.data_typeField;
            }
            set {
                this.data_typeField = value;
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

