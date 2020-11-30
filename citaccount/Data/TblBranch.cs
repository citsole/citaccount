using System;
using System.Collections.Generic;

#nullable disable

namespace citaccount.Data
{
    public partial class TblBranch
    {
        public TblBranch()
        {
            TblTransections = new HashSet<TblTransection>();
        }

        public int Id { get; set; }
        public int? Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? Del { get; set; }

        public virtual ICollection<TblTransection> TblTransections { get; set; }
    }
}
