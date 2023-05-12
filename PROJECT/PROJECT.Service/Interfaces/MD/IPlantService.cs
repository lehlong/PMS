using PROJECT.Core.Models.AD;
using PROJECT.Core.Models.MD;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.MD;
using PROJECT.Service.Extention;
using PROJECT.Service.Filter.AD;
using PROJECT.Service.Filter.MD;

namespace PROJECT.Service.Interfaces.MD
{
    public interface IPlantService : IGenericService<T_MD_PLANT, T_MD_PLANT_Dto>
    {
        public Task<PlantFilter> Search(PlantFilter page);
    }
}
