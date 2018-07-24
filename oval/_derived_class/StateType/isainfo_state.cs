using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris", IsNullable=false)]
    public class isainfo_state : StateType {
        private EntityStateIntType bitsField;
        private EntityStateStringType kernel_isaField;
        private EntityStateStringType application_isaField;
        public EntityStateIntType bits {
            get {
                return this.bitsField;
            }
            set {
                this.bitsField = value;
            }
        }
        public EntityStateStringType kernel_isa {
            get {
                return this.kernel_isaField;
            }
            set {
                this.kernel_isaField = value;
            }
        }
        public EntityStateStringType application_isa {
            get {
                return this.application_isaField;
            }
            set {
                this.application_isaField = value;
            }
        }
    }

}

