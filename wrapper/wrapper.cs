using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using oval;

public class oval_wrapper{
    static void Serializer_UnreferencedObject(object sender,UnreferencedObjectEventArgs e) {
        Console.WriteLine(string.Format("Unreferenced Object: {0},{1}",e.UnreferencedId,e.UnreferencedObject));
    }

    static void Serializer_UnknownNode(object sender,XmlNodeEventArgs e) {
        Console.WriteLine(string.Format("Unknown Node-Line: {0,-8},Pos{1,-10},Local: {2},Name: {3},NS: {4},Type: {5},Object: {6},Text: {7}",e.LineNumber,e.LinePosition,e.LocalName,e.Name,e.NamespaceURI,e.NodeType,e.ObjectBeingDeserialized,e.Text));
    }

    static void Serializer_UnknownElement(object sender,XmlElementEventArgs e) {
        Console.WriteLine(string.Format("Unknown Element: {0},{1},{2},{3},{4}",e.LineNumber,e.LinePosition,e.ObjectBeingDeserialized,e.Element,e.ExpectedElements));
    }


    static void Serializer_UnknownAttribute(object sender,XmlAttributeEventArgs e) {
        Console.WriteLine(string.Format("Unknown Attribute: {0},{1},{2},{3},{4}",e.Attr,e.ExpectedAttributes,e.LineNumber,e.LinePosition,e.ObjectBeingDeserialized));
    }


    public oval.SchemaVersionType schema_version(string platform,string value){
        SchemaVersionType _schema_version=new SchemaVersionType(){platform=platform,Value=value};
        return _schema_version;
    }
    public oval.GeneratorType generator(string product_name,string product_version,List<SchemaVersionType> schema_version_types,DateTime timestamp){
        GeneratorType _generator=new GeneratorType();
        _generator.product_name=product_name;
        _generator.product_version=product_version;
        _generator.schema_version=schema_version_types.ToArray();
        _generator.timestamp=timestamp;
        return _generator;
    }
    public static oval_definitions load(string path){
        oval.oval_definitions od= null;
        XmlSerializer serializer = new XmlSerializer(typeof(oval.oval_definitions));
        StreamReader reader = new StreamReader(path);
        serializer.UnknownAttribute+= Serializer_UnknownAttribute;
        serializer.UnknownElement+= Serializer_UnknownElement;
        serializer.UnknownNode+= Serializer_UnknownNode;
        serializer.UnreferencedObject+=Serializer_UnreferencedObject;

                      
        od = (oval.oval_definitions)serializer.Deserialize(reader );
        reader.Close();
        return od;
    }
}










