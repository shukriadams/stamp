using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace Stamp.Controllers
{
    public class HomeController : Controller
    {
        #region MODELS

        public class PageViewModel
        {
            public string Page { get; set; }
        }

        public class PageListModel 
        {
            public IEnumerable<string> Pages { get; set; }
        }

        #endregion

        #region Actions

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            string dir = Server.MapPath("~/Views/Pages");

            string[] files = Directory.GetFiles(dir);

            List<string> pages = new List<string>();
            foreach (string file in files) {
                pages.Add(Path.GetFileNameWithoutExtension(file));
            }

            PageListModel model = new PageListModel 
            {
                Pages = pages
            };

            return View(model);
        }

        /// <summary>
        /// Loads a page from /Views/Page folder.
        /// </summary>
        /// <returns></returns>
        public ActionResult Page()
        {
            string page = Request.QueryString["page"];
            
            if (string.IsNullOrEmpty(page))
                throw new Exception("?page is required");
            
            PageViewModel model = new PageViewModel 
            { 
                Page = page
            };

            return View(model);
        }

        #endregion
    }
}
