using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris", IsNullable=false)]
    public class packagepublisher_state : StateType {
        private EntityStateStringType nameField;
        private EntityStatePublisherTypeType typeField;
        private EntityStateStringType origin_uriField;
        private EntityStateStringType aliasField;
        private EntityStateStringType ssl_keyField;
        private EntityStateStringType ssl_certField;
        private EntityStateClientUUIDType client_uuidField;
        private EntityStateIntType catalog_updatedField;
        private EntityStateBoolType enabledField;
        private EntityStateIntType orderField;
        private EntityStateRecordType propertiesField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStatePublisherTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public EntityStateStringType origin_uri {
            get {
                return this.origin_uriField;
            }
            set {
                this.origin_uriField = value;
            }
        }
        public EntityStateStringType alias {
            get {
                return this.aliasField;
            }
            set {
                this.aliasField = value;
            }
        }
        public EntityStateStringType ssl_key {
            get {
                return this.ssl_keyField;
            }
            set {
                this.ssl_keyField = value;
            }
        }
        public EntityStateStringType ssl_cert {
            get {
                return this.ssl_certField;
            }
            set {
                this.ssl_certField = value;
            }
        }
        public EntityStateClientUUIDType client_uuid {
            get {
                return this.client_uuidField;
            }
            set {
                this.client_uuidField = value;
            }
        }
        public EntityStateIntType catalog_updated {
            get {
                return this.catalog_updatedField;
            }
            set {
                this.catalog_updatedField = value;
            }
        }
        public EntityStateBoolType enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        public EntityStateIntType order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }
        public EntityStateRecordType properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }
    }

}

