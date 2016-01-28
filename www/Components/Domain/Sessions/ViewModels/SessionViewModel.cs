using System.ComponentModel.DataAnnotations;
using System.Web;
using PT.Framework.SitecoreExtensions;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Sessions.ViewModels
{
    public class SessionViewModel
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public HtmlString Text { get; set; }

        public string Signup { get; set; }

        public SessionViewModel()
        {
        }
        public SessionViewModel(Item item)
        {
            Subject = item.GetString(new ID(Constants.Fields.Session.Subject));
            Description = item.GetString(new ID(Constants.Fields.Session.Description));
            Text = new HtmlString(item.GetString(new ID(Constants.Fields.Session.Text)));

        }
    }
}