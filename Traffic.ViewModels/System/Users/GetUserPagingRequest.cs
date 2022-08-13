

using Traffic.ViewModels.Common;

namespace Traffic.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}