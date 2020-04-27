using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using infrastructure.guest;

using MediatR;

namespace api.Controllers
{
    public class GuestsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<GuestDto>>> List()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Create([FromBody] Create.Command command)
        {
            return await Mediator.Send(command);
        }
    }
}