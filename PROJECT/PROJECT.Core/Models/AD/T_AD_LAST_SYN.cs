using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.AD
{
    public class T_AD_LAST_SYN :BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public DateTime LAST_SYN_VEHICLE { get; set; }
        public DateTime LAST_SYN_DCNB { get; set; }

    }
}
