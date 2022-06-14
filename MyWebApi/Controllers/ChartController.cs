using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
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
        [HttpPost]
        [Route("ValuesBarChart")]
        public IHttpActionResult ValuesBarChart([FromBody] AuthorizationToken value)
        {
            if (value.ValidToken())
            {
                return Ok(chartService.ValuesBarChart());
            }
            return BadRequest("bad request");
        }
        [HttpPost]
        [Route("ValuesLineChart")]
        public IHttpActionResult ValuesLineChart([FromBody] AuthorizationToken value)
        {
            if (value.ValidToken())
            {
                return Ok(chartService.ValuesLineChart());
            }
            return BadRequest("bad request");
        }
        [HttpPost]
        [Route("ValuesScatterChart")]
        public IHttpActionResult ValuesScatterChart([FromBody] AuthorizationToken value)
        {
            if (value.ValidToken())
            {
                return Ok(chartService.ValuesScattedChart());
            }
            return BadRequest("bad request");
        }
    }
}
