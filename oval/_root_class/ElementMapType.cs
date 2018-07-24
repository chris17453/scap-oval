using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
    [XmlRootAttribute("element_mapping", Namespace="http://oval.mitre.org/XMLSchema/oval-common-5", IsNullable=false)]
    public class ElementMapType {
        private ElementMapItemType testField;
        private ElementMapItemType objectField;
        private ElementMapItemType stateField;
        private ElementMapItemType itemField;
        public ElementMapItemType test {
            get {
                return this.testField;
            }
            set {
                this.testField = value;
            }
        }
        public ElementMapItemType @object {
            get {
                return this.objectField;
            }
            set {
                this.objectField = value;
            }
        }
        public ElementMapItemType state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        public ElementMapItemType item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }

}

