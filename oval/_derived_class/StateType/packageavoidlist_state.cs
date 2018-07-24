using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris", IsNullable=false)]
    public class packageavoidlist_state : StateType {
        private EntityStateStringType fmriField;
        public EntityStateStringType fmri {
            get {
                return this.fmriField;
            }
            set {
                this.fmriField = value;
            }
        }
    }

}

