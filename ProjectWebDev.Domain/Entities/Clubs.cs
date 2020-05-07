using System;
using System.Collections.Generic;

namespace ProjectWebDev.Domain.Entities
{
    public partial class Clubs
    {
        public Clubs()
        {
            MatchesPloeg1Navigation = new HashSet<Matches>();
            MatchesPloeg2Navigation = new HashSet<Matches>();
        }

        public int Id { get; set; }
        public string Naam { get; set; }
        public int? StadiaId { get; set; }
        public byte[] Logo { get; set; }

        public virtual ICollection<Matches> MatchesPloeg1Navigation { get; set; }
        public virtual ICollection<Matches> MatchesPloeg2Navigation { get; set; }
    }
}
