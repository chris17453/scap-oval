﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent", IsNullable=false)]
    public class family_state : StateType {
        private EntityStateFamilyType familyField;
        public EntityStateFamilyType family {
            get {
                return this.familyField;
            }
            set {
                this.familyField = value;
            }
        }
    }

}

