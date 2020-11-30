using System;
using System.Collections.Generic;

#nullable disable

namespace citaccount.Data
{
    public partial class TblAcc
    {
        public int Id { get; set; }
        public int? AccNo { get; set; }
        public string Name { get; set; }
        public bool? BalDebit { get; set; }
        public bool? BalCredit { get; set; }
        public int? Del { get; set; }
    }
}
