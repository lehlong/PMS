using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_CUSTOMER : BaseEntity
    {
        [Key]
        public string CUSTOMER_CODE { get; set; }
        public string TEXT { get; set; }
        public string SHORT_NAME { get; set; }
        public string ADDRESS { get; set; }
        public string VAT_NAMBER { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public bool ACTIVE { get; set; }
        public bool IS_SEND_ONLY_REJECT { get; set; }
    }
}
