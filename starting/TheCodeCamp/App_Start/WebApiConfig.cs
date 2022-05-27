﻿using Microsoft.Web.Http;
using Microsoft.Web.Http.Versioning;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TheCodeCamp
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
          // Web API configuration and services
          AutofacConfig.Register();

            config.AddApiVersioning(cfg =>
            {
                cfg.DefaultApiVersion = new ApiVersion(1, 1);
                cfg.AssumeDefaultVersionWhenUnspecified = true;
                cfg.ReportApiVersions = true;
                cfg.ApiVersionReader = new HeaderApiVersionReader("X-Version");
            });
    
          //change case of JSON
          config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
            new CamelCasePropertyNamesContractResolver();

          // Web API routes
          config.MapHttpAttributeRoutes();

      //    config.Routes.MapHttpRoute(
      //      name: "DefaultApi",
      //      routeTemplate: "api/{controller}/{id}",
      //      defaults: new { id = RouteParameter.Optional }
      //);
    }
  }
}
