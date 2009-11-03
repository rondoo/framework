﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;
using Signum.Utilities;

namespace Signum.Web
{
    public delegate string GetWidgetDelegate(HtmlHelper helper, object entity, string partialViewName, string prefix);

    public class WidgetNode
    {
        public int Count { get; set; }
        public string Content { get; set; }
    }

    public static class WidgetsHelper
    {
        public static event GetWidgetDelegate GetWidgetsForView;

        public static WidgetNode GetWidgetsListForViewName(this HtmlHelper helper, object entity, string partialViewName, string prefix)
        {
            List<string> widgets = new List<string>();
            if (GetWidgetsForView != null)
                widgets.AddRange(GetWidgetsForView.GetInvocationList()
                    .Cast<GetWidgetDelegate>()
                    .Select(d => d(helper, entity, partialViewName, prefix))
                    .NotNull().ToList());
            return new WidgetNode
            {
                Count = widgets.Count(),
                Content = WidgetsToString(helper, widgets)
            };
        }

        public static string GetWidgetsForViewName(this HtmlHelper helper, object entity, string partialViewName, string prefix)
        {
            List<string> widgets = new List<string>();
            if (GetWidgetsForView != null)
                widgets.AddRange(GetWidgetsForView.GetInvocationList()
                    .Cast<GetWidgetDelegate>()
                    .Select(d => d(helper, entity, partialViewName, prefix))
                    .NotNull().ToList());

            return WidgetsToString(helper, widgets);
        }

        private static string WidgetsToString(HtmlHelper helper, List<string> widgets)
        {
            if (widgets == null || widgets.Count == 0)
                return "";

            StringBuilder sb = new StringBuilder();

            foreach (string widget in widgets)
            {
                if (widget != "")
                    sb.AppendLine(widget);
            }

            return sb.ToString();
        }
    }
}
