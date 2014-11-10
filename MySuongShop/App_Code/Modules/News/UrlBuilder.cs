using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modules.News
{
    public class UrlBuilder
    {
        public static string RootUrl
        {
            get { return Library.Tools.UrlBuilder.RootUrl; }
        }

        public static string News()
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = "/tin-tuc.html";
            }
            else
            {
                url = "/Modules/News/Default.aspx";
            }

            return url;
        }

        public static string GetNewsPagging()
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = RootUrl +
                    "/tin-tuc" +
                    "/trang-{0}" +
                    ".html";
            }
            else
            {
                url = "/Modules/News/Default.aspx?page={0}";
            }

            return url;
        }
    }
}
