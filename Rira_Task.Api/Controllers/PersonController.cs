using MediatR;
using Microsoft.AspNetCore.Mvc;
using Rira_Task.Application.DTOs.Person;
using Rira_Task.Application.Features.Person.Requests.Commands;
using Rira_Task.Application.Features.Person.Requests.Queries;

namespace Rira_Task.Api.Controllers
{
    public class PersonController : Controller
    {
        private readonly IMediator _mediator;
        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<FoodController>
        [HttpGet]
        public async Task<ActionResult<List<PersonListDto>>> Get()
        {
            return Ok(await _mediator.Send(new GetPersonListRequest()));
        }

        // GET api/<FoodController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonDto>> Get(int id)
        {
            return Ok(await _mediator.Send(new GetPersonRequest { ID = id }));
        }

        // POST api/<FoodController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreatePersonDto CreatePerson)
        {
            return Ok(await _mediator.Send(new CreatePersonCommand { CreatePersonDto = CreatePerson }));
        }

        // PUT api/<FoodController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdatePersonDto UpdatePerson)
        {
            return Ok(await _mediator.Send(new UpdatePersonCommand { UpdatePersonDto = UpdatePerson, ID = id }));
        }

        // DELETE api/<FoodController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeletePersonCommand { ID = id }));
        }
    }
}
