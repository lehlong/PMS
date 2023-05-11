using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PROJECT.Core;
using PROJECT.Core.Models.AD;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.AD;
using PROJECT.Service.Extention;
using PROJECT.Service.Interfaces.AD;
using static PROJECT.Service.Extention.NodeTree;

namespace PROJECT.Service.Implements.AD
{
    public class OrganizeService : GenericService<T_AD_ORGANIZE, T_AD_ORGANIZE_Dto>, IOrganizeService
    {
        private AppDbContext _context;
        public OrganizeService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }

        public async Task<IList<NodeOrganize>> BuildTreeOrganize()
        {
            var lstNode = new List<NodeOrganize>();
            var dataOrganize = await _context.T_AD_ORGANIZE.ToListAsync();

            foreach (var item in dataOrganize.OrderBy(x => x.C_ORDER))
            {
                var node = new NodeOrganize()
                {
                    id = item.COMPANY_CODE,
                    pId = item.PARENT_CODE,
                    name = item.NAME
                };
                lstNode.Add(node);
            }
            return lstNode;
        }

        public async Task UpdateOrder(List<NodeOrganize> request)
        {
            try
            {
                for (var i = 0; i < request.Count; i++)
                {
                    var item = await _context.T_AD_ORGANIZE.FirstOrDefaultAsync(x => x.COMPANY_CODE == request[i].id);
                    if (item == null)
                    {
                        continue;
                    }
                    else
                    {
                        item.PARENT_CODE = request[i].pId;
                        item.C_ORDER = i;
                    }
                }
                await _context.SaveChangesAsync();               
            }
            catch(Exception ex)
            {
               this.Exception = ex;
               this.Status = false;
            }

        }
        public async Task<T_AD_ORGANIZE> GetDetail(string code)
        {
            return await _context.T_AD_ORGANIZE.FirstOrDefaultAsync(x => x.COMPANY_CODE == code);   
        }

        public async Task<TranferObject> Update(T_AD_ORGANIZE request)
        {
            try
            {
                _context.T_AD_ORGANIZE.Update(request);
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
        public async Task<TranferObject> Create(T_AD_ORGANIZE request)
        {
            try
            {
                request.PARENT_CODE = "0000";
                request.C_ORDER = 0;
                await _context.T_AD_ORGANIZE.AddAsync(request);
                await _context.SaveChangesAsync();
                return new TranferObject
                {
                    Status = true,
                    Message = new MessageObject
                    {
                        Message = "Thành công!",
                        MessageDetail = "Tạo mới thông tin công ty phòng ban thành công!",
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
