using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class wmi_state : StateType {
        private EntityStateStringType namespaceField;
        private EntityStateStringType wqlField;
        private EntityStateAnySimpleType resultField;
        public EntityStateStringType @namespace {
            get {
                return this.namespaceField;
            }
            set {
                this.namespaceField = value;
            }
        }
        public EntityStateStringType wql {
            get {
                return this.wqlField;
            }
            set {
                this.wqlField = value;
            }
        }
        public EntityStateAnySimpleType result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }

}

