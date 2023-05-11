using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.CF
{
    public class T_CF_MODUL : BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public string COMPANY_CODE { get; set; }
        public string MODUL_TYPE { get; set; }
    }
}
