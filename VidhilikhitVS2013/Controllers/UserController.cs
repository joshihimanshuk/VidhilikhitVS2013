using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidhilikhitVS2013.Models;

namespace VidhilikhitVS2013.Controllers
{
   
   
    public class UserController : Controller
    {

        VidhilikhitEntities3 VEntity = new VidhilikhitEntities3();
        // GET: User
        public  ActionResult Dummy()
        {
            return View();
        }
       
        public ActionResult Default()
        {
            return View();
        }

        public ViewResult Register()
        {
        //    List<string> obj = new List<string>();
        //    obj.Add("ASP.NET MVC");
        //    obj.Add("Angular JS");
        //    ViewBag.Cdata = new SelectList(obj);
        //    return View();
            var x = from n in VEntity.tblRegistrations select n;
            return View( x.ToList());
        }

        //[HttpPost]
        //public ContentResult AddUser(string Gender, FormCollection f)
        //{
        //    List<string> l = new List<string>();
        //    //f.ToString();
        //    //l.Add(f.ToString());
        //    string gender = f["Gender"];
        //    string state = f["State"];
        //    string Interest = f["Interest"];
        //    string agefrom = f["AgeFroms"];
        //    string ageto = f["AgeTo"];
        //    string status = f["Status"];
        //    //return Content(VEntity.Registrations.ToList().ToString());
        //    return Content($" \n Looking for {gender} {state} {Interest} {agefrom} {ageto} {status}" +"\n" +l);
        //    var x = from n in VEntity.tblRegistrations where n.FirstName.Contains("Rahul") select n;

        //}

        [HttpPost]
        public ActionResult Search(FormCollection f)
        {
            string gender = f["Gender"];
            string religion = f["Religion"];
            if (religion=="")
            {
                religion = null;
            }
            //var matching = items.Where(x => names.Contains(x.Name));
            //var match = VEntity.tblRegistrations.Where(y => y.FirstName.Contains("Rahul") || y.FirstName.Contains("Sumeet"));
            var match = VEntity.tblRegistrations.Where(y => y.Gender.Equals(gender) && y.Religion.Contains(religion));
            var dummy = from n in VEntity.tblRegistrations select n;
            return View(dummy.ToList());
        }



    }
}