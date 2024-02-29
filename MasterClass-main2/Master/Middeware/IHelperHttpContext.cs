using CommonModel;
using Microsoft.AspNetCore.Identity.Data;

namespace Master.Middeware
{
    public interface IHelperHttpContext
    {
        InforRequest GetInfoRequest(HttpContext request);
    }
}
