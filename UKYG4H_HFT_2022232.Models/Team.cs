using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKYG4H_HFT_2022232.Models
{
    internal class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        string Id { get; set; }
        string Name { get; set; }
        int LeagueId { get; set; }
        [NotMapped]
        public virtual League League { get; set; }
        [NotMapped]
        public virtual ICollection<Player> Players { get; set; }
    }
}
