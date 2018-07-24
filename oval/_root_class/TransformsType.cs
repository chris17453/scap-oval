using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Transforms", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class TransformsType {
        private TransformType[] transformField;
        [XmlElementAttribute("Transform")]
        public TransformType[] Transform {
            get {
                return this.transformField;
            }
            set {
                this.transformField = value;
            }
        }
    }

}

