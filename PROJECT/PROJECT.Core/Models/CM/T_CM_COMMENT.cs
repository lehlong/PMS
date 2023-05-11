using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.CM
{
    public class T_CM_COMMENT : BaseEntity
    {
        [Key]
        public string CODE { get; set; }
        public string REFRENCE_ID { get; set; }
        public string CONTENTS { get; set;}
    }
}
