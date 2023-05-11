using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_CUSTOMER_TRANSFERED : BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public string CUSTOMER_CODE_SOURCE { get; set; }
        public string COMPANY_CODE_SOURCE { get; set;}
        public string COMPANY_CODE_DES { get; set;}
        public string CUSTOMER_CODE_DES { get; set; }
    }
}
