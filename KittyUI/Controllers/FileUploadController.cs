using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KittyUI.Controllers
{
    [HandleError]
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult FileUpload()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult FileUpload(HttpPostedFileBase uploadFile)
        {
            if (uploadFile.ContentLength > 0)
            {
                string filePath = Path.Combine(HttpContext.Server.MapPath("../Uploads"),
                                               Path.GetFileName(uploadFile.FileName));
                uploadFile.SaveAs(filePath);
            }
            return View();
        }
    }
}