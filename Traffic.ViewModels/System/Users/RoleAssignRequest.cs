using System;
using System.Collections.Generic;
using System.Text;
using Traffic.ViewModels.Common;

namespace Traffic.ViewModels.System.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}