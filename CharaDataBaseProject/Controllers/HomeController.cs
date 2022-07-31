using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CharaDataBaseProject.Models;
using CharaDataBaseProject.ViewModels;

namespace CharaDataBaseProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var chara_name = new CharaName() { Name = "aaaaa" };
            //var skill = new Skill() { SkillTitle = "ice" };
            //var status = new Status() { HP = 50, MP = 50 };

            ////# 追記
            //var viewModel = new CharaViewModels
            //{
            //    CharaNames = chara_name,
            //    Skills = skill,
            //    Status = status
            //};

            //# 修正：引数を変更
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}