using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris", IsNullable=false)]
    public class patch_state : StateType {
        private EntityStateIntType baseField;
        private EntityStateIntType version1Field;
        public EntityStateIntType @base {
            get {
                return this.baseField;
            }
            set {
                this.baseField = value;
            }
        }
        [XmlElementAttribute("version")]
        public EntityStateIntType version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
    }

}

