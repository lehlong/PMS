using PROJECT.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Core.Models.CF
{
    public class T_CF_XBND : BaseEntity
    {
        [Key]
        public string PKID { get; set; }
        public string DESCRIPTION { get; set; }
        public string COMPANY_CODE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string DOC_TYPE { get; set; }
        public string SALES_ORG { get; set; }
        public string PLANT_CODE { get; set; }
        public string BATCH_CODE { get; set; }
        public string STORE_LOC { get; set; }
        public string SHPOINT_CODE { get; set; }
        public string VENDOR_CODE1 { get; set; }
        public string TRANSMODE_CODE { get; set; }
        public string SHTYPE_CODE { get; set; }
        public string POTYPE { get; set; }
        public string ROUTE_CODE { get; set; }
    }
}
