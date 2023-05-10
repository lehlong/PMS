using AutoMapper;
using Newtonsoft.Json;
using PROJECT.Core.Models.AD;
using PROJECT.Core;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.AD;
using PROJECT.Service.Extention;
using PROJECT.Service.Interfaces.AD;
using static PROJECT.Service.Extention.NodeTree;
using Microsoft.EntityFrameworkCore;

namespace PROJECT.Service.Implements.AD
{
    public class RightService : GenericService<T_AD_RIGHT, T_AD_RIGHT_Dto>, IRightService
    {
        private AppDbContext _context;
        public RightService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }

        public async Task<IList<NodeRight>> BuildTreeRight()
        {
            var lstNode = new List<NodeRight>();
            var dataRight = await _context.T_AD_RIGHT.ToListAsync();

            foreach (var item in dataRight.OrderBy(x => x.C_ORDER))
            {
                var node = new NodeRight()
                {
                    id = item.CODE,
                    pId = item.PARENT,
                    name = $"{item.CODE} - {item.NAME}",
                };
                lstNode.Add(node);
            }
            return lstNode;
        }
     
        public async Task UpdateOrder(string request)
        {
            try
            {
                var jsonData = JsonConvert.DeserializeObject<NodeRight[]>(request);
                for (var i = 0; i < jsonData.Length; i++)
                {
                    var item = await _context.T_AD_RIGHT.FirstOrDefaultAsync(x => x.CODE == jsonData[i].id);
                    if (item == null)
                    {
                        continue;
                    }
                    else
                    {
                        item.PARENT = jsonData[i].pId;
                        item.C_ORDER = i;
                    }
                }
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                this.Exception = ex;
                this.Status = false;
            }

        }
        public async Task<T_AD_RIGHT> GetDetail(string pkid)
        {
            return await _context.T_AD_RIGHT.FirstOrDefaultAsync(x => x.CODE == pkid);
        }

        public async Task<TranferObject> Update(T_AD_RIGHT request)
        {
            try
            {
                _context.T_AD_RIGHT.Update(request);
                await _context.SaveChangesAsync();
                return new TranferObject
                {
                    Status = true,
                    Message = new MessageObject
                    {
                        Message = "Thành công!",
                        MessageDetail = "Cập nhật thông tin quyền thành công!",
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
        public async Task<TranferObject> Create(T_AD_RIGHT request)
        {
            try
            {
                request.C_ORDER = 0;
                await _context.T_AD_RIGHT.AddAsync(request);
                await _context.SaveChangesAsync();
                return new TranferObject
                {
                    Status = true,
                    Message = new MessageObject
                    {
                        Message = "Thành công!",
                        MessageDetail = "Tạo mới thông tin quyền thành công!",
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
