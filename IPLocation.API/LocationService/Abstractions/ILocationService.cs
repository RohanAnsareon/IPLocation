using IPLocation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPLocation.API.LocationService.Abstractions {
   public interface ILocationService {
      Location GetLocationByIp(string ip = null);
   }
}
