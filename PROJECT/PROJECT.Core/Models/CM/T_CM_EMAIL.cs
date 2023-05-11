using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.CM
{
    public class T_CM_EMAIL : BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public string PO_CODE { get; set; }
        public string MODUL_TYPE { get; set; }
        public string STATUS { get; set; }
        public string EMAIL { get; set; }
        public string SUBJECT { get; set; }
        public string CONTENTS { get; set; }
        public bool IS_SEND { get; set; }
        public int NUMBER_RETRY { get; set; }

    }
}
