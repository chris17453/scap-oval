using System;
using System.Xml; 
using System.Xml.Serialization; 
namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    //[XmlRoot ("substring")]
    public class recursive_base {
        [XmlElement(typeof(ObjectComponentType)        ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="object_component")]
        [XmlElement(typeof(VariableComponentType)      ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="variable_component")]
        [XmlElement(typeof(LiteralComponentType)       ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="literal_component")]
        [XmlElement(typeof(ArithmeticFunctionType)     ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="arithmetic")]
        [XmlElement(typeof(BeginFunctionType)          ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="begin")]
        [XmlElement(typeof(ConcatFunctionType)         ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="concat")]
        [XmlElement(typeof(EndFunctionType)            ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="end")]
        [XmlElement(typeof(EscapeRegexFunctionType)    ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="escape_regex")]
        [XmlElement(typeof(SplitFunctionType)          ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="split")]
        [XmlElement(typeof(SubstringFunctionType)      ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="substring")]
        [XmlElement(typeof(TimeDifferenceFunctionType) ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="time_difference")]
        [XmlElement(typeof(RegexCaptureFunctionType)   ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="regex_capture")]
        [XmlElement(typeof(UniqueFunctionType)         ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="unique")]
        [XmlElement(typeof(CountFunctionType)          ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="count")]
        [XmlElement(typeof(GlobToRegexFunctionType)    ,Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5",ElementName="glob_to_regex")]
        public object [] variable { get; set; } 
    }
}
