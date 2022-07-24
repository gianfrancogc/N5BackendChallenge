using Microsoft.AspNetCore.Mvc;
using N5.Challenge.Api.Controllers.Base;
using N5.Challenge.Application.Features.PermissionType.Query;
using System.Threading.Tasks;

namespace N5.Challenge.Api.Controllers
{

    public class PermissionTypeController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new PermissionTypeGetAllQuery { }));
        }

    }
}
