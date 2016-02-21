using System.Collections.Generic;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Mvc.Presentation;
using ViewModelResolver.Presentation;

namespace Pentia.ViewRenderings.ViewModels
{
    public class BuildingViewModel : MvcViewModel<BuildingViewModel>
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public string MineralCost { get; set; }

        public List<GameUnitViewModel> ProductionUnits { get; set; }

        public BuildingViewModel()
        {
        }
    }
}