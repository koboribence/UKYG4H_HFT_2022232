using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKYG4H_HFT_2022232.Models
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(League))]
        public int LeagueId { get; set; }
        [NotMapped]
        public virtual League League { get; set; }
        [NotMapped]
        public virtual ICollection<Player> Players { get; set; }
    }
}
