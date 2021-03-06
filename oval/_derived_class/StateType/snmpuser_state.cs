﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class snmpuser_state : StateType {
        private EntityStateStringType nameField;
        private EntityStateStringType groupField;
        private EntityStateSNMPVersionStringType version1Field;
        private EntityStateStringType ipv4_aclField;
        private EntityStateStringType ipv6_aclField;
        private EntityStateSNMPPrivStringType privField;
        private EntityStateSNMPAuthStringType authField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateStringType group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        [XmlElementAttribute("version")]
        public EntityStateSNMPVersionStringType version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
        public EntityStateStringType ipv4_acl {
            get {
                return this.ipv4_aclField;
            }
            set {
                this.ipv4_aclField = value;
            }
        }
        public EntityStateStringType ipv6_acl {
            get {
                return this.ipv6_aclField;
            }
            set {
                this.ipv6_aclField = value;
            }
        }
        public EntityStateSNMPPrivStringType priv {
            get {
                return this.privField;
            }
            set {
                this.privField = value;
            }
        }
        public EntityStateSNMPAuthStringType auth {
            get {
                return this.authField;
            }
            set {
                this.authField = value;
            }
        }
    }

}

