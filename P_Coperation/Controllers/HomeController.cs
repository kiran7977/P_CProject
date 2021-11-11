using P_Coperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;


namespace P_Coperation.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Pro_Cat model)
        {
            if (ModelState.IsValid)
            {
                using(var context= new ProductCategorydbEntities())
                {
                    TBlP_C pr = new TBlP_C();

                    pr.CatName = model.Catname;
                    pr.ProId = model.Proid;
                    pr.ProName = model.Proname;
                    context.TBlP_C.Add(pr);
                    context.SaveChanges();
                }
                
            }
            ModelState.Clear();
            return View();
        }
        public ActionResult list(string search, int?i)
        {
            using (var context = new ProductCategorydbEntities())
            {
                List<TBlP_C> list = context.TBlP_C.ToList();
                return View(context.TBlP_C.Where(x => x.CatName.StartsWith(search) || search == null).ToList().ToPagedList(i ?? 1, 4));
            }
               
        }
        //public ActionResult Edit(Pro_Cat p)
        //{
        //    if (p != null)
        //        return View(p);
        //    else
        //        return View();
        //}
        [HttpGet]
        public ActionResult edit(int Catid)
        {
            Pro_Cat model = new Pro_Cat();
            using (var context = new ProductCategorydbEntities())
            {
                var ab = context.TBlP_C.Find(Catid);


                model.Catname = ab.CatName;
                model.Proid = ab.ProId;
                model.Proname = ab.ProName;

            }
            return View(model);
        }

        [HttpPost]
        public ActionResult edit(Pro_Cat model)
        {

            using (var context = new ProductCategorydbEntities())
            {
                var ab = context.TBlP_C.Find(model.Catid);


                ab.CatName = model.Catname;
                ab.ProId= model.Proid;
                ab.ProName = model.Proname;
                context.SaveChanges();

            }
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int Catid)
        {
            using (var context = new ProductCategorydbEntities())
            {
                return View(context.TBlP_C.Where(x => x.CatId == Catid).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Delete(int Catid,FormCollection f)
        {
            using (var context = new ProductCategorydbEntities())
            {
                var res = context.TBlP_C.Where(m=>m.CatId == Catid).FirstOrDefault();
                context.TBlP_C.Remove(res);
                context.SaveChanges();

                var list = context.TBlP_C.ToList();
                return View();
            }


        }
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}
