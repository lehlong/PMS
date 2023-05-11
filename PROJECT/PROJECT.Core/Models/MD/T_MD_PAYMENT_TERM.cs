using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_PAYMENT_TERM : BaseEntity
    {
        [Key]
        public string CODE { get; set; }
        public decimal PAYMENT_TERM_D { get; set; }
        public decimal PAYMENT_TERM_M { get; set; }
        public string TEXT { get; set; }
        public bool ACTIVE { get; set; }
    }
}
