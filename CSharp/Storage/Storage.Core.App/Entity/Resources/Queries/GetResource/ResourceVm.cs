using AutoMapper;
using Storage.Core.App.Common.Mappings;
using Storage.Core.Domain;

namespace Storage.Core.App.Entity.Resources.Queries.GetResource
{
    public class ResourceVm: IMapWith<Resource>
    {
        public int ResId { get; set; }
        public required string Name { get; set; }
        public bool IsArchive { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Resource, ResourceVm>()
               .ForMember(ent => ent.ResId, opt => opt.MapFrom(obj => obj.resId))
               .ForMember(ent => ent.Name, opt => opt.MapFrom(obj => obj.name))
               .ForMember(ent => ent.IsArchive, opt => opt.MapFrom(obj => obj.isArchive));
        }
    }
}