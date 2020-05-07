using System;
using System.Collections.Generic;

namespace ProjectWebDev.Domain.Entities
{
    public partial class Plaatsen
    {
        public int StadiaId { get; set; }
        public int? Plaatsen1 { get; set; }

        public virtual Stadia Stadia { get; set; }
    }
}
