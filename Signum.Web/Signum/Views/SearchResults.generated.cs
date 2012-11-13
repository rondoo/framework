﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Signum.Web.Views
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 4 "..\..\Signum\Views\SearchResults.cshtml"
    using Signum.Engine;
    
    #line default
    #line hidden
    using Signum.Entities;
    
    #line 1 "..\..\Signum\Views\SearchResults.cshtml"
    using Signum.Entities.DynamicQuery;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Signum\Views\SearchResults.cshtml"
    using Signum.Entities.Reflection;
    
    #line default
    #line hidden
    using Signum.Utilities;
    using Signum.Web;
    
    #line 3 "..\..\Signum\Views\SearchResults.cshtml"
    using Signum.Web.Properties;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Signum/Views/SearchResults.cshtml")]
    public class SearchResults : System.Web.Mvc.WebViewPage<Context>
    {
        public SearchResults()
        {
        }
        public override void Execute()
        {





WriteLiteral("\r\n");


            
            #line 7 "..\..\Signum\Views\SearchResults.cshtml"
   
   QueryDescription queryDescription = (QueryDescription)ViewData[ViewDataKeys.QueryDescription];
   var entityColumn = queryDescription.Columns.SingleEx(a => a.IsEntity);
   Type entitiesType = Lite.Extract(entityColumn.Type);
   Implementations implementations = entityColumn.Implementations.Value;
   bool viewable = (bool)ViewData[ViewDataKeys.Navigate] && (implementations.IsByAll ? true : implementations.Types.Any(t => Navigator.IsNavigable(t, isSearchEntity: true)));
   bool allowMultiple = (bool)ViewData[ViewDataKeys.AllowMultiple];

   FilterMode filterMode = (FilterMode)ViewData[ViewDataKeys.FilterMode];
   
   ResultTable queryResult = (ResultTable)ViewData[ViewDataKeys.Results];
   Dictionary<int, CellFormatter> formatters = (Dictionary<int, CellFormatter>)ViewData[ViewDataKeys.Formatters];

   int columnsCount = queryResult.Columns.Count() + (viewable ? 1 : 0) + (allowMultiple ? 1 : 0);


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 23 "..\..\Signum\Views\SearchResults.cshtml"
 if (ViewData.ContainsKey(ViewDataKeys.MultipliedMessage))
{ 

            
            #line default
            #line hidden
WriteLiteral("    <tr class=\"sf-tr-multiply\">\r\n        <td class=\"sf-td-multiply ui-state-highl" +
"ight\" colspan=\"");


            
            #line 26 "..\..\Signum\Views\SearchResults.cshtml"
                                                          Write(columnsCount);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            <span class=\"ui-icon ui-icon-info\" style=\"float: left; margin-rig" +
"ht: .3em;\"></span>\r\n            ");


            
            #line 28 "..\..\Signum\Views\SearchResults.cshtml"
       Write(ViewData[ViewDataKeys.MultipliedMessage]);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");


            
            #line 31 "..\..\Signum\Views\SearchResults.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 33 "..\..\Signum\Views\SearchResults.cshtml"
 foreach (var row in queryResult.Rows)
{
    Lite entityField = row.Entity;

            
            #line default
            #line hidden
WriteLiteral("    <tr data-entity=\"");


            
            #line 36 "..\..\Signum\Views\SearchResults.cshtml"
                Write(entityField.Key());

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 37 "..\..\Signum\Views\SearchResults.cshtml"
         if (allowMultiple)
        {

            
            #line default
            #line hidden
WriteLiteral("            <td>\r\n                ");


            
            #line 40 "..\..\Signum\Views\SearchResults.cshtml"
           Write(Html.CheckBox(
                    Model.Compose("rowSelection", row.Index.ToString()),
                        new 
                        {
                            @class = "sf-td-selection", 
                            value = entityField.Id.ToString() + "__" + Navigator.ResolveWebTypeName(entityField.RuntimeType) + "__" + entityField.ToString() 
                        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n");


            
            #line 48 "..\..\Signum\Views\SearchResults.cshtml"
        }

            
            #line default
            #line hidden

            
            #line 49 "..\..\Signum\Views\SearchResults.cshtml"
         if (viewable)
        {

            
            #line default
            #line hidden
WriteLiteral("            <td>\r\n                ");


            
            #line 52 "..\..\Signum\Views\SearchResults.cshtml"
           Write(QuerySettings.EntityFormatRules.Last(fr => fr.IsApplyable(entityField)).Formatter(Html, entityField));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n");


            
            #line 54 "..\..\Signum\Views\SearchResults.cshtml"
        }

            
            #line default
            #line hidden

            
            #line 55 "..\..\Signum\Views\SearchResults.cshtml"
         foreach (var col in queryResult.Columns)
        {
            var value = row[col];
            var ft = formatters[col.Index];
            

            
            #line default
            #line hidden
WriteLiteral("            <td ");


            
            #line 60 "..\..\Signum\Views\SearchResults.cshtml"
           Write(ft.WriteDataAttribute(value));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                ");


            
            #line 61 "..\..\Signum\Views\SearchResults.cshtml"
           Write(ft.Formatter(Html, value));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n");


            
            #line 63 "..\..\Signum\Views\SearchResults.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tr>\r\n");


            
            #line 65 "..\..\Signum\Views\SearchResults.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 67 "..\..\Signum\Views\SearchResults.cshtml"
 if (queryResult.Rows.IsNullOrEmpty())
{

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n        <td colspan=\"");


            
            #line 70 "..\..\Signum\Views\SearchResults.cshtml"
                Write(columnsCount);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 70 "..\..\Signum\Views\SearchResults.cshtml"
                               Write(Resources.Signum_noResults);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n    </tr>\r\n");


            
            #line 72 "..\..\Signum\Views\SearchResults.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 74 "..\..\Signum\Views\SearchResults.cshtml"
   
    ViewData[ViewDataKeys.ElementsPerPage] = queryResult.ElementsPerPage;
    ViewData[ViewDataKeys.SearchControlColumnsCount] = columnsCount;


            
            #line default
            #line hidden

            
            #line 78 "..\..\Signum\Views\SearchResults.cshtml"
Write(Html.Partial(Navigator.Manager.PaginationView, Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


        }
    }
}
#pragma warning restore 1591
