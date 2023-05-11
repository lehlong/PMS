using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_CONDITION : BaseEntity
    {
        [Key]
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string TYPE { get; set; }
        public bool MHGL_ALLOW_EDIT { get; set; }
        public bool MHGL_ALLOW_SHOW { get; set; }
        public bool XBTX_ALLOW_EDIT { get; set; }
        public bool XBTX_ALLOW_SHOW { get; set; }
        public bool XBND_ALLOW_EDIT { get; set; }
        public bool XBND_ALLOW_SHOW { get; set; }
        public bool TEST_ALLOW_EDIT { get; set; }
        public bool TEST_ALLOW_SHOW { get; set; }
        public bool ACTIVE { get; set; }
    }
}
