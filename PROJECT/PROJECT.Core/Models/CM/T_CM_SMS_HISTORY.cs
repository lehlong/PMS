using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.CM
{
    public class T_CM_SMS_HISTORY : BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public bool TYPE { get; set; }
        public string HEADER_ID { get; set; }
        public string PHONE { get; set; }
        public string CONTENTS { get; set; }
        public bool IS_SEND { get; set; }
        public string MESSAGE { get; set; }
    }
}
