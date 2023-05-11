using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.AD
{
    public class T_AD_FORM_OBJECT : BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public string FK_FORM { get; set; }
        public string OBJECT_CODE { get; set; }
        public bool TYPE { get; set; }
    }
}
