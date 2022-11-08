using Application.Features.Departments.Commands.CreateDepartment;
using Application.Features.Departments.Dtos;
using Application.Features.Personnels.Commands.CreatePersonnel;
using Application.Features.Personnels.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateDepartmentCommand createDepartmentCommand)
        {
            CreatedDepartmentDto result = await Mediator.Send(createDepartmentCommand);
            return Created("", result);
        }
    }
}
