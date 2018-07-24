using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android", IsNullable=false)]
    public class wifinetwork_item : ItemType {
        private EntityItemStringType bssidField;
        private EntityItemStringType ssidField;
        private EntityItemWifiAuthAlgorithmType[] auth_algorithmsField;
        private EntityItemWifiGroupCipherType[] group_ciphersField;
        private EntityItemWifiKeyMgmtType[] key_managementField;
        private EntityItemWifiPairwiseCipherType[] pairwise_ciphersField;
        private EntityItemWifiProtocolType[] protocolsField;
        private EntityItemBoolType hidden_ssidField;
        private EntityItemIntType network_idField;
        private EntityItemIntType priorityField;
        private EntityItemWifiCurrentStatusType current_statusField;
        public EntityItemStringType bssid {
            get {
                return this.bssidField;
            }
            set {
                this.bssidField = value;
            }
        }
        public EntityItemStringType ssid {
            get {
                return this.ssidField;
            }
            set {
                this.ssidField = value;
            }
        }
        [XmlElementAttribute("auth_algorithms")]
        public EntityItemWifiAuthAlgorithmType[] auth_algorithms {
            get {
                return this.auth_algorithmsField;
            }
            set {
                this.auth_algorithmsField = value;
            }
        }
        [XmlElementAttribute("group_ciphers")]
        public EntityItemWifiGroupCipherType[] group_ciphers {
            get {
                return this.group_ciphersField;
            }
            set {
                this.group_ciphersField = value;
            }
        }
        [XmlElementAttribute("key_management")]
        public EntityItemWifiKeyMgmtType[] key_management {
            get {
                return this.key_managementField;
            }
            set {
                this.key_managementField = value;
            }
        }
        [XmlElementAttribute("pairwise_ciphers")]
        public EntityItemWifiPairwiseCipherType[] pairwise_ciphers {
            get {
                return this.pairwise_ciphersField;
            }
            set {
                this.pairwise_ciphersField = value;
            }
        }
        [XmlElementAttribute("protocols")]
        public EntityItemWifiProtocolType[] protocols {
            get {
                return this.protocolsField;
            }
            set {
                this.protocolsField = value;
            }
        }
        public EntityItemBoolType hidden_ssid {
            get {
                return this.hidden_ssidField;
            }
            set {
                this.hidden_ssidField = value;
            }
        }
        public EntityItemIntType network_id {
            get {
                return this.network_idField;
            }
            set {
                this.network_idField = value;
            }
        }
        public EntityItemIntType priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
        public EntityItemWifiCurrentStatusType current_status {
            get {
                return this.current_statusField;
            }
            set {
                this.current_statusField = value;
            }
        }
    }

}

