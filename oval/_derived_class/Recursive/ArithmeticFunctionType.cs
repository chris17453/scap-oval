using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [Serializable]
    [XmlType(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
   // [XmlRoot("arithmetic")]
    public class ArithmeticFunctionType : recursive_base  {
    [XmlIgnore]
    public ArithmeticEnumeration? arithmetic_operationField       { get; set; }
    public bool arithmetic_operationSpecified=>arithmetic_operationField.HasValue;
        [XmlAttribute]
        public ArithmeticEnumeration arithmetic_operation {
            get {
                return this.arithmetic_operationField.Value;
            }
            set {
                this.arithmetic_operationField = value;
            }
        }
    }

}

