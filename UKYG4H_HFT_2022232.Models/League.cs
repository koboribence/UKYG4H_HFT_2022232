using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKYG4H_HFT_2022232.Models
{
    public class League
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FantasyName { get; set; }
        public string Country { get; set; }
        public bool HasVAR { get; set; }
        [NotMapped]
        public virtual ICollection<Team> Teams { get; set; }

        public League(int id, string fantasyName, string country, bool hasVAR)
        {
            Id = id;
            FantasyName = fantasyName;
            Country = country;
            HasVAR = hasVAR;
        }
    }
}
