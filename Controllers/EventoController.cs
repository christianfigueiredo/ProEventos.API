using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEvento.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> evento = new Evento[]{
            new Evento() {
                EventoId = 1,
                Local = "São Paulo",
                Tema = "Angular e .NET 6",
                DataEvento = "01/05/2023",
                QtdePessoas = 250,
                Lote = "1º Lote",
                ImagemURL = "foto.png"
            },
            new Evento() {
                EventoId = 2,
                Local = "Rio de Janeiro",
                Tema = "React e .NET 6",
                DataEvento = "02/06/2023",
                QtdePessoas = 300,
                Lote = "2º Lote",
                ImagemURL = "foto2.png"
            }

        };
    public EventoController()
    {

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return evento;
       
    }

    [HttpGet("{id:int}")]
    public ActionResult<Evento> GetById(int id)
    {
        return evento.FirstOrDefault(evento => evento.EventoId == id);
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
