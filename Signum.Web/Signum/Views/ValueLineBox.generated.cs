﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
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
    using Signum.Entities;
    using Signum.Utilities;
    using Signum.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Signum/Views/ValueLineBox.cshtml")]
    public class ValueLineBox : System.Web.Mvc.WebViewPage<dynamic>
    {
        public ValueLineBox()
        {
        }
        public override void Execute()
        {

            
            #line 1 "..\..\Signum\Views\ValueLineBox.cshtml"
 using (var e = Html.TypeContext<ValueLineBoxModel>())
{
    if (e.Value.TopText.HasText())
    {
        
            
            #line default
            #line hidden
            
            #line 5 "..\..\Signum\Views\ValueLineBox.cshtml"
   Write(e.Value.TopText);

            
            #line default
            #line hidden
            
            #line 5 "..\..\Signum\Views\ValueLineBox.cshtml"
                         

            
            #line default
            #line hidden
WriteLiteral("        <div class=\'clearall\'></div>\r\n");


            
            #line 7 "..\..\Signum\Views\ValueLineBox.cshtml"
    }
    
            
            #line default
            #line hidden
            
            #line 8 "..\..\Signum\Views\ValueLineBox.cshtml"
Write(Html.HiddenRuntimeInfo(e, f => f.Related));

            
            #line default
            #line hidden
            
            #line 8 "..\..\Signum\Views\ValueLineBox.cshtml"
                                              

            
            #line default
            #line hidden
WriteLiteral("    <div style=\"display: none\">\r\n    \r\n        ");


            
            #line 11 "..\..\Signum\Views\ValueLineBox.cshtml"
   Write(Html.ValueLine(e, f => f.BoxType));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");


            
            #line 13 "..\..\Signum\Views\ValueLineBox.cshtml"
    switch (e.Value.BoxType)
    {
        case ValueLineBoxType.Boolean:
            
            
            #line default
            #line hidden
            
            #line 16 "..\..\Signum\Views\ValueLineBox.cshtml"
       Write(Html.ValueLine(e, f => f.BoolValue, vl => vl.LabelText = e.Value.FieldName));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Signum\Views\ValueLineBox.cshtml"
                                                                                        
            break;
        case ValueLineBoxType.Integer:
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Signum\Views\ValueLineBox.cshtml"
       Write(Html.ValueLine(e, f => f.IntValue, vl => vl.LabelText = e.Value.FieldName));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Signum\Views\ValueLineBox.cshtml"
                                                                                       
            break;
        case ValueLineBoxType.Decimal:
            
            
            #line default
            #line hidden
            
            #line 22 "..\..\Signum\Views\ValueLineBox.cshtml"
       Write(Html.ValueLine(e, f => f.DecimalValue, vl => vl.LabelText = e.Value.FieldName));

            
            #line default
            #line hidden
            
            #line 22 "..\..\Signum\Views\ValueLineBox.cshtml"
                                                                                           
            break;
        case ValueLineBoxType.DateTime:
            
            
            #line default
            #line hidden
            
            #line 25 "..\..\Signum\Views\ValueLineBox.cshtml"
       Write(Html.ValueLine(e, f => f.DateValue, vl => vl.LabelText = e.Value.FieldName));

            
            #line default
            #line hidden
            
            #line 25 "..\..\Signum\Views\ValueLineBox.cshtml"
                                                                                        
            break;
        case ValueLineBoxType.String:
            
            
            #line default
            #line hidden
            
            #line 28 "..\..\Signum\Views\ValueLineBox.cshtml"
       Write(Html.ValueLine(e, f => f.StringValue, vl => vl.LabelText = e.Value.FieldName));

            
            #line default
            #line hidden
            
            #line 28 "..\..\Signum\Views\ValueLineBox.cshtml"
                                                                                          
            break;
        default:
            throw new InvalidOperationException("ValueLineBoxType {0} does not exist".Formato(e.Value.BoxType));
    }
}
            
            #line default
            #line hidden
WriteLiteral(" ");


        }
    }
}
#pragma warning restore 1591
