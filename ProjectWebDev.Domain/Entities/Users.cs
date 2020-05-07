using System;
using System.Collections.Generic;

namespace ProjectWebDev.Domain.Entities
{
    public partial class Users
    {
        public int UserId { get; set; }
        public DateTime? Datum { get; set; }
        public int? AantalTickest { get; set; }
        public int? MactchId { get; set; }

        public virtual Matches Mactch { get; set; }
    }
}
