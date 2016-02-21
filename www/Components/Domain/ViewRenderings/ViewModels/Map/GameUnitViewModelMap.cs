using Sitecore.Data;
using ViewModelResolver.Presentation;

namespace Pentia.ViewRenderings.ViewModels.Map
{
    public class GameUnitViewModelMap : MappedViewModelConfiguration<GameUnitViewModel>
    {
        public GameUnitViewModelMap()
        {
            SetClassPropertyFieldId(p => p.Name, new ID("{73FB136E-A40B-40FE-AF36-66F333270616}"));
            SetClassPropertyFieldId(p => p.Description, new ID("{DB78166D-0F55-4D73-92F4-A0E5F43B4015}"));
            SetClassPropertyFieldId(p => p.Race, new ID("{6F2B8810-991B-43C8-8CFD-A7F1B91089EE}"));
            SetClassPropertyFieldId(p => p.Life, new ID("{9679D39D-5618-4E6D-A5ED-B48EA2D92096}"));
            SetClassPropertyFieldId(p => p.Shield, new ID("{D00EEFB1-D8D6-43DB-9A55-51DD94D6CFC2}"));
            SetClassPropertyFieldId(p => p.Armor, new ID("{0065524E-F974-4556-B9FF-6D6EEE4E5736}"));
            SetClassPropertyFieldId(p => p.CargoSize, new ID("{F768F7C3-E460-4822-B539-DF358B6C5598}"));
            SetClassPropertyFieldId(p => p.Attributes, new ID("{ECFDD44A-781C-4F38-AB02-6B9D5C3D7971}"));
            SetClassPropertyFieldId(p => p.Producer, new ID("{7F80E36F-2137-4294-A17F-FBF5E29272B4}"));
            SetClassPropertyFieldId(p => p.Requires, new ID("{D981538D-C9C6-4889-B6C3-DF2832ECD331}"));
            SetClassPropertyFieldId(p => p.CostMineral, new ID("{C54DEF04-5E81-42DA-AEC7-C95C1A50077E}"));
            SetClassPropertyFieldId(p => p.CostGas, new ID("{778866AB-2ADB-4EA7-9057-B25DA79FCF19}"));
            SetClassPropertyFieldId(p => p.Supply, new ID("{4CF11979-1AC8-4DB4-98D5-1708326EAE94}"));
            SetClassPropertyFieldId(p => p.BuildTime, new ID("{5AD6D99A-8C56-48C1-90A5-95AB4BFB94FD}"));
            SetClassPropertyFieldId(p => p.Upgrades, new ID("{A00A931F-0DFD-46DA-9B18-AC69C4292FEB}"));
            SetClassPropertyFieldId(p => p.Weapon, new ID("{A9E912D2-5461-42E9-BEC5-6C15C7D64C89}"));
            SetClassPropertyFieldId(p => p.Ability, new ID("{06BBEEEF-91D9-46D1-91B3-7808EEBFD19B}"));
        }
    }
}