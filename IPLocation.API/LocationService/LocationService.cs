using IPLocation.API.Helpers;
using IPLocation.API.LocationService.Abstractions;
using IPLocation.Data.Models;
using Microsoft.Extensions.Configuration;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPLocation.API.LocationService {
   public class LocationService : ILocationService {
      private readonly LocationDbContext dbContext;
      private readonly IConfiguration configuration;

      public LocationService(LocationDbContext dbContext, IConfiguration configuration) {
         this.dbContext = dbContext;
         this.configuration = configuration;
      }

      public Location GetLocationByIp(string ip = null) {
         try {
            var ipDataApi = RestService.For<IIPDataApi>(configuration["IpDataApiDomain"]);

            Location location = null;

            if (!string.IsNullOrWhiteSpace(ip)) {
               location = dbContext.Locations.Find(ip);

               if (location == null) {

                  var task = ipDataApi.GetLocation(ip, configuration["IPLocation:LocationApiKey"]);
                  task.Wait();
                  if (task.IsCompletedSuccessfully) {
                     location = task.Result;
                     dbContext.Locations.Add(location);
                     dbContext.SaveChanges();
                  } else if (task.IsFaulted) {
                     throw new Exception($"Can't get {ip} Location info", task.Exception);
                  }

               }
               return location;
            } else {
               var task = ipDataApi.GetLocalLocation(configuration["IPLocation:LocationApiKey"]);
               task.Wait();
               if (task.IsCompletedSuccessfully) {
                  location = task.Result;
               } else if (task.IsFaulted) {
                  throw new Exception("Can't get local location info", task.Exception);
               }
               return location;
            }
         } catch (Exception ex) {
            throw new NotImplementedException();
         }
      }
   }
}
