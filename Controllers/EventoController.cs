using Microsoft.AspNetCore.Mvc;

namespace ProEvento.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{
    public EventoController()
    {

    }

    [HttpGet]
    public string Get()
    {
        return "Certin";
    }

    [HttpPost]
    public string Post()
    {
        return "Post";
    }
}
