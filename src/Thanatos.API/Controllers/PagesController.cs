using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Thanatos.API.Infrastructure.CQRS.Pages;

namespace Thanatos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GetPagesRequestResponse>))]
        public IActionResult GetPages([FromQuery] GetPagesQuery query)
        {
            var request = new GetPagesRequest(query);
            var response = _mediator.Send(request).Result;
            return Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetPageRequestResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetPage([FromRoute] GetPageRoute route)
        {
            var request = new GetPageRequest(route);
            var response = _mediator.Send(request).Result;
            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreatePageRequestResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreatePage([FromBody] CreatePageBody body)
        {
            var request = new CreatePageRequest(body);
            var response = _mediator.Send(request).Result;
            return CreatedAtAction(nameof(GetPage), new { id = response.Id }, response);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UpdatePageRequestResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdatePage([FromRoute] UpdatePageRoute route, [FromBody] UpdatePageBody body)
        {
            var request = new UpdatePageRequest(route, body);
            var response = _mediator.Send(request).Result;
            return Ok(response);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeletePage([FromRoute] DeletePageRoute route)
        {
            var request = new DeletePageRequest(route);
            _mediator.Send(request);
            return NoContent();
        }
    }
}
