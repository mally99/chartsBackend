//using System;
//using System.Linq;
//using System.Net.Http;
//using System.Security.Claims;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web.Http.Controllers;
//using System.Web.Http.Filters;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using IAuthorizationFilter = System.Web.Http.Filters.IAuthorizationFilter;
//namespace MyWebApi.Models
//{
//    public class ClaimRequirementFilter : IAuthorizationFilter
//    {
//        readonly Claim _claim;

//        public ClaimRequirementFilter(Claim claim)
//        {
//            _claim = claim;
//        }

//        //bool AllowMultiple => throw new NotImplementedException();

//        bool IFilter.AllowMultiple => throw new NotImplementedException();

//        public void OnAuthorization(AuthorizationFilterContext context)
//        {
//            var hasClaim = context.HttpContext.User.Claims.Any(c => c.Type == _claim.Type && c.Value == _claim.Value);
//            if (!hasClaim)
//            {
//                context.Result = new ForbidResult();
//            }
//        }

//        Task<HttpResponseMessage> IAuthorizationFilter.ExecuteAuthorizationFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
//        {
//            throw new NotImplementedException();
//        }
//    }

//}