using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  
    public class TicketsController : BaseApiController
    {
        private readonly StoreContext _context;
        public TicketsController(StoreContext context)
        {
            _context = context;

        }

        [HttpGet]

        public async Task<ActionResult<List<Ticket>>> GetTickets()
        {

            foreach(var item in _context.Tickets.ToList())
            {
                item.Status = await _context.Statusuri.FindAsync(item.StatusId);
                item.Unitate = await _context.Unitati.FindAsync(item.UnitateId);
                item.Solicitare = await _context.Solicitari.FindAsync(item.SolicitareId);
                item.Serviciu = await _context.Servicii.FindAsync(item.ServiciuId);
                _context.SaveChanges();
            }
            return await _context.Tickets.ToListAsync();
        }


        [HttpGet("{id}")]

        public async Task<ActionResult<Ticket>> GetTicket(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            ticket.Status = await _context.Statusuri.FindAsync(ticket.StatusId);
            ticket.Unitate = await _context.Unitati.FindAsync(ticket.UnitateId);
            ticket.Solicitare = await _context.Solicitari.FindAsync(ticket.SolicitareId);
            ticket.Serviciu = await _context.Servicii.FindAsync(ticket.ServiciuId);
            if(ticket == null) return NotFound();
            return ticket;

        }

    }


}