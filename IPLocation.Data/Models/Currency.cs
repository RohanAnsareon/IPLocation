﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace IPLocation.Data.Models {
   [DataContract]
   public class Currency {
      [DataMember(Name = "name")]
      public string Name { get; set; }
      [DataMember(Name = "code")]
      public string Code { get; set; }
      [DataMember(Name = "symbol")]
      public string Symbol { get; set; }
      [DataMember(Name = "native")]
      public string Native { get; set; }
      [DataMember(Name = "plural")]
      public string Plural { get; set; }
   }
}
