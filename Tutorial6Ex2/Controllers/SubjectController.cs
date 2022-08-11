using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tutorial6Ex2.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        public string Index()
        {
            return "This page is to show subject homepage";
        }
        public string subjects()
        {
            return " page is to show the list of subjects that the student is enrolled in";
        }
        public string contacts()
            {
            return " This is just a test";
}
        public string Details(string SubjectID)
        {
            return HttpUtility.HtmlEncode("Subject code: " + SubjectID);

        }
        public ActionResult Edit(int SubjectID)
        {
            //update subject ti the database
            return RedirectToAction("Index");
         }
        public ActionResult Delete(int SubjectID)
        {
            //delete student from the database whose id matches with specidied id
            return RedirectToAction("Index");
        }
    }
}