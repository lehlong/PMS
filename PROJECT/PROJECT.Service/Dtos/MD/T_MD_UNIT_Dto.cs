using AutoMapper;
using PROJECT.Core.Models.MD;
using PROJECT.Service.Commons.Mapping;

namespace PROJECT.Service.Dtos.MD
{
    public class T_MD_UNIT_Dto : IMapFrom
    {
        public string CODE { get; set; }
        public string TEXT { get; set; }
        public bool ACTIVE { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<T_MD_UNIT, T_MD_UNIT_Dto>().ReverseMap();
        }
    }
}
