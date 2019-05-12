using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Logic;
using Entities;

namespace Web.UsersAndAwards.Controllers
{
    public class UsersController : Controller
    {
        private Logic Logic = new Logic();

        public static List<User> usersList;
        public static List<Award> awardsList;

        public static List<UserViewModel> userModelsList;
        public static List<AwardViewModel> awardModelsList;


        // GET: Users
        public ActionResult Users()
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            awardModelsList = Logic.GetAllAwardsViewModels(awardsList);
            userModelsList = Logic.GetAllUsersViewModels(usersList);

            return View(Logic.GetAllUsersViewModels(usersList));
        }
        // GET: Awards
        public ActionResult Awards()
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            awardModelsList = Logic.GetAllAwardsViewModels(awardsList);

            return View(Logic.GetAllAwardsViewModels(awardsList));
        }

        
        // GET: Users/Create
        public ActionResult AddUser()
        {
            ViewBag.Awards = awardsList;

            User user = new User();
            return View(user);
        }
        // GET: Awards/Create
        public ActionResult AddAward()
        {
            Award award = new Award();
            return View(award);
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult AddUser(FormCollection collection)
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            User newUser = new User(collection["FirstName"], collection["LastName"], DateTime.Parse(collection["BirthDate"]));
            string[] awardsId = collection["Awards"].Split(',');
            foreach (var item in awardsId)
            {
                Award award = Logic.GetAwardById(Convert.ToInt32(item));
                newUser.Awards.Add(award);
            }

            Logic.AddUser(newUser);

            return RedirectToAction("Users");
        }
        // POST: Awards/Create
        [HttpPost]
        public ActionResult AddAward(FormCollection collection)
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            Award newAward = new Award(collection["Title"], collection["Description"]);
            Logic.AddAward(newAward);

            return RedirectToAction("Awards");
        }

        // GET: Users/Edit/5
        public ActionResult EditUser(int id)
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();
            ViewBag.Awards = awardsList;

            User user = Logic.GetUserById(id);
            return View(user);
        }
        // GET: Awards/Edit/5
        public ActionResult EditAward(int id)
        {
            awardsList = Logic.GetAllAwards();

            Award award = Logic.GetAwardById(id);
            return View(award);
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult EditUser(int id, FormCollection collection)
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            User user = Logic.GetUserById(id);
            List<Award> newAwards = new List<Award>();
            
            if (collection["Awards"] != null)
            {
                string[] awardsId = collection["Awards"].Split(',');

                foreach (var item in awardsId)
                {
                    Award award = Logic.GetAwardById(Convert.ToInt32(item));
                    newAwards.Add(award);
                }
            } 

            Logic.UpdateUser(user, collection["FirstName"], collection["LastName"], DateTime.Parse(collection["BirthDate"]), newAwards);

            return RedirectToAction("Users");
        }
        // POST: Awards/Edit/5
        [HttpPost]
        public ActionResult EditAward(int id, FormCollection collection)
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            Award award = Logic.GetAwardById(id);

            Logic.UpdateAward(award, collection["Title"], collection["Description"]);

            return RedirectToAction("Awards");
        }

        // GET: Users/Delete/5
        public ActionResult RemoveUser(int id)
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            User user = Logic.GetUserById(id);
            Logic.RemoveUser(user);

            //return View(user);
            return RedirectToAction("Users");
        }
        // GET: Awards/Delete/5
        public ActionResult RemoveAward(int id)
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            Award award = Logic.GetAwardById(id);
            Logic.RemoveAward(award);

            //return View(user);
            return RedirectToAction("Awards");
        }
    }
}
