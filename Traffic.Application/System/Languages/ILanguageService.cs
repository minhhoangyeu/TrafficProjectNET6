using System.Collections.Generic;
using System.Threading.Tasks;
using Traffic.ViewModels.Common;
using Traffic.ViewModels.System.Languages;

namespace Traffic.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}