using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public class packagepublisher_item : ItemType {
        private EntityItemStringType nameField;
        private EntityItemPublisherTypeType typeField;
        private EntityItemStringType origin_uriField;
        private EntityItemStringType aliasField;
        private EntityItemStringType ssl_keyField;
        private EntityItemStringType ssl_certField;
        private EntityItemClientUUIDType client_uuidField;
        private EntityItemIntType catalog_updatedField;
        private EntityItemBoolType enabledField;
        private EntityItemIntType orderField;
        private EntityItemRecordType propertiesField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemPublisherTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public EntityItemStringType origin_uri {
            get {
                return this.origin_uriField;
            }
            set {
                this.origin_uriField = value;
            }
        }
        public EntityItemStringType alias {
            get {
                return this.aliasField;
            }
            set {
                this.aliasField = value;
            }
        }
        public EntityItemStringType ssl_key {
            get {
                return this.ssl_keyField;
            }
            set {
                this.ssl_keyField = value;
            }
        }
        public EntityItemStringType ssl_cert {
            get {
                return this.ssl_certField;
            }
            set {
                this.ssl_certField = value;
            }
        }
        public EntityItemClientUUIDType client_uuid {
            get {
                return this.client_uuidField;
            }
            set {
                this.client_uuidField = value;
            }
        }
        public EntityItemIntType catalog_updated {
            get {
                return this.catalog_updatedField;
            }
            set {
                this.catalog_updatedField = value;
            }
        }
        public EntityItemBoolType enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        public EntityItemIntType order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }
        public EntityItemRecordType properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }
    }

}

