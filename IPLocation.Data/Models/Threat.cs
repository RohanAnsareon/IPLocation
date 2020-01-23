using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace IPLocation.Data.Models {
   [DataContract]
   public class Threat {
      [DataMember(Name = "is_tor")]
      public bool IsTor { get; set; }
      [DataMember(Name = "is_proxy")]
      public bool IsProxy { get; set; }
      [DataMember(Name = "is_anonymous")]
      public bool IsAnonymous { get; set; }
      [DataMember(Name = "is_known_attacker")]
      public bool IsKnownAttacker { get; set; }
      [DataMember(Name = "is_known_abuser")]
      public bool IsKnownAbuser { get; set; }
      [DataMember(Name = "is_threat")]
      public bool IsThreat { get; set; }
      [DataMember(Name = "is_bogon")]
      public bool IsBogon { get; set; }
   }
}
