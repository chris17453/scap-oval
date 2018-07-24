using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris", IsNullable=false)]
    public class smfproperty_state : StateType {
        private EntityStateStringType serviceField;
        private EntityStateStringType instanceField;
        private EntityStateStringType propertyField;
        private EntityStateStringType fmriField;
        private EntityStateAnySimpleType valueField;
        public EntityStateStringType service {
            get {
                return this.serviceField;
            }
            set {
                this.serviceField = value;
            }
        }
        public EntityStateStringType instance {
            get {
                return this.instanceField;
            }
            set {
                this.instanceField = value;
            }
        }
        public EntityStateStringType property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        public EntityStateStringType fmri {
            get {
                return this.fmriField;
            }
            set {
                this.fmriField = value;
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

