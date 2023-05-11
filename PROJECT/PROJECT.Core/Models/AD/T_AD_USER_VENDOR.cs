using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.AD
{
    public class T_AD_USER_VENDOR : BaseEntity
    {
        [Key]
        public string USER_NAME { get; set; }
        public string VENDOR_CODE { get; set; }
    }
}
