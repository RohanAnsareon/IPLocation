using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace IPLocation.Data.Models {
   [DataContract]
   public class Location {
      [DataMember(Name = "ip")]
      public string IP { get; set; }
      [DataMember(Name = "is_eu")]
      public bool IsEu { get; set; }
      [DataMember(Name = "city")]
      public string City { get; set; }
      [DataMember(Name = "region")]
      public string Region { get; set; }
      [DataMember(Name = "region_code")]
      public string RegionCode { get; set; }
      [DataMember(Name = "country_name")]
      public string CountryName { get; set; }
      [DataMember(Name = "country_code")]
      public string CountryCode { get; set; }
      [DataMember(Name = "continent_name")]
      public string ContinentName { get; set; }
      [DataMember(Name = "continent_code")]
      public string ContinentCode { get; set; }
      [DataMember(Name = "latitude")]
      public double Latitude { get; set; }
      [DataMember(Name = "longitude")]
      public double Longitude { get; set; }
      [DataMember(Name = "postal")]
      public string Postal { get; set; }
      [DataMember(Name = "calling_code")]
      public string CallingCode { get; set; }
      [DataMember(Name = "flag")]
      public string Flag { get; set; }
      [DataMember(Name = "emoji_flag")]
      public string EmojiFlag { get; set; }
      [DataMember(Name = "emoji_unicode")]
      public string EmojiUnicode { get; set; }
      [DataMember(Name = "asn")]
      public ASN Asn { get; set; }
      [DataMember(Name = "languages")]
      public List<Language> Languages { get; set; }
      [DataMember(Name = "currency")]
      public Currency Currency { get; set; }
      [DataMember(Name = "time_zone")]
      public TimeZone TimeZone { get; set; }
      [DataMember(Name = "threat")]
      public Threat Threat { get; set; }
      [DataMember(Name ="count")]
      public int Count { get; set; }
   }
}
