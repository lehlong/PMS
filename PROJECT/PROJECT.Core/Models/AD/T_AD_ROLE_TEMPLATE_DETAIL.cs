using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.AD
{
    public class T_AD_ROLE_TEMPLATE_DETAIL : BaseEntity
    {
        [Key]
        public string FK_RIGHT { get; set; }
        public string FK_ROLE { get; set; }
    }
}
