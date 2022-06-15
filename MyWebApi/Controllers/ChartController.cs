using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Security.Claims;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MyWebApi.Models;
using MyWebApi.Services;


namespace MyWebApi.Controllers
{
    
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ChartController : ApiController
    {
        public IChartService chartService;

        public ChartController(IChartService chartService)
        {
            this.chartService = chartService;
        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("ValuesBarChart")]
        [Auth()]
        public IHttpActionResult ValuesBarChart()
        {
            HttpContext httpContext = HttpContext.Current;
            string token= HttpContext.Current.Request.Headers["Authorization"];
            AuthorizationToken authorization = new AuthorizationToken(token);
            if (authorization.ValidToken())
            {
                return Ok(chartService.ValuesBarChart());
            }
            return BadRequest("bad request");
        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("ValuesLineChart")]
        [Auth()]
        public IHttpActionResult ValuesLineChart()
        {
            HttpContext httpContext = HttpContext.Current;
            string token = HttpContext.Current.Request.Headers["Authorization"];
            AuthorizationToken authorization = new AuthorizationToken(token);
            if (authorization.ValidToken())
            {
                return Ok(chartService.ValuesLineChart());
            }
            return BadRequest("bad request");
        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("ValuesScattedChart")]
        [Auth()]
        public IHttpActionResult ValuesScattedChart()
        {
            HttpContext httpContext = HttpContext.Current;
            string token = HttpContext.Current.Request.Headers["Authorization"];
            AuthorizationToken authorization = new AuthorizationToken(token);
            if (authorization.ValidToken())
            {
                return Ok(chartService.ValuesScattedChart());
            }
            return BadRequest("bad request");
        }
    }
    public class CustomAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public CustomAuthorizeAttribute(string j)
        {
            Console.WriteLine("Attribute Initialized");
        }

        public object Token { get; set; }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Console.WriteLine("OnAuthorization");
        }
    }
    public class Auth:Attribute//: TypeFilterAttribute
    {
        public Auth() //: base(typeof(ClaimRequirementFilter))
        {
            //HttpContext httpContext = HttpContext.Current;
            //string authHeader = httpContext.Request.Headers["Authorization"];
            //Arguments = new object[] { new Claim(claimType, claimValue) };
        }
    }

    public class ClaimRequirementFilter : IAuthorizationFilter
    {
        readonly Claim _claim;

        public ClaimRequirementFilter(Claim claim)
        {
            _claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var hasClaim = context.HttpContext.User.Claims.Any(c => c.Type == _claim.Type && c.Value == _claim.Value);
            if (!hasClaim)
            {
                context.Result = new ForbidResult();
            }
        }
    }
}
