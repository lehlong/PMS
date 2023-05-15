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
    public class SaleOfficeService : GenericService<T_MD_SALEOFFICE, T_MD_SALEOFFICE_Dto>, ISaleOfficeService
    {
        private readonly AppDbContext _context;
        public SaleOfficeService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }
        public async Task<SaleOfficeFilter> Search(SaleOfficeFilter page)
        {
            var query = _context.T_MD_SALEOFFICE.AsQueryable();
            if (!String.IsNullOrEmpty(page.KeySearch))
            {
                query = query.Where(x => x.CODE.Contains(page.KeySearch) || x.TEXT.Contains(page.KeySearch));
            }
            if (!String.IsNullOrEmpty(page.Organize))
            {
                query = query.Where(x => x.COMPANY_CODE == page.Organize);
            }
            var count = query.Count();

            page.ItemCount = count;
            page.TotalPage = (int)Math.Ceiling(count / (decimal)page.PageSize);
            page.Data = await query.Skip((page.CurrentPage - 1) * page.PageSize).Take(page.PageSize).ToListAsync();

            return page;
        }
        public async Task<TranferObject> Update(T_MD_SALEOFFICE request)
        {
            try
            {
                _context.T_MD_SALEOFFICE.Update(request);
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
