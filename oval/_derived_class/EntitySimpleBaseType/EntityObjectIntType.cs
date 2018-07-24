using System;
using System.Xml; 
using System.Xml.Serialization; 
using System.ComponentModel;
using System.Xml.Schema;
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public class EntityObjectIntType :EntitySimpleBaseType  {
        public EntityObjectIntType  () {
           this.datatype = "int";
           // this.operation = OperationEnumeration.equals;
           // this.mask = false;
        }
        /*[XmlAttribute]
            public string                datatype { get ; set;  }
            [XmlAttribute]
            public OperationEnumeration  operation { get; set; }
            [XmlAttribute]
            public bool                  mask { get; set; }
            [XmlAttribute]
            public string                var_ref { get; set; }
            [XmlAttribute]
            public CheckEnumeration      var_check { get; set; }
            [XmlIgnoreAttribute]
            public bool                  var_checkSpecified { get; set; }
            [XmlTextAttribute]
            public string                Value { get; set; }        
        }*/
    }
}

