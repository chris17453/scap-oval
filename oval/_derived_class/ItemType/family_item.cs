using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#independent", IsNullable=false)]
    public class family_item : ItemType {
        private EntityItemFamilyType familyField;
        public EntityItemFamilyType family {
            get {
                return this.familyField;
            }
            set {
                this.familyField = value;
            }
        }
    }

}

