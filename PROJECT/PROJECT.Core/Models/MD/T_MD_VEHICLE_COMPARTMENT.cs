using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_VEHICLE_COMPARTMENT : BaseEntity
    {
        [Key]
        public string CODE { get; set; }
        public string VEHICLE_CODE { get; set; }
        public string SEQ_NUMBER { get; set; }
        public decimal CAPACITY { get; set; }
        public virtual T_MD_VEHICLE Vehicle { get; set; }
    }
}
