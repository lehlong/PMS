using PROJECT.Core.Models.AD;
using PROJECT.Service.Commons;
using PROJECT.Service.Dtos.AD;
using PROJECT.Service.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PROJECT.Service.Extention.NodeTree;

namespace PROJECT.Service.Interfaces.AD
{
    public interface IRightService : IGenericService<T_AD_RIGHT, T_AD_RIGHT_Dto>
    {
        public Task<IList<NodeRight>> BuildTreeRight();
        public Task UpdateOrder(string request);
        public Task<T_AD_RIGHT> GetDetail(string pkid);
        public Task<TranferObject> Update(T_AD_RIGHT request);
        public Task<TranferObject> Create(T_AD_RIGHT request);
    }
}
