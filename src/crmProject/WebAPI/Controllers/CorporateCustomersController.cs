
using Application.Features.CorporateCustomers.Commands;
using Application.Features.CorporateCustomers.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CorporateCustomersController : BaseController
{
    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateCorporateCustomerCommand createCorporateCustomerCommand)
    {
        CreatedCorporateCustomerDto result = await Mediator.Send(createCorporateCustomerCommand);
        return Created("", result);
    }

}