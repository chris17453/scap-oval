using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#aix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#aix", IsNullable=false)]
    public class fix_item : ItemType {
        private EntityItemStringType apar_numberField;
        private EntityItemStringType abstractField;
        private EntityItemStringType symptomField;
        private EntityItemFixInstallationStatusType installation_statusField;
        public EntityItemStringType apar_number {
            get {
                return this.apar_numberField;
            }
            set {
                this.apar_numberField = value;
            }
        }
        public EntityItemStringType @abstract {
            get {
                return this.abstractField;
            }
            set {
                this.abstractField = value;
            }
        }
        public EntityItemStringType symptom {
            get {
                return this.symptomField;
            }
            set {
                this.symptomField = value;
            }
        }
        public EntityItemFixInstallationStatusType installation_status {
            get {
                return this.installation_statusField;
            }
            set {
                this.installation_statusField = value;
            }
        }
    }

}

