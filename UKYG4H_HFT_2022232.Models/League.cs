using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKYG4H_HFT_2022232.Models
{
    internal class League
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        string FantasyName { get; set; }
        string Country { get; set; }
        bool HasVAR { get; set; }
        [NotMapped]
        public virtual ICollection<Team> Teams { get; set; }

    }
}
