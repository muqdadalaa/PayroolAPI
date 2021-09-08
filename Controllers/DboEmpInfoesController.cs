using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayroolAPI.Models;

namespace PayroolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class DboEmpInfoesController : ControllerBase
    {
        private readonly payrollContext _context;

        public DboEmpInfoesController(payrollContext context)
        {
            _context = context;
        }

        // GET: api/DboEmpInfoes
        [HttpGet]
        public IEnumerable<DboEmpInfo> GetDboEmpInfo()
        {
            return _context.DboEmpInfo;
        }

        // GET: api/DboEmpInfoes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDboEmpInfo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dboEmpInfo = await _context.DboEmpInfo.FindAsync(id);

            if (dboEmpInfo == null)
            {
                return NotFound();
            }

            return Ok(dboEmpInfo);
        }

        // PUT: api/DboEmpInfoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDboEmpInfo([FromRoute] int id, [FromBody] DboEmpInfo dboEmpInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dboEmpInfo.EmpId)
            {
                return BadRequest();
            }

            _context.Entry(dboEmpInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DboEmpInfoExists(id))
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

        // POST: api/DboEmpInfoes
        [HttpPost]
        public async Task<IActionResult> PostDboEmpInfo([FromBody] DboEmpInfo dboEmpInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.DboEmpInfo.Add(dboEmpInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDboEmpInfo", new { id = dboEmpInfo.EmpId }, dboEmpInfo);
        }

        // DELETE: api/DboEmpInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDboEmpInfo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dboEmpInfo = await _context.DboEmpInfo.FindAsync(id);
            if (dboEmpInfo == null)
            {
                return NotFound();
            }

            _context.DboEmpInfo.Remove(dboEmpInfo);
            await _context.SaveChangesAsync();

            return Ok(dboEmpInfo);
        }

        private bool DboEmpInfoExists(int id)
        {
            return _context.DboEmpInfo.Any(e => e.EmpId == id);
        }
    }
}