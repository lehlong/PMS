using PROJECT.Core.Models.MD;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.MD;
using PROJECT.Service.Extention;
using PROJECT.Service.Filter.MD;

namespace PROJECT.Service.Interfaces.MD
{
    public interface IVendorService : IGenericService<T_MD_VENDOR, T_MD_VENDOR_Dto>
    {
        public Task<VendorFilter> Search(VendorFilter page);
        public Task<TranferObject> Update(T_MD_VENDOR request);
    }
}
