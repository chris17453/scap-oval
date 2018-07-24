using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android", IsNullable=false)]
    public class wifinetwork_state : StateType {
        private EntityStateStringType ssidField;
        private EntityStateStringType bssidField;
        private EntityStateWifiAuthAlgorithmType[] auth_algorithmsField;
        private EntityStateWifiGroupCipherType[] group_ciphersField;
        private EntityStateWifiKeyMgmtType[] key_managementField;
        private EntityStateWifiPairwiseCipherType[] pairwise_ciphersField;
        private EntityStateWifiProtocolType[] protocolsField;
        private EntityStateBoolType hidden_ssidField;
        private EntityStateIntType network_idField;
        private EntityStateIntType priorityField;
        private EntityStateWifiCurrentStatusType current_statusField;
        public EntityStateStringType ssid {
            get {
                return this.ssidField;
            }
            set {
                this.ssidField = value;
            }
        }
        public EntityStateStringType bssid {
            get {
                return this.bssidField;
            }
            set {
                this.bssidField = value;
            }
        }
        [XmlElementAttribute("auth_algorithms")]
        public EntityStateWifiAuthAlgorithmType[] auth_algorithms {
            get {
                return this.auth_algorithmsField;
            }
            set {
                this.auth_algorithmsField = value;
            }
        }
        [XmlElementAttribute("group_ciphers")]
        public EntityStateWifiGroupCipherType[] group_ciphers {
            get {
                return this.group_ciphersField;
            }
            set {
                this.group_ciphersField = value;
            }
        }
        [XmlElementAttribute("key_management")]
        public EntityStateWifiKeyMgmtType[] key_management {
            get {
                return this.key_managementField;
            }
            set {
                this.key_managementField = value;
            }
        }
        [XmlElementAttribute("pairwise_ciphers")]
        public EntityStateWifiPairwiseCipherType[] pairwise_ciphers {
            get {
                return this.pairwise_ciphersField;
            }
            set {
                this.pairwise_ciphersField = value;
            }
        }
        [XmlElementAttribute("protocols")]
        public EntityStateWifiProtocolType[] protocols {
            get {
                return this.protocolsField;
            }
            set {
                this.protocolsField = value;
            }
        }
        public EntityStateBoolType hidden_ssid {
            get {
                return this.hidden_ssidField;
            }
            set {
                this.hidden_ssidField = value;
            }
        }
        public EntityStateIntType network_id {
            get {
                return this.network_idField;
            }
            set {
                this.network_idField = value;
            }
        }
        public EntityStateIntType priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
        public EntityStateWifiCurrentStatusType current_status {
            get {
                return this.current_statusField;
            }
            set {
                this.current_statusField = value;
            }
        }
    }

}

