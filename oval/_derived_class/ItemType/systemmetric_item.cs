using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class systemmetric_item : ItemType {
        private EntityItemSystemMetricIndexType indexField;
        private EntityItemIntType valueField;
        public EntityItemSystemMetricIndexType index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
            }
        }
        public EntityItemIntType value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

