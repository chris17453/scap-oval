﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class volume_test : TestType {
        private ObjectRefType objectField;
        private StateRefType[] stateField;
        public ObjectRefType @object {
            get {
                return this.objectField;
            }
            set {
                this.objectField = value;
            }
        }
        [XmlElementAttribute("state")]
        public StateRefType[] state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
    }

}

