﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace EnigmaNet.AspNet.Extensions
{
    public static class HttpContextExtensions
    {
        public static string GetAreaName(this HttpContext httpContext)
        {
            var routeValues = httpContext.GetRouteData()?.Values;

            if (routeValues != null && routeValues.TryGetValue("area", out object area))
            {
                return area.ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
