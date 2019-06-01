using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcquirerApi.Responses;
using AcquirerApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AcquirerApi.Controllers
{
    [Route("mdr")]
    [ApiController]
    public class MerchantDiscountRateController : ControllerBase
    {
        private readonly AcquirerService acquirerService;

        public MerchantDiscountRateController()
        {
            acquirerService = new AcquirerService();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IList<AcquirerResponse>> Get()
        {
            var mdrs = acquirerService.GetAll();
            return Ok(mdrs);
        }
    }
}
