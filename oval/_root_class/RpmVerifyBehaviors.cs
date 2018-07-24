using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    public class RpmVerifyBehaviors {
    [XmlIgnore]
    public bool? nodepsField       { get; set; }
    public bool nodepsSpecified=>nodepsField.HasValue;
    [XmlIgnore]
    public bool? nodigestField       { get; set; }
    public bool nodigestSpecified=>nodigestField.HasValue;
    [XmlIgnore]
    public bool? nofilesField       { get; set; }
    public bool nofilesSpecified=>nofilesField.HasValue;
    [XmlIgnore]
    public bool? noscriptsField       { get; set; }
    public bool noscriptsSpecified=>noscriptsField.HasValue;
    [XmlIgnore]
    public bool? nosignatureField       { get; set; }
    public bool nosignatureSpecified=>nosignatureField.HasValue;
    [XmlIgnore]
    public bool? nolinktoField       { get; set; }
    public bool nolinktoSpecified=>nolinktoField.HasValue;
    [XmlIgnore]
    public bool? nomd5Field       { get; set; }
    public bool nomd5Specified=>nomd5Field.HasValue;
    [XmlIgnore]
    public bool? nosizeField       { get; set; }
    public bool nosizeSpecified=>nosizeField.HasValue;
    [XmlIgnore]
    public bool? nouserField       { get; set; }
    public bool nouserSpecified=>nouserField.HasValue;
    [XmlIgnore]
    public bool? nogroupField       { get; set; }
    public bool nogroupSpecified=>nogroupField.HasValue;
    [XmlIgnore]
    public bool? nomtimeField       { get; set; }
    public bool nomtimeSpecified=>nomtimeField.HasValue;
    [XmlIgnore]
    public bool? nomodeField       { get; set; }
    public bool nomodeSpecified=>nomodeField.HasValue;
    [XmlIgnore]
    public bool? nordevField       { get; set; }
    public bool nordevSpecified=>nordevField.HasValue;
    [XmlIgnore]
    public bool? noconfigfilesField       { get; set; }
    public bool noconfigfilesSpecified=>noconfigfilesField.HasValue;
    [XmlIgnore]
    public bool? noghostfilesField       { get; set; }
    public bool noghostfilesSpecified=>noghostfilesField.HasValue;
        public RpmVerifyBehaviors() {
            //this.nodepsField = false;
            //this.nodigestField = false;
            //this.nofilesField = false;
            //this.noscriptsField = false;
            //this.nosignatureField = false;
            //this.nolinktoField = false;
            //this.nomd5Field = false;
            //this.nosizeField = false;
            //this.nouserField = false;
            //this.nogroupField = false;
            //this.nomtimeField = false;
            //this.nomodeField = false;
            //this.nordevField = false;
            //this.noconfigfilesField = false;
            //this.noghostfilesField = false;
        }
        [XmlAttribute]
        public bool nodeps {
            get {
                return this.nodepsField.Value;
            }
            set {
                this.nodepsField = value;
            }
        }
        [XmlAttribute]
        public bool nodigest {
            get {
                return this.nodigestField.Value;
            }
            set {
                this.nodigestField = value;
            }
        }
        [XmlAttribute]
        public bool nofiles {
            get {
                return this.nofilesField.Value;
            }
            set {
                this.nofilesField = value;
            }
        }
        [XmlAttribute]
        public bool noscripts {
            get {
                return this.noscriptsField.Value;
            }
            set {
                this.noscriptsField = value;
            }
        }
        [XmlAttribute]
        public bool nosignature {
            get {
                return this.nosignatureField.Value;
            }
            set {
                this.nosignatureField = value;
            }
        }
        [XmlAttribute]
        public bool nolinkto {
            get {
                return this.nolinktoField.Value;
            }
            set {
                this.nolinktoField = value;
            }
        }
        [XmlAttribute]
        public bool nomd5 {
            get {
                return this.nomd5Field.Value;
            }
            set {
                this.nomd5Field = value;
            }
        }
        [XmlAttribute]
        public bool nosize {
            get {
                return this.nosizeField.Value;
            }
            set {
                this.nosizeField = value;
            }
        }
        [XmlAttribute]
        public bool nouser {
            get {
                return this.nouserField.Value;
            }
            set {
                this.nouserField = value;
            }
        }
        [XmlAttribute]
        public bool nogroup {
            get {
                return this.nogroupField.Value;
            }
            set {
                this.nogroupField = value;
            }
        }
        [XmlAttribute]
        public bool nomtime {
            get {
                return this.nomtimeField.Value;
            }
            set {
                this.nomtimeField = value;
            }
        }
        [XmlAttribute]
        public bool nomode {
            get {
                return this.nomodeField.Value;
            }
            set {
                this.nomodeField = value;
            }
        }
        [XmlAttribute]
        public bool nordev {
            get {
                return this.nordevField.Value;
            }
            set {
                this.nordevField = value;
            }
        }
        [XmlAttribute]
        public bool noconfigfiles {
            get {
                return this.noconfigfilesField.Value;
            }
            set {
                this.noconfigfilesField = value;
            }
        }
        [XmlAttribute]
        public bool noghostfiles {
            get {
                return this.noghostfilesField.Value;
            }
            set {
                this.noghostfilesField = value;
            }
        }
    }

}

