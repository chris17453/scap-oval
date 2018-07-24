using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#aix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#aix", IsNullable=false)]
    public class interim_fix_item : ItemType {
        private EntityItemStringType vuidField;
        private EntityItemStringType labelField;
        private EntityItemStringType abstractField;
        private EntityItemInterimFixStateType stateField;
        public EntityItemStringType vuid {
            get {
                return this.vuidField;
            }
            set {
                this.vuidField = value;
            }
        }
        public EntityItemStringType label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        public EntityItemStringType @abstract {
            get {
                return this.abstractField;
            }
            set {
                this.abstractField = value;
            }
        }
        public EntityItemInterimFixStateType state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
    }

}

