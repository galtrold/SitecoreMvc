using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Mvc.Presentation;
using ViewModelResolver.Presentation;

namespace Pentia.ViewRenderings.ViewModels
{
    public class GameUnitViewModel : MvcViewModel<GameUnitViewModel>
    {

        public string Description { get; set; }
        public string Race { get; set; }
        public string Attributes { get; set; }
        public string Life { get; set; }
        public string Shield { get; set; }
        public string Armor { get; set; }
        public string CargoSize { get; set; }

        public string Producer { get; set; }
        public string Requires { get; set; }
        public string CostMineral { get; set; }
        public string CostGas { get; set; }
        public string Supply { get; set; }
        public string BuildTime { get; set; }
        public string Upgrades { get; set; }
        public string Weapon { get; set; }
        public string Ability { get; set; }

        public GameUnitViewModel()
        {
            //Upgrades = this.Item.Fields[GetPropertyId(p => p.Upgrades)].Value;
            //Weapon = this.Item.Fields[GetPropertyId(p => p.Weapon)].Value;
            //Ability = this.Item.Fields[GetPropertyId(p => p.Ability)].Value;
        }

        public GameUnitViewModel(Item dataItem) : base(dataItem)
        {
        }

        public override void Initialize(Rendering rendering)
        {
            base.Initialize(rendering);
            Log.Debug("sds", this);
        }
    }
}