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
    public class PlantService : GenericService<T_MD_PLANT, T_MD_PLANT_Dto>, IPlantService
    {
        private readonly AppDbContext _context;
        public PlantService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }
        public async Task<PlantFilter> Search(PlantFilter page)
        {
            var query = _context.T_MD_PLANT.AsQueryable();
            if (!String.IsNullOrEmpty(page.KeySearch))
            {
                query = query.Where(x => x.CODE.Contains(page.KeySearch) || x.TEXT.Contains(page.KeySearch));
            }
            var count = query.Count();

            page.ItemCount = count;
            page.TotalPage = (int)Math.Ceiling(count / (decimal)page.PageSize);
            page.Data = await query.Skip((page.CurrentPage - 1) * page.PageSize).Take(page.PageSize).ToListAsync();

            return page;
        }
    }
}
