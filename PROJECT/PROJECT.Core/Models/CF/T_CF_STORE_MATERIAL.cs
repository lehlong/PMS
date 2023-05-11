using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.CF
{
    public class T_CF_STORE_MATERIAL : BaseEntity
    {
        [Key]
        public string STORE_CODE { get; set; }
        public string MATERIAL_CODE { get; set; }
    }
}
