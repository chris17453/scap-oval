﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class SignatureType {
        private SignedInfoType signedInfoField;
        private SignatureValueType signatureValueField;
        private KeyInfoType keyInfoField;
        private ObjectType[] objectField;
        private string idField;
        public SignedInfoType SignedInfo {
            get {
                return this.signedInfoField;
            }
            set {
                this.signedInfoField = value;
            }
        }
        public SignatureValueType SignatureValue {
            get {
                return this.signatureValueField;
            }
            set {
                this.signatureValueField = value;
            }
        }
        public KeyInfoType KeyInfo {
            get {
                return this.keyInfoField;
            }
            set {
                this.keyInfoField = value;
            }
        }
        [XmlElementAttribute("Object")]
        public ObjectType[] Object {
            get {
                return this.objectField;
            }
            set {
                this.objectField = value;
            }
        }
        [XmlAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

}

