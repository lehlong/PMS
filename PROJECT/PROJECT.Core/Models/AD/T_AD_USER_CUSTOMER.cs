using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.AD
{
    public class T_AD_USER_CUSTOMER : BaseEntity
    {
        [Key]
        public string CUSTOMER_CODE { get; set; }
        public string USER_NAME { get; set; }
    }
}
