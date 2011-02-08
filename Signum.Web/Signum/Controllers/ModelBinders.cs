﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Signum.Entities.Reflection;
using Signum.Entities;
using Signum.Utilities;
using System.Text.RegularExpressions;
using Signum.Engine;
using Signum.Web.Properties;

namespace Signum.Web.Controllers
{
    public class LiteModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext) 
        {
             Type cleanType = Reflector.ExtractLite(bindingContext.ModelType);
             if (cleanType != null)
             {
                 string value = controllerContext.HttpContext.Request[bindingContext.ModelName];
                 if (value == null)
                 {
                     object routeValue = controllerContext.RouteData.Values[bindingContext.ModelName];
                     if (routeValue is Lite)
                         return routeValue;
                     else if(routeValue is int)
                         return Lite.Create(cleanType, (int)routeValue);
                     else
                         value = (string)routeValue;
                 }
                 int id;
                 if (int.TryParse(value, out id))
                     return Lite.Create(cleanType, id);

                 return TypeLogic.ParseLite(cleanType, value);
             }
             return base.BindModel(controllerContext, bindingContext);
        }
    }

    public class DateModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            string value = controllerContext.HttpContext.Request[bindingContext.ModelName];
            Match m = Regex.Match(value, @"^(?<year>\d{4})-(?<month>\d{2})-(?<day>\d{2})$");

            if (m == null) return base.BindModel(controllerContext, bindingContext);

            return new DateTime(
                int.Parse(m.Groups["year"].Value),
                int.Parse(m.Groups["month"].Value),
                int.Parse(m.Groups["day"].Value),
                0,0,0,                    
                TimeZoneManager.Mode == TimeZoneMode.Local ? DateTimeKind.Local : DateTimeKind.Utc);
        }
    }   
}
