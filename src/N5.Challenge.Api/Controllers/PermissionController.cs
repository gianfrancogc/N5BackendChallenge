using Microsoft.AspNetCore.Mvc;
using N5.Challenge.Api.Controllers.Base;
using N5.Challenge.Application.Features.Permission.Commands.Create;
using N5.Challenge.Application.Features.Permission.Commands.Update;
using N5.Challenge.Application.Features.Permission.Query.GetAll;
using N5.Challenge.Application.Features.Permission.Query.GetById;
using System.Threading.Tasks;

namespace N5.Challenge.Api.Controllers
{
    public class PermissionController : BaseApiController
    {

        [HttpPost]
        public async Task<IActionResult> Create(CreatePermissionCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdatePermissionCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new PermissionGetAllQuery {}));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new PermissionGetByIdQuery { Id = id }));
        }
    }
}
