using Application.Features.Departments.Commands.CreateDepartment;
using Application.Features.Departments.Commands.DeleteDepartment;
using Application.Features.Departments.Commands.UpdateDepartment;
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
        [HttpPost ("add")]
        public async Task<IActionResult> Add([FromBody] CreateDepartmentCommand createDepartmentCommand)
        {
            CreatedDepartmentDto result = await Mediator.Send(createDepartmentCommand);
            return Created("", result);
        }

        [HttpPost ("update")]
        public async Task<IActionResult> Update([FromBody] UpdateDepartmentCommand updateDepartmentCommand)
        {
            UpdatedDepartmentDto result = await Mediator.Send(updateDepartmentCommand);
            return Created("", result);
        }

        [HttpPost ("markasremoved")]
        public async Task<IActionResult> Delete([FromBody] DeleteDepartmentCommand deleteDepartmentCommand)
        {
            DeletedDepartmentDto result = await Mediator.Send(deleteDepartmentCommand);
            return Ok(result);
        }
    }
}
