using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.CM
{
    public class T_CM_SMS : BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public string PO_CODE { get; set; }
        public string MODEL_TYPE { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string USER_RECEIVED { get; set; }
        public string CONTENTS { get; set;}
        public bool IS_SEND { get; set; }
        public int NUMBER_READY { get; set; }
    }
}
