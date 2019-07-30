using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Job.EntityFrameworkCore;
using Job.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Job.Web.Mvc.Controllers
{

    public class HomeController : AbpController
    {
        public IActionResult Index()
        {
			var jobs = new HomeModel() { Id = 1, Title = "Developer" };

			return View(jobs);
        }
    }
}