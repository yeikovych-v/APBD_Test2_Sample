using Microsoft.AspNetCore.Mvc;
using s28201_Test2.Service;

namespace s28201_Test2.Controller;

[ApiController]
public class ApiController(AppService service)
{


    [HttpGet]
    [Route("/api/v1/cool-name")]
    public IResult GetOk()
    {
        return Results.Ok(service.FancyStringOperation("I'm fine!"));
    }
}