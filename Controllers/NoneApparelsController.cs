using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ecommercebackend.Models;

namespace ecommercebackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoneApparelsController : ControllerBase
    {
        private readonly NoneShopDBContext _context;

        public NoneApparelsController(NoneShopDBContext context)
        {
            _context = context;
        }

        // GET: api/NoneApparels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NoneApparel>>> GetNoneApparels()
        {
            return await _context.NoneApparels.ToListAsync();
        }

        // GET: api/NoneApparels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NoneApparel>> GetNoneApparel(int id)
        {
            var noneApparel = await _context.NoneApparels.FindAsync(id);

            if (noneApparel == null)
            {
                return NotFound();
            }

            return noneApparel;
        }

        // PUT: api/NoneApparels/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNoneApparel(int id, NoneApparel noneApparel)
        {
            if (id != noneApparel.id)
            {
                return BadRequest();
            }

            _context.Entry(noneApparel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoneApparelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/NoneApparels
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<NoneApparel>> PostNoneApparel(NoneApparel noneApparel)
        {
            _context.NoneApparels.Add(noneApparel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNoneApparel", new { id = noneApparel.id }, noneApparel);
        }

        // DELETE: api/NoneApparels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NoneApparel>> DeleteNoneApparel(int id)
        {
            var noneApparel = await _context.NoneApparels.FindAsync(id);
            if (noneApparel == null)
            {
                return NotFound();
            }

            _context.NoneApparels.Remove(noneApparel);
            await _context.SaveChangesAsync();

            return noneApparel;
        }

        private bool NoneApparelExists(int id)
        {
            return _context.NoneApparels.Any(e => e.id == id);
        }
    }
}
