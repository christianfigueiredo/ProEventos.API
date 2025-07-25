using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEvento.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{
    public EventoController()
    {

    }

    [HttpGet]
    public Evento Get()
    {
        return new Evento()
        {
            EventoId = 1,
            Tema = "Angular e .NET 6",
            Local = "São Paulo",
            Lote = "1º Lote",
            QtdePessoas = 250,
            DataEvento = "01/05/2023",
            
        };
    }

    [HttpPost]
    public string Post()
    {
        return "Post";
    }

    [HttpPut("{id:int}")]
    public string Put(int id)
    {
        return $"Exemploe de id {id} recebido";
    }

    [HttpDelete("{id:int}")]
    public string Delete(int id)
    {    
        return $"Exemploe de id {id} recebido para exclusão";
    }
}
