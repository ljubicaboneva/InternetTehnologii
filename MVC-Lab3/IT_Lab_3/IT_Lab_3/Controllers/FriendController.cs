using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IT_Lab_3.Models;


namespace IT_Lab_3.Controllers
{
    public class FriendController : Controller
    {
        // GET: Friend
        private static List<Friend> friends = new List<Friend>()
        {
            new Friend(){ Ime = "Ljubica Boneva", MestoZiveenje = "Strumica", ID_ = 21},
            new Friend(){ Ime = "Andrea Kacarska " , MestoZiveenje = "Berovo", ID_ = 1}
        };
        public ActionResult AllFriends()
        {
            
            return View(friends);
        }
       
        public ActionResult NewFriend()
        {
            Friend model = new Friend();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddFriend(Friend model)
        {
            if (Request.Form["save"] != null)
            {
                if (!ModelState.IsValid)
                {
                    return View("NewFriend", model);
                }

                friends.Add(model);
            }
          
                return View("AllFriends", friends);
            
        }

       
        public ActionResult UpdateFriend(int id)
        {
            var model = friends.ElementAt(id);
            model.id = id;
           
            return View(model);

        }

        [HttpPost]
        public ActionResult UpdateFriend(Friend model)
        {
            if (Request.Form["update"] != null)
            {
                if (!ModelState.IsValid)
                {
                    return View("UpdateFriend", model);
                }
                var forUpdate = friends.ElementAt(model.id);
                forUpdate.Ime = model.Ime;
                forUpdate.MestoZiveenje = model.MestoZiveenje;
                forUpdate.ID_ = model.ID_;
            }
           
            return View("AllFriends", friends);
        }

        public ActionResult DeleteFriend(int id)
        {
            friends.RemoveAt(id);
            return View("AllFriends", friends);
        }
       
    }
}