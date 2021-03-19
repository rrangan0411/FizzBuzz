using FizzBizz.Domain.Logic;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FizzBuzz.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBizzDomain _fizzBizzDomain;

        public FizzBuzzController(IFizzBizzDomain fizzBizzDomain)
        {
            _fizzBizzDomain = fizzBizzDomain;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("getresult")]
        public IActionResult GetResult(params object[] list)
        {
            var jsonResult = new JsonResult(null);
            try
            {
                jsonResult.StatusCode = 200;
                jsonResult.Value = _fizzBizzDomain.EvalList(list);
            }
            catch (Exception e)
            {
                jsonResult.StatusCode = 500;
                jsonResult.Value = e.Message;
            }

            return jsonResult;
        }
    }
}