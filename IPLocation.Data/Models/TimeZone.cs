using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace IPLocation.Data.Models {
   [DataContract]
   public class TimeZone {
      [DataMember(Name = "name")]
      public string Name { get; set; }
      [DataMember(Name = "abbr")]
      public string Abbr { get; set; }
      [DataMember(Name = "offset")]
      public string Offset { get; set; }
      [DataMember(Name = "is_dst")]
      public bool IsDst { get; set; }
   }
}
