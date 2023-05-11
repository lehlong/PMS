using PROJECT.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace PROJECT.Core.Models.MD
{
    public class T_MD_UNIT : BaseEntity
    {
        [Key]
        public string CODE { get; set; }
        public string TEXT { get; set; }
        public bool ACTIVE { get; set; }
    }
}
