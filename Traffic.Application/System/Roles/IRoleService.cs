using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Traffic.ViewModels.System.Roles;

namespace Traffic.Application.System.Roles
{
    public interface IRoleService
    {
        Task<List<RoleVm>> GetAll();
    }
}