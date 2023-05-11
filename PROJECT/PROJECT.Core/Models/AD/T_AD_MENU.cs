using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.AD
{
    public class T_AD_MENU : BaseEntity
    {
        [Key]
        public string CODE { get; set; }
        public string PARENT { get; set; }
        public int C_ORDER { get; set; }
        public string DESCRIPTION { get; set; }
        public string LINK { get; set; }
        public string FK_RIGHT { get; set; }
        public string ICON { get; set; }
      
    }
}
