using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class systemmetric_state : StateType {
        private EntityStateSystemMetricIndexType indexField;
        private EntityStateIntType valueField;
        public EntityStateSystemMetricIndexType index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
            }
        }
        public EntityStateIntType value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

