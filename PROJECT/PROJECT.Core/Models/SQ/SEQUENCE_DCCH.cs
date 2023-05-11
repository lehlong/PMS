using System.ComponentModel.DataAnnotations;

namespace PROJECT.Core.Models.SQ
{
    public class SEQUENCE_DCCH
    {
        [Key]
        public int ID { get; set; }
        public DateOnly TIMES { get; set; }
    }
}
