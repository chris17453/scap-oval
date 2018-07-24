using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#aix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#aix", IsNullable=false)]
    public class oslevel_state : StateType {
        private EntityStateVersionType maintenance_levelField;
        public EntityStateVersionType maintenance_level {
            get {
                return this.maintenance_levelField;
            }
            set {
                this.maintenance_levelField = value;
            }
        }
    }

}

