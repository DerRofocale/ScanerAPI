using System.Text;
using Microsoft.AspNetCore.Mvc;
using ScanerAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScanerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        /// <summary>
        /// Проверка доски
        /// </summary>
        /// <param name="board">Объект модели</param>
        /// <returns>true или false</returns>
        /// <remarks>
        /// Пример запроса:
        ///  
        ///     POST api/Board
        ///     {
        ///         "wane": 0,
        ///         "mold": 0,
        ///         "holes": 0,
        ///         "length": 1200,
        ///         "width": 100.00
        ///     }
        /// </remarks>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Board board)
        {
            try
            {
                if (board != null)
                {
                    int errors = 0;
                    if (board.wane != 0)
                        errors += 1;
                    if (board.mold != 0)
                        errors += 1;
                    if (board.holes != 0)
                        errors += 1;

                    var a1 = (1198 <= board.length && board.length <= 1202) && (99.5d <= board.width && board.width <= 100.5d);
                    var a2 = (1198 <= board.length && board.length <= 1202) && (144.5d <= board.width && board.width <= 145.5d);
                    var a3 = (798 <= board.length && board.length <= 802) && (144.5d <= board.width && board.width <= 145.5d);
                    
                    if (a1 == false && a2 == false && a3 == false)
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
