using System;
using System.Web.Mvc;
using MvcFormUtil.HtmlHelpers;
using Sessions.ViewModels;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;

namespace Sessions.Controllers
{
    public class SessionController : Controller
    {
        private string _viewPath = "/Components/Domain/Sessions/Views/Session/SessionView.cshtml";

        [HttpGet]
        public ActionResult SessionView()
        {
            var dataItem = Sitecore.Context.Database.GetItem(RenderingContext.Current.Rendering.DataSource);
            var viewModel = new SessionViewModel(dataItem ?? PageContext.Current.Item);
            return View(_viewPath, viewModel);
        }

        [HttpPost]
        [ValidateFormHandler]
        public ActionResult SessionView(SessionViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                // Store registration     
            }

            SessionViewModel vm = viewModel;
            try
            {
                var dataItem = Sitecore.Context.Database.GetItem(RenderingContext.Current.Rendering.DataSource);
                vm = new SessionViewModel(dataItem ?? PageContext.Current.Item);
                    
            }
            catch (Exception)
            {
                return View(_viewPath, vm);
            }
            return View(_viewPath, vm);
        }

    }
}