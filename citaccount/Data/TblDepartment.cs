using System;
using System.Collections.Generic;

#nullable disable

namespace citaccount.Data
{
    public partial class TblDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Del { get; set; }
    }
}
