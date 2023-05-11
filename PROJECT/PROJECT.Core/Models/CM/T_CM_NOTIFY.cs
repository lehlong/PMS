using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.CM
{
    public class T_CM_NOTIFY : BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public string USER_NAME { get; set; }
        public string CONTENTS { get; set; }
        public string RAW_CONTENTS { get; set; }
        public bool IS_REAED { get; set;}
        public bool IS_COUNTED { get;set;}
    }
}
