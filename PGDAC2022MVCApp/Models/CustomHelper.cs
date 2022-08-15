using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PGDAC2022MVCApp.Models
{
    public static class CustomHelper
    {

        public static IHtmlString Image(string src="",string alt="Image",
                                        string width="150 px",string height="120 px")
        {
            string htmlString = $"<img src='{src}' alt={alt} width={width} height={height}  />";

            return new MvcHtmlString(htmlString); 
        }

        //Extension Method as a Helper
        public static IHtmlString Button(this HtmlHelper helper,  string name="Button",
                                         string type="submit",string value = "Submit")
        {
            string htmlString = $"<input name={name} id={name} type={type} value='{value}'  />";

            return new MvcHtmlString(htmlString);
        }
       //Html.TextBox()
       //Html.Button()
    }
}