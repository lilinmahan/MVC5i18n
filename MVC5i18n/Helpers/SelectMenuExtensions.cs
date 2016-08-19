using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5i18n.Helpers
{
    public static class SelectMenuExtensions
    {
        public static MvcHtmlString SelectMenu(this HtmlHelper html, string name, object values, object htmlAttributes)
        {
            var selectedCulture = values;

            StringBuilder sb=new StringBuilder();
            sb.Append(
                @"<ul class='nav navbar-nav navbar-right'>
                        <li class='dropdown'>
                            <a href='#' class='dropdown-toggle' data-toggle='dropdown' role='button' aria-haspopup='true' aria-expanded='false'>
                            " + selectedCulture +
                @"<span class='caret'></span></a>
                            <ul class='dropdown-menu'>");

            sb.Append(
                $"<li><a class='language' href='#'>{"fr"}</a></li>");
            sb.Append(   
                $"<li><a class='language' href='#'>{"en"}</a></li>");
            sb.Append(   
                $"<li><a class='language' href='#'>{"ar"}</a></li>");
            return MvcHtmlString.Create(sb.ToString());
        }
    }
}