using Sitecore.Data;
using ViewModelResolver.Presentation;

namespace Pentia.ViewRenderings.ViewModels.Map
{
    public class BuildingViewModelMap : MappedViewModelConfiguration<BuildingViewModel>
    {
        public BuildingViewModelMap()
        {
            SetClassPropertyFieldId(p => p.Name, new ID("{95BF8779-3E64-4913-BABF-987589A5CC96}"));
            SetClassPropertyFieldId(p => p.Description, new ID("{A1A9842B-11F0-4DEA-85F9-8BC7B8CAFC9B}"));
            SetClassPropertyFieldId(p => p.MineralCost, new ID("{3555EFB2-9C58-484C-9C21-5D3B1D727B2E}"));
            SetClassPropertyFieldId(p => p.ProductionUnits, new ID("{01416E95-30BA-469A-BA3B-391A0FC32260}"));
        }
    }
}
