using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaasProject.Dtos;

namespace SaasProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] Numbers numbers)
        {
            if (numbers == null)
            {
                return BadRequest("Invalid input");
            }

            int sum = numbers.Num1 + numbers.Num2;
            return Ok(new { Sum = sum });
        }
    }
}