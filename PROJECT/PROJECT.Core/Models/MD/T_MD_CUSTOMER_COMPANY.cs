using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_CUSTOMER_COMPANY : BaseEntity
    {
        [Key]
        public string CUSTOMER_CODE { get; set; }
        public string COMPANY_CODE { get; set; }
        public bool ACTIVE { get; set; }
        public bool IS_DEFAULT { get; set; }
    }
}
