using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class wmi57_item : ItemType {
        private EntityItemStringType namespaceField;
        private EntityItemStringType wqlField;
        private EntityItemRecordType[] resultField;
        public EntityItemStringType @namespace {
            get {
                return this.namespaceField;
            }
            set {
                this.namespaceField = value;
            }
        }
        public EntityItemStringType wql {
            get {
                return this.wqlField;
            }
            set {
                this.wqlField = value;
            }
        }
        [XmlElementAttribute("result")]
        public EntityItemRecordType[] result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }

}

