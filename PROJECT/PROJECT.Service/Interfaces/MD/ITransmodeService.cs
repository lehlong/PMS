using PROJECT.Core.Models.AD;
using PROJECT.Core.Models.MD;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.MD;
using PROJECT.Service.Extention;
using PROJECT.Service.Filter.AD;
using PROJECT.Service.Filter.MD;

namespace PROJECT.Service.Interfaces.MD
{
    public interface ITransmodeService : IGenericService<T_MD_TRANSMODE, T_MD_TRANSMODE_Dto>
    {
        public Task<TransmodeFilter> Search(TransmodeFilter page);
        public Task<TranferObject> Update(T_MD_TRANSMODE request);
    }
}
