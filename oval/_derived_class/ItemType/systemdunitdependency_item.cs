using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux", IsNullable=false)]
    public class systemdunitdependency_item : ItemType {
        private EntityItemStringType unitField;
        private EntityItemStringType[] dependencyField;
        public EntityItemStringType unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }
        [XmlElementAttribute("dependency")]
        public EntityItemStringType[] dependency {
            get {
                return this.dependencyField;
            }
            set {
                this.dependencyField = value;
            }
        }
    }

}

