using Application.Features.Departments.Commands;
using Application.Features.Departments.Dtos;
using Application.Features.Departments.Models;
using Application.Features.Departments.Queries;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentsController : BaseController
{
    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateDepartmentCommand createDepartmentCommand)
    {
        CreatedDepartmentDto result = await Mediator.Send(createDepartmentCommand);
        return Created("", result);
    }

    [HttpPost("update")]
    public async Task<IActionResult> Update([FromBody] UpdateDepartmentCommand updateDepartmentCommand)
    {
        UpdatedDepartmentDto result = await Mediator.Send(updateDepartmentCommand);
        return Created("", result);
    }

    [HttpPost("remove")]
    public async Task<IActionResult> Delete([FromBody] RemoveDepartmentCommand deleteDepartmentCommand)
    {
        RemovedDepartmentDto result = await Mediator.Send(deleteDepartmentCommand);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetPagebleList([FromQuery] PageRequest pageRequest)
    {
        GetPagebleListDepartmentQuery getPagebleListDepartmentQuery = new() { PageRequest = pageRequest };
        DepartmentPagebleListModel result = await Mediator.Send(getPagebleListDepartmentQuery);
        return Ok(result);
    }
}