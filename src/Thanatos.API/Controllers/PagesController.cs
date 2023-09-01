using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Thanatos.API.Infrastructure.CQRS.Pages;

namespace Thanatos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GetPagesRequestResponse>))]
        public IActionResult GetPages([FromQuery] GetPagesQuery query)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetPageRequestResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetPage([FromRoute] GetPageRoute route)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreatePageRequestResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreatePage([FromBody] CreatePageBody body)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UpdatePageRequestResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdatePage([FromRoute] UpdatePageRoute route, [FromBody] UpdatePageBody body)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeletePage([FromRoute] DeletePageRoute route)
        {
            throw new NotImplementedException();
        }
    }
}
