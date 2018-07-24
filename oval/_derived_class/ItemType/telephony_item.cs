using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android", IsNullable=false)]
    public class telephony_item : ItemType {
        private EntityItemNetworkType network_typeField;
        private EntityItemStringType sim_country_isoField;
        private EntityItemStringType sim_operator_codeField;
        public EntityItemNetworkType network_type {
            get {
                return this.network_typeField;
            }
            set {
                this.network_typeField = value;
            }
        }
        public EntityItemStringType sim_country_iso {
            get {
                return this.sim_country_isoField;
            }
            set {
                this.sim_country_isoField = value;
            }
        }
        public EntityItemStringType sim_operator_code {
            get {
                return this.sim_operator_codeField;
            }
            set {
                this.sim_operator_codeField = value;
            }
        }
    }

}

