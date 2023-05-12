using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_VEHICLE : BaseEntity
    {
        [Key]
        public string CODE { get; set; }
        public string TRANSUNIT_CODE { get; set; }
        public string UNIT { get; set; }
        public bool ACTIVE { get; set; }
        public string OIC_PBATCH { get; set; }
        public string OIC_PTRIP { get; set; }
        public decimal CAPACITY { get; set; }
        public string TRANSMODE_CODE { get; set; }
        public virtual List<T_MD_VEHICLE_COMPARTMENT> VehicleCompartment { get; set; } = new List<T_MD_VEHICLE_COMPARTMENT>();
    }
}
