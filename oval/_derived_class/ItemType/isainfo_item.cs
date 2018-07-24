using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public class isainfo_item : ItemType {
        private EntityItemIntType bitsField;
        private EntityItemStringType kernel_isaField;
        private EntityItemStringType application_isaField;
        public EntityItemIntType bits {
            get {
                return this.bitsField;
            }
            set {
                this.bitsField = value;
            }
        }
        public EntityItemStringType kernel_isa {
            get {
                return this.kernel_isaField;
            }
            set {
                this.kernel_isaField = value;
            }
        }
        public EntityItemStringType application_isa {
            get {
                return this.application_isaField;
            }
            set {
                this.application_isaField = value;
            }
        }
    }

}

