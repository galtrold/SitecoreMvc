using System.Runtime.CompilerServices;
using System.Web;
using PT.Framework.SitecoreExtensions;
using Sitecore.Data;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;

namespace Sessions.Models
{
    public class SessionModel : RenderingModel
    {
        public string Subject { get; set; }
        public string Description { get; set; }

        public HtmlString Text { get; set; }

        public SessionModel()
        {
            Subject = this.PageItem.GetString(new ID(Constants.Fields.Session.Subject));
            Description = this.PageItem.GetString(new ID(Constants.Fields.Session.Description));
            Text = new HtmlString(FieldRenderer.Render(this.PageItem, Constants.Fields.Session.Text));
        }
    }
}