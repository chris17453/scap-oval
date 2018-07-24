using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public class smfproperty_item : ItemType {
        private EntityItemStringType serviceField;
        private EntityItemStringType instanceField;
        private EntityItemStringType propertyField;
        private EntityItemStringType fmriField;
        private EntityItemAnySimpleType valueField;
        public EntityItemStringType service {
            get {
                return this.serviceField;
            }
            set {
                this.serviceField = value;
            }
        }
        public EntityItemStringType instance {
            get {
                return this.instanceField;
            }
            set {
                this.instanceField = value;
            }
        }
        public EntityItemStringType property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        public EntityItemStringType fmri {
            get {
                return this.fmriField;
            }
            set {
                this.fmriField = value;
            }
        }
        public EntityItemAnySimpleType value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

