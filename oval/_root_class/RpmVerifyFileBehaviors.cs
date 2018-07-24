using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    public class RpmVerifyFileBehaviors {
        public RpmVerifyFileBehaviors() {
           /* this.nolinktoField = false;
            this.nomd5Field = false;
            this.nosizeField = false;
            this.nouserField = false;
            this.nogroupField = false;
            this.nomtimeField = false;
            this.nomodeField = false;
            this.nordevField = false;
            this.noconfigfilesField = false;
            this.noghostfilesField = false;
            this.nofiledigestField = false;
            this.nocapsField = false;*/
        }
        [XmlAttribute]
        public bool nolinkto { get { if(null==this.nolinktoField) return false;  return this.nolinktoField.Value; } set { this.nolinktoField = value; } }
        [XmlIgnore]
        public bool? nolinktoField        { get; set; }
        public bool nolinktoSpecified        => nolinktoField.HasValue;

        [XmlAttribute]
        public bool nomd5 { get { if(null==this.nomd5Field) return false; return this.nomd5Field.Value; } set { this.nomd5Field = value; }
        }
        [XmlIgnore]
        public bool? nomd5Field           { get; set; }
        public bool nomd5Specified           => nomd5Field.HasValue;

        [XmlAttribute]
        public bool nosize { get { if(null==this.nosizeField) return false; return this.nosizeField.Value; } set { this.nosizeField = value; } } 
        [XmlIgnore]
        public bool? nosizeField          { get; set; }
        public bool nosizeSpecified          => nosizeField.HasValue;

        [XmlAttribute]
        public bool nouser { get { if(null==this.nouserField) return false; return this.nouserField.Value; }  set {  this.nouserField = value; }}
        [XmlIgnore]
        public bool? nouserField          { get; set; }
        public bool nouserSpecified          => nouserField.HasValue;

        [XmlAttribute]
        public bool nogroup {get {if(null==this.nogroupField) return false; return this.nogroupField.Value;}set {this.nogroupField = value;}}
        [XmlIgnore]
        public bool? nogroupField         { get; set; }
        public bool nogroupSpecified         => nogroupField.HasValue;

        [XmlAttribute]
        public bool nomtime {get {if(null==this.nomtimeField) return false; return this.nomtimeField.Value;}set {this.nomtimeField = value;}}
        [XmlIgnore]
        public bool? nomtimeField         { get; set; }
        public bool nomtimeSpecified         => nomtimeField.HasValue;

        [XmlAttribute]
        public bool nomode {get {if(null==this.nomodeField) return false; return this.nomodeField.Value;}set {this.nomodeField = value;}}
        [XmlIgnore]
        public bool? nomodeField          { get; set; }
        public bool nomodeSpecified          => nomodeField.HasValue;

        [XmlAttribute]
        public bool nordev {get {if(null==this.nordevField) return false; return this.nordevField.Value;}set {this.nordevField = value;}}
        [XmlIgnore]
        public bool? nordevField          { get; set; }
        public bool nordevSpecified          => nordevField.HasValue;

        [XmlAttribute]
        public bool noconfigfiles {get {if(null==this.noconfigfilesField) return false; return this.noconfigfilesField.Value;}set {this.noconfigfilesField = value;}}
        [XmlIgnore]
        public bool? noconfigfilesField   { get; set; }
        public bool noconfigfilesSpecified   => noconfigfilesField.HasValue;

        [XmlAttribute]
        public bool noghostfiles {get {if(null==this.noghostfilesField) return false; return this.noghostfilesField.Value;}set {this.noghostfilesField = value;}}
        [XmlIgnore]
        public bool? noghostfilesField    { get; set; }
        public bool noghostfilesSpecified    => noghostfilesField.HasValue;

        [XmlAttribute]
        public bool nofiledigest {get {if(null==this.nofiledigestField) return false; return this.nofiledigestField.Value;}set {this.nofiledigestField = value;}}
        [XmlIgnore]
        public bool? nofiledigestField    { get; set; }
        public bool nofiledigestSpecified    => nofiledigestField.HasValue;

        [XmlAttribute]
        public bool nocaps {get { return this.nocapsField.Value; }  set { this.nocapsField = value; } 
        }
        [XmlIgnore]
        public bool? nocapsField          { get; set; }
        public bool nocapsSpecified        => nocapsField.HasValue;

    }

}

