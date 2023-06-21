using Microsoft.AspNetCore.Mvc;
using ScanerAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScanerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckerController : ControllerBase
    {
        /// <summary>
        /// Проверка шашки
        /// </summary>
        /// <param name="checker">Объект модели</param>
        /// <returns>true или false</returns>
        /// <remarks>
        /// Пример запроса:
        ///  
        ///     POST api/Checker
        ///     {
        ///         "cracks": 0,
        ///         "mold": 0,
        ///         "holes": 0,
        ///         "length": 145,
        ///         "width": 100.00
        ///     }
        /// </remarks>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Checker checker)
        {
            try
            {
                if (checker != null)
                {
                    int errors = 0;
                    if (checker.cracks != 0)
                        errors += 1;
                    if (checker.mold != 0)
                        errors += 1;
                    if (checker.holes != 0)
                        errors += 1;

                    var a1 = (143 <= checker.length && checker.length <= 147) && (99.5d <= checker.width && checker.width <= 100.5d);
                    var a2 = (143 <= checker.length && checker.length <= 147) && (144.5d <= checker.width && checker.width <= 145.5d);

                    if (a1 == false && a2 == false)
                    {
                        errors += 1;
                    }

                    if (errors == 0)
                    {
                        return Ok(true);
                    }
                    else
                    {
                        return BadRequest(false);
                    }
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
