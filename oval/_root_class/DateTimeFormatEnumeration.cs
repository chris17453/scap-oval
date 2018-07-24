using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public enum DateTimeFormatEnumeration {
        year_month_day,
        month_day_year,
        day_month_year,
        win_filetime,
        seconds_since_epoch,
        cim_datetime,
    }

}

