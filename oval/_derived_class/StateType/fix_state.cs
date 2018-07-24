using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#aix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#aix", IsNullable=false)]
    public class fix_state : StateType {
        private EntityStateStringType apar_numberField;
        private EntityStateStringType abstractField;
        private EntityStateStringType symptomField;
        private EntityStateFixInstallationStatusType installation_statusField;
        public EntityStateStringType apar_number {
            get {
                return this.apar_numberField;
            }
            set {
                this.apar_numberField = value;
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
        public EntityStateStringType symptom {
            get {
                return this.symptomField;
            }
            set {
                this.symptomField = value;
            }
        }
        public EntityStateFixInstallationStatusType installation_status {
            get {
                return this.installation_statusField;
            }
            set {
                this.installation_statusField = value;
            }
        }
    }

}

