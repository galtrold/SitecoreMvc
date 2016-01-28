using System;
using System.Web.Mvc;
using Sessions.ViewModels;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;

namespace Sessions.Controllers
{
    public class SessionController : SitecoreController
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
        public ActionResult SessionView(SessionViewModel viewModel)
        {

            // Store registration 
               
            SessionViewModel vm = viewModel;
            try
            {
                var attendeeEmain = viewModel.Signup;
                var dataItem = Sitecore.Context.Database.GetItem(RenderingContext.Current.Rendering.DataSource);
                vm = new SessionViewModel(dataItem ?? PageContext.Current.Item) { Signup = attendeeEmain };
            }
            catch (Exception)
            {
                vm.Signup = "Damnit! Kunne ikke finde min datasource :(";
                return View(_viewPath, vm);
            }
            return View(_viewPath, vm);
        }

    }
}