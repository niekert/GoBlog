﻿using System.Web.Mvc;

namespace Blog.Areas.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        //private readonly IAuthenticationProvider _authProvider = new AuthenticationProvider();
        //private readonly BlogService _service = new BlogService();

        public ActionResult Index()
        {
            return View();
        }

        //[AllowAnonymous]
        //public ActionResult Login()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View();
        //}

        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(LoginModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var authenticated = _authProvider.Authenticate(model.Username, model.Password);
        //        if (authenticated)
        //        {
        //            return Redirect(Request.QueryString["ReturnUrl"]);
        //        }

        //        ModelState.AddModelError(string.Empty, "Username or Password Incorrect");
        //    }

        //    return View(model);
        //}

        //public ActionResult AddBlogEntry(EntryInput input)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        bool success = _service.AddBlogEntry(input.Header, input.HeaderSlug, input.Content);
        //        if (success)
        //        {
        //            return RedirectToAction("Index", "Blog", new { area = "" });
        //        }

        //        ModelState.AddModelError(string.Empty, "something went wrong andre");
        //    }

        //    return View("Index");
        //}

    }
}