using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_PO : BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public string PO_NUMBER { get; set; }
        public string PO_ITEM { get; set; }
        public string PO_TYPE { get; set;}
        public string PO_ORG { get; set;}
        public string PO_GROUP { get; set;}
        public DateTime PO_DATE { get; set; }
        public string MATERIAL_CODE { get; set; }
        public string PLANT_CODE { get; set; }
        public decimal QUANTITY { get; set; }
        public string UNIT_CODE { get; set; }
        public string PO_LOCK { get; set; }
    }
}
