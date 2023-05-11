using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.CF
{
    public class T_CF_TEMPLATE_NOTIFY : BaseEntity
    {
        [Key]
        public string PO_STATUS { get; set; }
        public string SMS_TEMPLATE { get; set; }
        public string SUBJECT_TEMPLATE { get; set; }
        public string EMAIL_TEMPLATE { get; set; }
    }
}
