using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BaseApi.UseCase.V1;

namespace BaseApi.Controllers.V1
{
    [Route("api/v1/healthcheck")]
    [ApiController]
    [Produces("application/json")]
    public class HealthCheckController : BaseController
    {
        [HttpGet]
        [Route("ping")]
        [ProducesResponseType(typeof(Dictionary<string, bool>), 200)]
        public IActionResult HealthCheck()
        {
            var result = new Dictionary<string, bool> { { "success", true } };

            return Ok(result);
        }

        [HttpGet]
        [Route("error")]
        public void ThrowError()
        {
            ThrowOpsErrorUsecase.Execute();
        }

    }
}
