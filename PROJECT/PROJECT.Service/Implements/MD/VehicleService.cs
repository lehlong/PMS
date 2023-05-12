using AutoMapper;
using PROJECT.Core.Models.MD;
using PROJECT.Core;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.MD;
using PROJECT.Service.Extention;
using PROJECT.Service.Filter.MD;
using PROJECT.Service.Interfaces.MD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PROJECT.Service.Implements.MD
{
    public class VehicleService : GenericService<T_MD_VEHICLE, T_MD_VEHICLE_Dto>, IVehicleService
    {
        private readonly AppDbContext _context;
        public VehicleService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }
        public async Task<UnitFilter> Search(UnitFilter page)
        {
            var query = _context.T_MD_VEHICLE.AsQueryable();
            if (page.KeySearch != "Empty")
            {
                query = query.Where(x => x.CODE.Contains(page.KeySearch));
            }
            var count = query.Count();

            page.ItemCount = count;
            page.TotalPage = (int)Math.Ceiling(count / (decimal)page.PageSize);
            page.Data = await query.Skip((page.CurrentPage - 1) * page.PageSize).Take(page.PageSize).ToListAsync();

            return page;
        }

        public async Task<TranferObject> Update(T_MD_VEHICLE request)
        {
            try
            {
                _context.T_MD_VEHICLE.Update(request);
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
