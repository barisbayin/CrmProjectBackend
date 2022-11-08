using Application.Features.Personnels.Commands.CreatePersonnel;
using Application.Features.Personnels.Commands.UpdatePersonnel;
using Application.Features.Personnels.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnelsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreatePersonnelCommand createPersonnelCommand)
        {
            CreatedPersonnelDto result = await Mediator.Send(createPersonnelCommand);
            return Created("", result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdatePersonnelCommand updatePersonnelCommand)
        {
            UpdatedPersonnelDto result = await Mediator.Send(updatePersonnelCommand);
            return Ok(result);
        }
    }
}
