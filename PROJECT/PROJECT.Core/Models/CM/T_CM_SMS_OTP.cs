using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.CM
{
    public class T_CM_SMS_OTP : BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public string USER_NAME { get; set; }
        public string MODUL_TYPE { get; set; }
        public string OTP_CODE { get; set; }
        public DateTime EFFECT_TIME { get; set; }
    }
}
