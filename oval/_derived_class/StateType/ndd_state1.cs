using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#hpux")]
    [XmlRootAttribute("ndd_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#hpux", IsNullable=false)]
    public class ndd_state1 : StateType {
        private EntityStateStringType deviceField;
        private EntityStateStringType parameterField;
        private EntityStateAnySimpleType valueField;
        public EntityStateStringType device {
            get {
                return this.deviceField;
            }
            set {
                this.deviceField = value;
            }
        }
        public EntityStateStringType parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        public EntityStateAnySimpleType value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

