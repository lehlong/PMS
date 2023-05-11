using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_VENDOR_VEHICLE : BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public string VENDOR_CODE { get; set; }
        public string VEHICLE_CODE { get; set; }
        public bool NGAY_OR_DEM { get; set; }
        public string HO { get; set; }
        public string TEN { get; set; }

    }
}
