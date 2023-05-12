using PROJECT.Core.Models.AD;
using PROJECT.Core.Models.MD;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.MD;
using PROJECT.Service.Extention;
using PROJECT.Service.Filter.AD;
using PROJECT.Service.Filter.MD;

namespace PROJECT.Service.Interfaces.MD
{
    public interface IDischardService : IGenericService<T_MD_DISCHARD, T_MD_DISCHARD_Dto>
    {
        public Task<DischardFilter> Search(DischardFilter page);
        public Task<TranferObject> Update(T_MD_DISCHARD request);
    }
}
