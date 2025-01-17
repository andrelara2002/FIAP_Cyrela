﻿using Microsoft.AspNetCore.Mvc;

namespace CyrelaServices.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("")]
    [Route("Home")]
    [Route("Home/Index")]
    [Route("Home/Index.html")]
    [Route("Index")]
    [Route("Index.html")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return Redirect("/swagger/index.html");
        }
    }
}
