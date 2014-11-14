using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;

namespace Library.Tools
{
    public class CookieManager
    {
        public static void setCookie(Page page, string key, string value, bool isRoot)
        {
            HttpCookie cookie = new HttpCookie(key, HttpContext.Current.Server.UrlEncode(value));
            if (isRoot)
                cookie.Path = "/";
            else
                cookie.Path = page.Request.FilePath.Substring(0, page.Request.FilePath.LastIndexOf("/") + 1);
            page.Response.SetCookie(cookie);
        }
        public static void setCookie(Page page, string key, string value)
        {
            setCookie(page, key, value, true);
        }

        public static string getCookie(Page page, string key)
        {
            HttpCookie cookie = page.Request.Cookies[key];
            if (cookie != null)
                return HttpContext.Current.Server.UrlDecode(cookie.Value);
            return string.Empty;
        }

        public static void deleteCookie(Page page, string key)
        {
            HttpCookie cookie = page.Request.Cookies[key];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-10);
                page.Response.SetCookie(cookie);
            }
        }

        public static void deleteCookie(string key)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[key];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-10);
                HttpContext.Current.Response.SetCookie(cookie);
            }
        }

        
    }
}
