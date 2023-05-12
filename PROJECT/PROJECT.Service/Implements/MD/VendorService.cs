using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PROJECT.Core;
using PROJECT.Core.Models.AD;
using PROJECT.Core.Models.MD;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.MD;
using PROJECT.Service.Extention;
using PROJECT.Service.Filter.AD;
using PROJECT.Service.Filter.MD;
using PROJECT.Service.Interfaces.MD;

namespace PROJECT.Service.Implements.MD
{
    public class VendorService : GenericService<T_MD_VENDOR, T_MD_VENDOR_Dto>, IVendorService
    {
        private readonly AppDbContext _context;
        public VendorService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }
        public async Task<VendorFilter> Search(VendorFilter page)
        {
            var query = _context.T_MD_VENDOR.AsQueryable();
            if (page.KeySearch != "Empty")
            {
                query = query.Where(x => x.CODE.Contains(page.KeySearch) || x.TEXT.Contains(page.KeySearch));
            }
            var count = query.Count();

            page.ItemCount = count;
            page.TotalPage = (int)Math.Ceiling(count / (decimal)page.PageSize);
            page.Data = await query.Skip((page.CurrentPage - 1) * page.PageSize).Take(page.PageSize).ToListAsync();

            return page;
        }
        public async Task<TranferObject> Update(T_MD_VENDOR request)
        {
            try
            {
                _context.T_MD_VENDOR.Update(request);
                await _context.SaveChangesAsync();
                return new TranferObject
                {
                    Status = true,
                    Message = new MessageObject
                    {
                        Message = "Thành công!",
                        MessageDetail = "Cập nhật thông tin công ty phòng ban thành công!",
                        MessageType = "S",
                    }
                };
            }
            catch (Exception ex)
            {
                return new TranferObject
                {
                    Status = true,
                    Message = new MessageObject
                    {
                        Message = "Thất bại!",
                        MessageDetail = "Đã có lỗi xảy ra: " + ex.ToString(),
                        MessageType = "E",
                    }
                };
            }
        }
    }
}
