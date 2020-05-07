using System;
using System.Collections.Generic;

namespace ProjectWebDev.Domain.Entities
{
    public partial class Matches
    {
        public Matches()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public int? Ploeg1 { get; set; }
        public int? Ploeg2 { get; set; }
        public DateTime? Datum { get; set; }
        public int? StadiaId { get; set; }

        public virtual Clubs Ploeg1Navigation { get; set; }
        public virtual Clubs Ploeg2Navigation { get; set; }
        public virtual Stadia Stadia { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
