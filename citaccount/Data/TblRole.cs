using System;
using System.Collections.Generic;

#nullable disable

namespace citaccount.Data
{
    public partial class TblRole
    {
        public TblRole()
        {
            TblUsers = new HashSet<TblUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Del { get; set; }

        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
