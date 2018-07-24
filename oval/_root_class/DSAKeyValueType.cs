using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("DSAKeyValue", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class DSAKeyValueType {
        private byte[] pField;
        private byte[] qField;
        private byte[] gField;
        private byte[] yField;
        private byte[] jField;
        private byte[] seedField;
        private byte[] pgenCounterField;
        [XmlElementAttribute(DataType="base64Binary")]
        public byte[] P {
            get {
                return this.pField;
            }
            set {
                this.pField = value;
            }
        }
        [XmlElementAttribute(DataType="base64Binary")]
        public byte[] Q {
            get {
                return this.qField;
            }
            set {
                this.qField = value;
            }
        }
        [XmlElementAttribute(DataType="base64Binary")]
        public byte[] G {
            get {
                return this.gField;
            }
            set {
                this.gField = value;
            }
        }
        [XmlElementAttribute(DataType="base64Binary")]
        public byte[] Y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
        [XmlElementAttribute(DataType="base64Binary")]
        public byte[] J {
            get {
                return this.jField;
            }
            set {
                this.jField = value;
            }
        }
        [XmlElementAttribute(DataType="base64Binary")]
        public byte[] Seed {
            get {
                return this.seedField;
            }
            set {
                this.seedField = value;
            }
        }
        [XmlElementAttribute(DataType="base64Binary")]
        public byte[] PgenCounter {
            get {
                return this.pgenCounterField;
            }
            set {
                this.pgenCounterField = value;
            }
        }
    }

}

