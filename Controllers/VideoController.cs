using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyInjectionMVC.Repository.Interfaces;

namespace DependencyInjectionMVC.Controllers
{
    public class VideoController : Controller
    {
        private readonly IVideoRepository _videoService;

        public VideoController(IVideoRepository videoService)
        {
            _videoService = videoService;
        }

        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }

    }
}
