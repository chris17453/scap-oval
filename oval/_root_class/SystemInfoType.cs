using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    public class SystemInfoType {
        private string os_nameField;
        private string os_versionField;
        private string architectureField;
        private string primary_host_nameField;
        private InterfaceType[] interfacesField;
        private System.Xml.XmlElement[] anyField;
        public string os_name {
            get {
                return this.os_nameField;
            }
            set {
                this.os_nameField = value;
            }
        }
        public string os_version {
            get {
                return this.os_versionField;
            }
            set {
                this.os_versionField = value;
            }
        }
        public string architecture {
            get {
                return this.architectureField;
            }
            set {
                this.architectureField = value;
            }
        }
        public string primary_host_name {
            get {
                return this.primary_host_nameField;
            }
            set {
                this.primary_host_nameField = value;
            }
        }
        [XmlArrayItemAttribute("interface", IsNullable=false)]
        public InterfaceType[] interfaces {
            get {
                return this.interfacesField;
            }
            set {
                this.interfacesField = value;
            }
        }
        [XmlAnyElementAttribute]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }

}

