using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Integration.API.Controllers;

public class ControllerHelper : ControllerBase
{
    protected IActionResult Handle(int result, HttpStatusCode failure = HttpStatusCode.BadRequest)
    {
        return result > 0 ? Ok() : StatusCode((int)failure);
    }

    protected IActionResult Handle(Func<bool> condition,
                                   HttpStatusCode sucess = HttpStatusCode.OK,
                                   HttpStatusCode failure = HttpStatusCode.BadRequest,
                                   dynamic? data = null,
                                   dynamic? dataFailure = null)
    {
        return condition() ? StatusCode((int)sucess, data) : StatusCode((int)failure, dataFailure);
    }
}
