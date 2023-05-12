using PROJECT.Core.Models.AD;
using PROJECT.Core.Models.MD;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.MD;
using PROJECT.Service.Extention;
using PROJECT.Service.Filter.AD;
using PROJECT.Service.Filter.MD;

namespace PROJECT.Service.Interfaces.MD
{
    public interface IMaterialService : IGenericService<T_MD_MATERIAL, T_MD_MATERIAL_Dto>
    {
        public Task<MaterialFilter> Search(MaterialFilter page);
        public Task<TranferObject> Update(T_MD_MATERIAL request);
    }
}
