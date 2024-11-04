using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Insurance.Models;

namespace Insurance.Controllers
{
    public class MotorinsurancesController : Controller
    {
        private readonly InsuranceDbContext _context;

        public MotorinsurancesController(InsuranceDbContext context)
        {
            _context = context;
        }

        // GET: Motorinsurances
        public async Task<IActionResult> Index()
        {
              return _context.Motorinsurances != null ? 
                          View(await _context.Motorinsurances.ToListAsync()) :
                          Problem("Entity set 'InsuranceDbContext.Motorinsurances'  is null.");
        }

        // GET: Motorinsurances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Motorinsurances == null)
            {
                return NotFound();
            }

            var motorinsurance = await _context.Motorinsurances
                .FirstOrDefaultAsync(m => m.Policynumber == id);
            if (motorinsurance == null)
            {
                return NotFound();
            }

            return View(motorinsurance);
        }

        // GET: Motorinsurances/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }
        public IActionResult policy()
        {
            return View();
        }

        // POST: Motorinsurances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Policynumber,CNICnumber,BankACC,HolderName,Email,CustomerAddress,Contact,Gender,Occupation,Category,Brand,Owner,Vehiclenubmer,Purchasedate,PolicyValidity,Package")] Motorinsurance motorinsurance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motorinsurance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Home));
            }
            return View(motorinsurance);
        }

        // GET: Motorinsurances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Motorinsurances == null)
            {
                return NotFound();
            }

            var motorinsurance = await _context.Motorinsurances.FindAsync(id);
            if (motorinsurance == null)
            {
                return NotFound();
            }
            return View(motorinsurance);
        }

        // POST: Motorinsurances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Policynumber,CNICnumber,BankACC,HolderName,Email,CustomerAddress,Contact,Gender,Occupation,Category,Brand,Owner,Vehiclenubmer,Purchasedate,PolicyValidity,Package")] Motorinsurance motorinsurance)
        {
            if (id != motorinsurance.Policynumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motorinsurance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotorinsuranceExists(motorinsurance.Policynumber))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(motorinsurance);
        }

        // GET: Motorinsurances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Motorinsurances == null)
            {
                return NotFound();
            }

            var motorinsurance = await _context.Motorinsurances
                .FirstOrDefaultAsync(m => m.Policynumber == id);
            if (motorinsurance == null)
            {
                return NotFound();
            }

            return View(motorinsurance);
        }

        // POST: Motorinsurances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Motorinsurances == null)
            {
                return Problem("Entity set 'InsuranceDbContext.Motorinsurances'  is null.");
            }
            var motorinsurance = await _context.Motorinsurances.FindAsync(id);
            if (motorinsurance != null)
            {
                _context.Motorinsurances.Remove(motorinsurance);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotorinsuranceExists(int id)
        {
          return (_context.Motorinsurances?.Any(e => e.Policynumber == id)).GetValueOrDefault();
        }
    }
}
