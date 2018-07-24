using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class port_item : ItemType {
        private EntityItemIPAddressStringType local_addressField;
        private EntityItemIntType local_portField;
        private EntityItemProtocolType protocolField;
        private EntityItemIntType pidField;
        private EntityItemIPAddressStringType foreign_addressField;
        private EntityItemStringType foreign_portField;
        public EntityItemIPAddressStringType local_address {
            get {
                return this.local_addressField;
            }
            set {
                this.local_addressField = value;
            }
        }
        public EntityItemIntType local_port {
            get {
                return this.local_portField;
            }
            set {
                this.local_portField = value;
            }
        }
        public EntityItemProtocolType protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        public EntityItemIntType pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
            }
        }
        public EntityItemIPAddressStringType foreign_address {
            get {
                return this.foreign_addressField;
            }
            set {
                this.foreign_addressField = value;
            }
        }
        public EntityItemStringType foreign_port {
            get {
                return this.foreign_portField;
            }
            set {
                this.foreign_portField = value;
            }
        }
    }

}

