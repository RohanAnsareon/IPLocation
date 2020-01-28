using IPLocation.Data.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPLocation.API.Helpers {
   public interface IIPDataApi {
      [Get("/{ip}")]
      Task<Location> GetLocation(string ip, [AliasAs("api-key")] string apiKey);

      [Get("")]
      Task<Location> GetLocalLocation([AliasAs("api-key")] string apiKey);
   }
}
