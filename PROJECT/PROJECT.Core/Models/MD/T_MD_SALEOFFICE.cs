using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_SALEOFFICE : BaseEntity
    {
        [Key]
        public string CODE { get; set; }
        public string TEXT { get; set; }
        public string COMPANY_CODE { get; set; }
        public string DISCHARD_POINT { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public string DESCRIPTION { get; set; }
        public bool ACTIVE { get; set; }
    }
}
