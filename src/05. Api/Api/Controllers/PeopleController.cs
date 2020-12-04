using Application.CQRS.Command.Commands;
using Application.CQRS.Query.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPersonQueryService _queryService;
        private readonly IMediator _mediator;

        public PeopleController(
            IPersonQueryService queryService
            ,IMediator mediator
            )
        {
            _queryService = queryService;
            _mediator = mediator;
        }
        [HttpGet("perdonId")]
        public async Task<ActionResult> Get(int perdonId)
        {
            var response = await _queryService.GetAsync(perdonId);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> Post(PersonCreateCommand request)
        {
            await _mediator.Publish(request);
            return Ok();
        }
    }
}