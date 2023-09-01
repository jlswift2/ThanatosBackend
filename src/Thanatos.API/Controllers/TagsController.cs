using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using Thanatos.API.Infrastructure.CQRS.Tags;
using Thanatos.API.Infrastructure.Data;

namespace Thanatos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private IMediator _mediator;
        public TagsController(IMapper mapper, IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GetTagsRequestResponse>))]
        public async Task<IActionResult> GetTags([FromQuery] GetTagsQuery query)
        {
            var result = await _mediator.Send(new GetTagsRequest(query));
            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetTagRequestResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetTag([FromRoute] GetTagRoute route)
        {
            var result = await _mediator.Send(new GetTagRequest(route));
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateTagRequestResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateTag([FromBody] CreateTagBody body)
        {
            var result = await _mediator.Send(new CreateTagRequest(body));
            return CreatedAtAction(nameof(GetTag), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UpdateTagRequestResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateTag([FromRoute] UpdateTagRoute route, [FromBody] UpdateTagBody body)
        {
            var result = await _mediator.Send(new UpdateTagRequest(route, body));
            return Ok(result);
        }
    }
}
