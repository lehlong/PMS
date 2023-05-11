using PROJECT.Core.Models.AD;
using PROJECT.Core.Models.MD;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.MD;
using PROJECT.Service.Extention;
using PROJECT.Service.Filter.AD;
using PROJECT.Service.Filter.MD;

namespace PROJECT.Service.Interfaces.MD
{
    public interface IUnitService : IGenericService<T_MD_UNIT, T_MD_UNIT_Dto>
    {
        public Task<UnitFilter> Search(UnitFilter page);
        public Task<TranferObject> Update(T_MD_UNIT request);
    }
}
