using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class keychain_state : StateType {
        private EntityStateStringType filepathField;
        private EntityStateBoolType lock_on_sleepField;
        private EntityStateIntType timeoutField;
        public EntityStateStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
            }
        }
        public EntityStateBoolType lock_on_sleep {
            get {
                return this.lock_on_sleepField;
            }
            set {
                this.lock_on_sleepField = value;
            }
        }
        public EntityStateIntType timeout {
            get {
                return this.timeoutField;
            }
            set {
                this.timeoutField = value;
            }
        }
    }

}

