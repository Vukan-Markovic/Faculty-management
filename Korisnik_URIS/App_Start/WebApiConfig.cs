﻿using Korisnik_URIS.AuthFilters;
using Korisnik_URIS.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Korisnik_URIS
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services


            config.SuppressHostPrincipal();

            //messages
            config.MessageHandlers.Add(new PipelineTimerHandler());

            //auth
            config.Filters.Add(new BasicAuthFilterAttribute());
            config.Filters.Add(new TokenAuthFilter());

            config.Filters.Add(new AuthorizeAttribute());

            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}
