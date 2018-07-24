using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    public class InterfaceType {
        private string interface_nameField;
        private string ip_addressField;
        private string mac_addressField;
        public string interface_name {
            get {
                return this.interface_nameField;
            }
            set {
                this.interface_nameField = value;
            }
        }
        public string ip_address {
            get {
                return this.ip_addressField;
            }
            set {
                this.ip_addressField = value;
            }
        }
        public string mac_address {
            get {
                return this.mac_addressField;
            }
            set {
                this.mac_addressField = value;
            }
        }
    }

}

