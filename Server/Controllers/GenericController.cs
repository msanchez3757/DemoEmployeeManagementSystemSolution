using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerLibrary.Repositories.Contracts;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T>(IGenericRepositoryInterface<T> genericRepositoryInterface) : Controller where T : class
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAll() => Ok(await genericRepositoryInterface.GetAll());

        [HttpGet("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if(id <= 0) return BadRequest("Invalid request");
            return Ok(await genericRepositoryInterface.Delete(id));
        }

        [HttpGet("single/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id <= 0) return BadRequest("Invalid request");
            return Ok(await genericRepositoryInterface.GetById(id));
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add(T item)
        {
            if (item is null) return BadRequest("Invalid request");
            return Ok(await genericRepositoryInterface.Insert(item));
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(T item)
        {
            if (item is null) return BadRequest("Invalid request");
            return Ok(await genericRepositoryInterface.Update(item));
        }
    }
}
