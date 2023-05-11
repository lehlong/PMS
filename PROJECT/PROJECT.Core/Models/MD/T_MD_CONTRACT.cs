using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_CONTRACT : BaseEntity
    {
        [Key]
        public string CODE { get; set; }
        public string CONTRACT_TYPE { get; set; }
        public string SALEORG { get; set; }
        public string DC_CODE { get; set; }
        public string DIVISION_CODE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string INCOTERMS1 { get; set; }
        public string INCOTERMS2 { get; set; }
        public string PAYMENTTERM_CODE { get; set; }
        public DateTime VALID_FROM { get; set; }
        public DateTime VALID_TO { get; set;}
    }
}
