using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcquirerApi.Request;
using AcquirerApi.Response;
using AcquirerApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AcquirerApi.Controllers
{
    [Route("transaction")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly TransactionService transactionService;

        public TransactionController()
        {
            transactionService = new TransactionService();
        }

        // POST api/values
        [HttpPost]
        public ActionResult<TransactionResponse> Post([FromBody] TransactionRequest request)
        {
            var result = transactionService.Add(request);
            return Ok(result);
        }
    }
}
