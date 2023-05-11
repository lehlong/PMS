using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_SO_CU_VENDOR : BaseEntity
    {
        [Key]
        public string SALEOFFICE_CUSTOMER_CODE { get; set; }
        public string VENDOR_CODE { get; set; }
        public bool IS_DEFAULT { get; set; }
    }
}
