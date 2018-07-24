﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios", IsNullable=false)]
    public class snmpcommunity_item : ItemType {
        private EntityItemStringType nameField;
        private EntityItemStringType viewField;
        private EntityItemSNMPModeStringType modeField;
        private EntityItemStringType ipv4_aclField;
        private EntityItemStringType ipv6_aclField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemStringType view {
            get {
                return this.viewField;
            }
            set {
                this.viewField = value;
            }
        }
        public EntityItemSNMPModeStringType mode {
            get {
                return this.modeField;
            }
            set {
                this.modeField = value;
            }
        }
        public EntityItemStringType ipv4_acl {
            get {
                return this.ipv4_aclField;
            }
            set {
                this.ipv4_aclField = value;
            }
        }
        public EntityItemStringType ipv6_acl {
            get {
                return this.ipv6_aclField;
            }
            set {
                this.ipv6_aclField = value;
            }
        }
    }

}

