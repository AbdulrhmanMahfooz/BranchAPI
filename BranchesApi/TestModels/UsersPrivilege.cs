using System;
using System.Collections.Generic;

#nullable disable

namespace BranchesApi.TestModels
{
    public partial class UsersPrivilege
    {
        public short CompanyNo { get; set; }
        public short UserNo { get; set; }
        public int PageNo { get; set; }
        public bool Adding { get; set; }
        public bool Modifying { get; set; }
        public bool Deleting { get; set; }
        public bool Displaying { get; set; }

        public virtual User UserNoNavigation { get; set; }
    }
}
