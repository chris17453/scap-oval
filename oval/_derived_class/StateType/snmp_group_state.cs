using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa", IsNullable=false)]
    public class snmp_group_state : StateType {
        private EntityStateStringType nameField;
        private EntityStateSNMPSecLevelStringType2 snmpv3_sec_levelField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateSNMPSecLevelStringType2 snmpv3_sec_level {
            get {
                return this.snmpv3_sec_levelField;
            }
            set {
                this.snmpv3_sec_levelField = value;
            }
        }
    }

}

