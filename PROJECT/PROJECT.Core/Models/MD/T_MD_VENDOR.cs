using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_VENDOR : BaseEntity
    {
        [Key]
        public string CODE { get; set; }
        public string TEXT { get; set; }
        public bool ACTIVE { get; set; }
    }
}
