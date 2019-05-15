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
        public ActionResult Index()
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            awardModelsList = Logic.GetAllAwardsViewModels(awardsList);
            userModelsList = Logic.GetAllUsersViewModels(usersList);

            return View(Logic.GetAllUsersViewModels(usersList));
        }


        
        // GET: Users/Create
        public ActionResult Add()
        {
            ViewBag.Awards = awardsList;

            User user = new User();
            return View(user);
        }


        // POST: Users/Create
        [HttpPost]
        public ActionResult Add(FormCollection collection)
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            User newUser = new User(collection["FirstName"], collection["LastName"], DateTime.Parse(collection["BirthDate"]));
            if (collection["Awards"] != null)
            {
                string[] awardsId = collection["Awards"].Split(',');
                foreach (var item in awardsId)
                {
                    Award award = Logic.GetAwardById(Convert.ToInt32(item));
                    newUser.Awards.Add(award);
                }
            }
            
            Logic.AddUser(newUser);

            return RedirectToAction("Index");
        }


        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();
            ViewBag.Awards = awardsList;

            User user = Logic.GetUserById(id);
            return View(user);
        }


        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

            return RedirectToAction("Index");
        }


        // GET: Users/Delete/5
        public ActionResult Remove(int id)
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            User user = Logic.GetUserById(id);
            Logic.RemoveUser(user);

            //return View(user);
            return RedirectToAction("Index");
        }

    }
}
