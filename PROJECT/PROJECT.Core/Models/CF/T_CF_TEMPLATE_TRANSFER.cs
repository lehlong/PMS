using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.CF
{
    public class T_CF_TEMPLATE_TRANSFER : BaseEntity
    {
        [Key]
        public string PKID { get; set; }    
        public string SMS_SOURCE_TEMPLATE { get; set; }
        public string EMAIL_SOURCE_TEMPLATE { get;set; }
        public string SUBJECT_SOURCE_TEMPLATE { get; set; }
        public string SMS_DES_TEMPLATE { get; set; }
        public string SUBJECT_DES_TEMPLATE { get; set; }
        public string EMAIL_DES_TEMPLATE { get; set; }
    }
}
