using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute("version_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class version_state2 : StateType {
        private EntityStateStringType major_releaseField;
        private EntityStateStringType train_numberField;
        private EntityStateTrainIdentifierType train_identifierField;
        private EntityStateIOSVersionType version_stringField;
        public EntityStateStringType major_release {
            get {
                return this.major_releaseField;
            }
            set {
                this.major_releaseField = value;
            }
        }
        public EntityStateStringType train_number {
            get {
                return this.train_numberField;
            }
            set {
                this.train_numberField = value;
            }
        }
        public EntityStateTrainIdentifierType train_identifier {
            get {
                return this.train_identifierField;
            }
            set {
                this.train_identifierField = value;
            }
        }
        public EntityStateIOSVersionType version_string {
            get {
                return this.version_stringField;
            }
            set {
                this.version_stringField = value;
            }
        }
    }

}

