using System;
using System.ComponentModel;
using System.Xml; 
using System.Xml.Serialization; 
using System.Runtime.CompilerServices;
 namespace oval{       [XmlIncludeAttribute(typeof(EntityObjectAccessListIPVersionType2))]
    [XmlIncludeAttribute(typeof(EntityObjectRoutingProtocolType1))]
    [XmlIncludeAttribute(typeof(EntityObjectAccessListIPVersionType1))]
    [XmlIncludeAttribute(typeof(EntityObjectRoutingProtocolType))]
    [XmlIncludeAttribute(typeof(EntityObjectAccessListIPVersionType))]
    [XmlIncludeAttribute(typeof(EntityStateDataTypeType))]
    [XmlIncludeAttribute(typeof(EntityObjectDataTypeType))]
    [XmlIncludeAttribute(typeof(EntityObjectUrlZoneType))]
    [XmlIncludeAttribute(typeof(EntityObjectPublisherTypeType))]
    [XmlIncludeAttribute(typeof(EntityObjectUserRightType))]
    [XmlIncludeAttribute(typeof(EntityObjectCmdletVerbType))]
    [XmlIncludeAttribute(typeof(EntityObjectGUIDType))]
    [XmlIncludeAttribute(typeof(EntityObjectSystemMetricIndexType))]
    [XmlIncludeAttribute(typeof(EntityObjectRegistryHiveType))]
    [XmlIncludeAttribute(typeof(EntityObjectProtocolType))]
    [XmlIncludeAttribute(typeof(EntityObjectNamingContextType))]
    [XmlIncludeAttribute(typeof(EntityObjectVariableRefType))]
    [XmlIncludeAttribute(typeof(EntityObjectHashTypeType))]
    [XmlIncludeAttribute(typeof(EntityObjectEngineType))]
    [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        public class EntityObjectStringType:EntitySimpleBaseType {
        public EntityObjectStringType(){
            datatype="string";
        }
/*
        [XmlAttribute]
        public string datatype           { get { return this.datatypeField; } set { this.datatypeField = value; } }
        [XmlIgnore]
        public string datatypeField      { get; set; }
        public bool   datatypeSpecified  { get { if(null==this.datatypeField) return false; return true; } }

        [XmlAttribute]
        public OperationEnumeration operation {get {return this.operationField.Value;}set {this.operationField = value;}}
        [XmlIgnore]
        public OperationEnumeration? operationField       { get; set; }
        public bool operationSpecified=>operationField.HasValue;


        [XmlAttribute]
        public bool mask                { get { return this.maskField.Value; } set { this.maskField = value; } }
        [XmlIgnore]
        public bool? maskField          { get; set; }
        public bool maskSpecified=>maskField.HasValue;

        [XmlAttribute]
        public string var_ref           { get { return this.var_refField; } set { this.var_refField = value; } }
        [XmlIgnore]
        public string var_refField      { get; set; }
        public bool   var_refSpecified  { get { if(null==this.var_refField) return false; return true; } }


        [XmlAttribute]
        public CheckEnumeration var_check { get { return this.var_checkField.Value; } set { this.var_checkField = value; } }
        [XmlIgnore]
        public CheckEnumeration? var_checkField       { get; set; }
        public bool var_checkSpecified=>var_checkField.HasValue;

        [XmlText]
        public string Value { get { return this.valueField; } set { this.valueField = value; } }    
        [XmlIgnore]
        public string valueField;
        public bool   valueFieldSpecified  { get { if(null==this.valueField) return false; return true; } }*/

    }

}

