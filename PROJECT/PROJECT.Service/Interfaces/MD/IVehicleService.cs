using PROJECT.Core.Models.MD;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.MD;
using PROJECT.Service.Extention;
using PROJECT.Service.Filter.MD;

namespace PROJECT.Service.Interfaces.MD
{
    public interface IVehicleService : IGenericService<T_MD_VEHICLE, T_MD_VEHICLE_Dto>
    {
        public Task<UnitFilter> Search(UnitFilter page);
        public Task<TranferObject> Update(T_MD_VEHICLE request);
    }
}
