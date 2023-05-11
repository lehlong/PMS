using PROJECT.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace PROJECT.Core.Models.AD
{
    public class T_AD_USER_RIGHT : BaseEntity
    {
        [Key]
        public Guid PKID { get; set; }
        public string USER_NAME { get; set; }
        public string FK_RIGHT { get; set; }
        public bool IS_ADD { get; set; }
        public bool IS_REMOVE { get; set; }

    }
}
