using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android", IsNullable=false)]
    public class telephony_state : StateType {
        private EntityStateNetworkType network_typeField;
        private EntityStateStringType sim_country_isoField;
        private EntityStateStringType sim_operator_codeField;
        public EntityStateNetworkType network_type {
            get {
                return this.network_typeField;
            }
            set {
                this.network_typeField = value;
            }
        }
        public EntityStateStringType sim_country_iso {
            get {
                return this.sim_country_isoField;
            }
            set {
                this.sim_country_isoField = value;
            }
        }
        public EntityStateStringType sim_operator_code {
            get {
                return this.sim_operator_codeField;
            }
            set {
                this.sim_operator_codeField = value;
            }
        }
    }

}

