using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.AD
{
    public class T_AD_FORM : BaseEntity
    {
        [Key]
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string NOTES { get; set; }

    }
}
