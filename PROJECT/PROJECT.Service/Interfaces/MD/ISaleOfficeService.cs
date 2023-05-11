using PROJECT.Core.Models.AD;
using PROJECT.Core.Models.MD;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.MD;
using PROJECT.Service.Extention;
using PROJECT.Service.Filter.AD;
using PROJECT.Service.Filter.MD;

namespace PROJECT.Service.Interfaces.MD
{
    public interface ISaleOfficeService : IGenericService<T_MD_SALEOFFICE, T_MD_SALEOFFICE_Dto>
    {
        public Task<SaleOfficeFilter> Search(SaleOfficeFilter page);
        public Task<TranferObject> Update(T_MD_SALEOFFICE request);
    }
}
