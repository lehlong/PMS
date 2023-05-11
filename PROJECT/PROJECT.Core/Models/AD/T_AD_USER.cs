using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using PROJECT.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace PROJECT.Core.Models.AD
{
    public class T_AD_USER : BaseEntity
    {
        [Key]
        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        public string FULL_NAME { get; set; }
        public string EMAIL { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE { get; set; }
        public string CHUC_VU { get; set; }
        public string NOTES { get; set; }
        public bool ACTIVE { get; set; }
        public bool OTP_VERIFY { get; set; }
        public string USER_TYPE { get; set; }
        public string COMPANY_CODE { get; set; }
        public bool IS_MODIFY_RIGHT { get; set; }
        public string SALEOFFICE_CODE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string USER_SAP { get; set; }
        public string PASSWORD_SAP { get; set; }
        public DateTime? LAST_CHANGE_PASS_DATE { get; set; }
    }
}
