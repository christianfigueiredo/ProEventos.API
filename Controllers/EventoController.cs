using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEvento.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{
    private readonly Contexto _context;
    public EventoController(Contexto context)
    {
        _context = context;
    }   

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos.ToList();
       
    }

    [HttpGet("{id:int}")]
    public ActionResult<Evento> GetById(int id)
    {
        return _context.Eventos.FirstOrDefault(
            evento => evento.EventoId == id);
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
