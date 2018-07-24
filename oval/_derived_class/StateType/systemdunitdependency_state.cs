using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class systemdunitdependency_state : StateType {
        private EntityStateStringType unitField;
        private EntityStateStringType dependencyField;
        public EntityStateStringType unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }
        public EntityStateStringType dependency {
            get {
                return this.dependencyField;
            }
            set {
                this.dependencyField = value;
            }
        }
    }

}

