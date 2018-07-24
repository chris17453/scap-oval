﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe")]
    [XmlRootAttribute("bgpneighbor_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe", IsNullable=false)]
    public class bgpneighbor_item1 : ItemType {
        private EntityItemStringType neighborField;
        private EntityItemStringType passwordField;
        public EntityItemStringType neighbor {
            get {
                return this.neighborField;
            }
            set {
                this.neighborField = value;
            }
        }
        public EntityItemStringType password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
    }

}

