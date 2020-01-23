using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace IPLocation.Data.Models {
   [DataContract]
   public class ASN {
      [DataMember(Name = "asn")]
      public string Asn { get; set; }
      [DataMember(Name = "name")]
      public string Name { get; set; }
      [DataMember(Name = "domain")]
      public string Domain { get; set; }
      [DataMember(Name = "route")]
      public string Route { get; set; }
      [DataMember(Name = "type")]
      public string Type { get; set; }
   }
}
