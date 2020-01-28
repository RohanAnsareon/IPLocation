using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using IPLocation.API.LocationService.Abstractions;
using IPLocation.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IPLocation.API.Controllers {
   [Route("api/[controller]")]
   [ApiController]
   public class LocationController : ControllerBase {
      private readonly ILocationService locationService;

      public LocationController(ILocationService locationService) {
         this.locationService = locationService;
      }

      [HttpGet]
      public ActionResult Get() {
         try {
            var ipAddress = HttpContext.Connection.RemoteIpAddress;

            if (ipAddress.AddressFamily == AddressFamily.InterNetwork || ipAddress.AddressFamily == AddressFamily.InterNetworkV6)
               return new JsonResult(this.locationService.GetLocationByIp());
            else
               return new JsonResult(this.locationService.GetLocationByIp(ipAddress.ToString()));
         } catch (Exception ex) {
            return BadRequest(ex.Message);
         }
      }
   }
}
