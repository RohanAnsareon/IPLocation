using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace IPLocation.Data.Models {
   [DataContract]
   public class Language {
      [DataMember(Name = "name")]
      public string Name { get; set; }
      [DataMember(Name = "native")]
      public string Native { get; set; }
   }
}
