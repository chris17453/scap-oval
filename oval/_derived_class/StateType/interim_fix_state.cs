using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#aix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#aix", IsNullable=false)]
    public class interim_fix_state : StateType {
        private EntityStateStringType vuidField;
        private EntityStateStringType labelField;
        private EntityStateStringType abstractField;
        private EntityStateInterimFixStateType stateField;
        public EntityStateStringType vuid {
            get {
                return this.vuidField;
            }
            set {
                this.vuidField = value;
            }
        }
        public EntityStateStringType label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        public EntityStateStringType @abstract {
            get {
                return this.abstractField;
            }
            set {
                this.abstractField = value;
            }
        }
        public EntityStateInterimFixStateType state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
    }

}

