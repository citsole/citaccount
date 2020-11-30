using System;
using System.Collections.Generic;

#nullable disable

namespace citaccount.Data
{
    public partial class TblStatus
    {
        public TblStatus()
        {
            TblTransections = new HashSet<TblTransection>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Del { get; set; }

        public virtual ICollection<TblTransection> TblTransections { get; set; }
    }
}
