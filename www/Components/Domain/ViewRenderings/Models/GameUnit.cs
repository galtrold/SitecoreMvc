using System.Web;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using Rendering = Sitecore.Mvc.Presentation.Rendering;

namespace Pentia.ViewRenderings.Models
{
    public sealed class GameUnit : RenderingModel
    {

        public string Description { get; set; }
        public string Race { get; set; }
        public string Attributes { get; set; }
        public string Life { get; set; }
        public string Shield { get; set; }
        public string Armor { get; set; }
        public string CargoSize { get; set; }

        public HtmlString Producer { get; set; }
        public HtmlString Requires { get; set; }
        public HtmlString CostMineral { get; set; }
        public HtmlString CostGas { get; set; }
        public HtmlString Supply { get; set; }
        public HtmlString BuildTime { get; set; }

        public GameUnit()
        {
         
        }

        public override void Initialize(Rendering rendering)
        {
            base.Initialize(rendering);
            Description = Item.Fields[Constants.Fields.Unit.Description].Value;
            Race = this.Item.Fields[Constants.Fields.Unit.Race].Value;
            Attributes = this.Item.Fields[Constants.Fields.Unit.Attributes].Value;
            Life = this.Item.Fields[Constants.Fields.Unit.Life].Value;
            Shield = this.Item.Fields[Constants.Fields.Unit.Shield].Value;
            Armor = this.Item.Fields[Constants.Fields.Unit.Armor].Value;
            CargoSize = this.Item.Fields[Constants.Fields.Unit.CargoSize].Value;

            Producer = new HtmlString(FieldRenderer.Render(this.Item, Constants.Fields.Unit.Producer));
            Requires = new HtmlString(FieldRenderer.Render(this.Item, Constants.Fields.Unit.Requires));
            CostMineral = new HtmlString(FieldRenderer.Render(this.Item, Constants.Fields.Unit.CostMinirel));
            CostGas = new HtmlString(FieldRenderer.Render(this.Item, Constants.Fields.Unit.CostGas));
            Supply = new HtmlString(FieldRenderer.Render(this.Item, Constants.Fields.Unit.Supply));
            BuildTime = new HtmlString(FieldRenderer.Render(this.Item, Constants.Fields.Unit.BuildTime));
        }
    }
}