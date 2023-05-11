using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_DICTIONARY : BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public string FK_DOMAIN { get; set; }
        public string CODE { get; set; }
        public string LANG { get; set; }
        public string C_VALUE { get; set; }
        public int C_ORDER { get; set; }
        public bool C_DEFAULT { get; set; }
        public bool ACTIVE { get; set; }
    }
}
