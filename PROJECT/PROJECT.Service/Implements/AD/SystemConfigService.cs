using AutoMapper;
using PROJECT.Core;
using PROJECT.Core.Models.AD;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.AD;
using PROJECT.Service.Extention;
using PROJECT.Service.Interfaces.MD;

namespace PROJECT.Service.Implements.MD
{
    public class SystemConfigService : GenericService<T_AD_SYSTEM_CONFIG, T_AD_SYSTEM_CONFIG_Dto>, ISystemConfigService
    {
        private readonly AppDbContext _context;
        public SystemConfigService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }       
        public async Task<TranferObject> Update(T_AD_SYSTEM_CONFIG request)
        {
            try
            {
                _context.T_AD_SYSTEM_CONFIG.Update(request);
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
