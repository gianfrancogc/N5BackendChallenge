using Microsoft.AspNetCore.Mvc;
using N5.Challenge.Api.Controllers;
using N5.Challenge.Api.Controllers.Base;
using N5.Challenge.Application.Features.Permission.Commands.Create;
using N5.Challenge.Application.Features.Permission.Commands.Update;
using System;
using System.Threading.Tasks;
using Xunit;

namespace N5.Integration.Test
{
    public class PermissionControllerTest :BaseApiController
    {


        private PermissionController _controller;

        public PermissionControllerTest()
        {
            _controller = new PermissionController();
        }


        [Fact]
        public async Task AddPermisionTestAsync()
        {
            var createPermission = new CreatePermissionCommand()
            {
                EmployeeName = "Keith",
                EmployeeLastname = "Wallen",
                PermissionDate = DateTime.Now,
                PermissionTypeId = 1
            };

            var createdResponse = await _controller.Create(createPermission);
            Assert.IsType<ObjectResult>(createdResponse);
        }


        [Fact]
        public async Task UpdateDriverTestAsync()
        {
            var updatePermission = new UpdatePermissionCommand()
            {
                Id=1,
                EmployeeName = "Gian",
                EmployeeLastname = "Wallen",
                PermissionTypeId = 1
            };
            var createdResponse = await _controller.Update(updatePermission);
            Assert.IsType<ObjectResult>(createdResponse);
        }


        [Fact]
        public async Task GetPermissionByIdTestAsync()
        {
            var createdResponse = await _controller.Get(1);
            Assert.IsType<ObjectResult>(createdResponse);
        }

    }
}
