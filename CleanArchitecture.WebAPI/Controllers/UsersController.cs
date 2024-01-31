using CleanArchitecture.Application.UseCases.User.Create;
using CleanArchitecture.Application.UseCases.User.Delete;
using CleanArchitecture.Application.UseCases.User.GetAll;
using CleanArchitecture.Application.UseCases.User.Udpdate;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;
    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<UserGetAllResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new UserGetAllRequest(), cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(UserCreateRequest request)
    {
        var userId = await _mediator.Send(request);
        return Ok(userId);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UserUpdateResponse>>Update(Guid id, UserUpdateRequest request, CancellationToken cancellationToken)
    {
        if (id != request.Id)
            return BadRequest();

        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
    {
        if (id is null)
            return BadRequest();

        var userDeleteRequest = new UserDeleteRequest(id.Value);

        var response = await _mediator.Send(userDeleteRequest, cancellationToken);
        return Ok(response);
    }
}
