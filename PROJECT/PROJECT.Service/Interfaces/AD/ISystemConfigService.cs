using PROJECT.Core.Models.AD;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.AD;
using PROJECT.Service.Extention;
using PROJECT.Service.Filter.MD;

namespace PROJECT.Service.Interfaces.MD
{
    public interface ISystemConfigService : IGenericService<T_AD_SYSTEM_CONFIG, T_AD_SYSTEM_CONFIG_Dto>
    {
        public Task<TranferObject> Update(T_AD_SYSTEM_CONFIG request);
    }
}
