﻿using Microsoft.AspNetCore.Routing;
using System.Text.RegularExpressions;

namespace Web.Demo.Infrastructure
{
    public class SlugifyParameterTransformer : IOutboundParameterTransformer
    {
        public string TransformOutbound(object value)
        {
            if (value == null)
            {
                return null;
            }

            var a = Regex.Replace(value.ToString(), "([a-z])([A-Z])", "$1-$2").ToLower();

            return a;
        }
    }
}
