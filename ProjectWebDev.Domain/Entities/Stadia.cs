using System;
using System.Collections.Generic;

namespace ProjectWebDev.Domain.Entities
{
    public partial class Stadia
    {
        public Stadia()
        {
            Matches = new HashSet<Matches>();
        }

        public int Id { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }
        public int? Plaatsen { get; set; }

        public virtual Plaatsen PlaatsenNavigation { get; set; }
        public virtual ICollection<Matches> Matches { get; set; }
    }
}
