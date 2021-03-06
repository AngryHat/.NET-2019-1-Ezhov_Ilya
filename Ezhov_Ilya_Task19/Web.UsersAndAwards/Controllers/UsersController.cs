﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Logic;
using Entities;
using Web.UsersAndAwards.Models;

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

            UserEditViewModel model = new UserEditViewModel(new User(), awardsList) ;
            return View(model);
        }


        // POST: Users/Create
        [HttpPost]
        public ActionResult Add(UserEditViewModel model)
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();
            
            List<Award> newAwards = new List<Award>();

            var checkedAwards = model.AwardsCheckBox.Where(a => a.IsChecked).ToList();
            newAwards = checkedAwards.Select(a => Logic.GetAwardById(a.id)).ToList();

            Logic.AddUser(model.FirstName, model.LastName, DateTime.Parse(model.BirthDate), newAwards);

            return RedirectToAction("Index");
        }


        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            UserEditViewModel model = new UserEditViewModel(Logic.GetUserById(id), awardsList);
            return View(model);
        }


        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(UserEditViewModel model)
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            User user = Logic.GetUserById(model.id);
            List<Award> newAwards = new List<Award>();

            var checkedAwards = model.AwardsCheckBox.Where(a => a.IsChecked).ToList();
            newAwards = checkedAwards.Select(a => Logic.GetAwardById(a.id)).ToList();

            Logic.UpdateUser(user, model.FirstName, model.LastName, DateTime.Parse(model.BirthDate), newAwards);

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
