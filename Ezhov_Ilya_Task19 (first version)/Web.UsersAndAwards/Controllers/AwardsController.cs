using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Logic;
using Entities;
using Web.UsersAndAwards.Models;

namespace Web.UsersAndAwards.Controllers
{
    public class AwardsController : Controller
    {
        private Logic Logic = new Logic();
        
        public static List<Award> awardsList;

        public static List<AwardWebViewModel> awardModelsList;

        // GET: Awards
        public ActionResult Index()
        {
            awardsList = Logic.GetAllAwards();

            awardModelsList = Logic.GetAllAwards().Select(a => new AwardWebViewModel(a)).ToList();

            return View(Logic.GetAllAwardsViewModels(awardsList));
        }
        // GET: Awards/Create
        public ActionResult Add()
        {
            AwardWebViewModel award = new AwardWebViewModel(new Award());
            return View(award);
        }
        // POST: Awards/Create
        [HttpPost]
        public ActionResult Add(FormCollection collection)
        {
            awardsList = Logic.GetAllAwards();

            Award newAward = new Award(collection["Title"], collection["Description"]);
            Logic.AddAward(newAward);

            return RedirectToAction("Index");
        }
        // GET: Awards/Edit/5
        public ActionResult Edit(int id)
        {
            awardsList = Logic.GetAllAwards();

            AwardWebViewModel award = new AwardWebViewModel(Logic.GetAwardById(id));
            return View(award);
        }
        // POST: Awards/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            awardsList = Logic.GetAllAwards();

            Award award = Logic.GetAwardById(id);

            Logic.UpdateAward(award, collection["Title"], collection["Description"]);

            return RedirectToAction("Index");
        }
        // GET: Awards/Delete/5
        public ActionResult Remove(int id)
        {
            awardsList = Logic.GetAllAwards();

            Award award = Logic.GetAwardById(id);
            Logic.RemoveAward(award);

            //return View(user);
            return RedirectToAction("Index");
        }
    }
}