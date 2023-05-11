using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.AD
{
    public class T_AD_USER_HISTORY : BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public string USER_NAME { get; set; }
        public DateTime LOGON_TIME { get; set; }
        public string BROWSER { get; set; }
        public string VERSION { get; set; }
        public bool IS_MOBILE { get; set; }
        public string OS { get; set; }
        public string MOBILE_MODEL { get; set; }
        public string MANUFACTURER { get; set; }
        public string IP_ADDRESS { get; set; }
        public bool STATUS { get; set; }

    }
}
