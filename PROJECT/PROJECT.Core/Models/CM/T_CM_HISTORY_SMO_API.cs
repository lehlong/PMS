using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.CM
{
    public class T_CM_HISTORY_SMO_API : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string C_FUNCTION { get; set; }
        public string PARAMETER { get; set; }
        public string RESULT { get; set;}
    }
}
