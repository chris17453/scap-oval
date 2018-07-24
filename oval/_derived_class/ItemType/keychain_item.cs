using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class keychain_item : ItemType {
        private EntityItemStringType filepathField;
        private EntityItemBoolType lock_on_sleepField;
        private EntityItemIntType timeoutField;
        public EntityItemStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
            }
        }
        public EntityItemBoolType lock_on_sleep {
            get {
                return this.lock_on_sleepField;
            }
            set {
                this.lock_on_sleepField = value;
            }
        }
        public EntityItemIntType timeout {
            get {
                return this.timeoutField;
            }
            set {
                this.timeoutField = value;
            }
        }
    }

}

