using Application.Features.Personnels.Commands;
using Application.Features.Personnels.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnelsController : BaseController
    {
        [HttpPost ("add")]
        public async Task<IActionResult> Add([FromBody] CreatePersonnelCommand createPersonnelCommand)
        {
            CreatedPersonnelDto result = await Mediator.Send(createPersonnelCommand);
            return Created("", result);
        }

        [HttpPost ("update")]
        public async Task<IActionResult> Update([FromBody] UpdatePersonnelCommand updatePersonnelCommand)
        {
            UpdatedPersonnelDto result = await Mediator.Send(updatePersonnelCommand);
            return Ok(result);
        }

        [HttpPost("remove")]
        public async Task<IActionResult> MarkAsRemoved([FromBody] RemovePersonnelCommand deletePersonnelCommand)
        {
            RemovedPersonnelDto result = await Mediator.Send(deletePersonnelCommand);
            return Ok(result);
        }
    }
}
