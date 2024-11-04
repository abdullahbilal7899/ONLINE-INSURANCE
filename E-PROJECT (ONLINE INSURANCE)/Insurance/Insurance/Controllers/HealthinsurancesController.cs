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
    public class HealthinsurancesController : Controller
    {
        private readonly InsuranceDbContext _context;

        public HealthinsurancesController(InsuranceDbContext context)
        {
            _context = context;
        }

        // GET: Healthinsurances
        public async Task<IActionResult> Index()
        {
              return _context.Healthinsurances != null ? 
                          View(await _context.Healthinsurances.ToListAsync()) :
                          Problem("Entity set 'InsuranceDbContext.Healthinsurances'  is null.");
        }

        // GET: Healthinsurances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Healthinsurances == null)
            {
                return NotFound();
            }

            var healthinsurance = await _context.Healthinsurances
                .FirstOrDefaultAsync(m => m.Policynumber == id);
            if (healthinsurance == null)
            {
                return NotFound();
            }

            return View(healthinsurance);
        }

        // GET: Healthinsurances/Create
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

        // POST: Healthinsurances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Policynumber,CNICnumber,BankACC,HolderName,Email,CustomerAddress,Contact,Gender,MartialStatus,Occupation,PolicyValidity,PolicyStart,DOB,MotherName,FatherName,Package")] Healthinsurance healthinsurance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(healthinsurance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Home));
            }
            return View(healthinsurance);
        }

        // GET: Healthinsurances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Healthinsurances == null)
            {
                return NotFound();
            }

            var healthinsurance = await _context.Healthinsurances.FindAsync(id);
            if (healthinsurance == null)
            {
                return NotFound();
            }
            return View(healthinsurance);
        }

        // POST: Healthinsurances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Policynumber,CNICnumber,BankACC,HolderName,Email,CustomerAddress,Contact,Gender,MartialStatus,Occupation,PolicyValidity,PolicyStart,DOB,MotherName,FatherName,Package")] Healthinsurance healthinsurance)
        {
            if (id != healthinsurance.Policynumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(healthinsurance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HealthinsuranceExists(healthinsurance.Policynumber))
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
            return View(healthinsurance);
        }

        // GET: Healthinsurances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Healthinsurances == null)
            {
                return NotFound();
            }

            var healthinsurance = await _context.Healthinsurances
                .FirstOrDefaultAsync(m => m.Policynumber == id);
            if (healthinsurance == null)
            {
                return NotFound();
            }

            return View(healthinsurance);
        }

        // POST: Healthinsurances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Healthinsurances == null)
            {
                return Problem("Entity set 'InsuranceDbContext.Healthinsurances'  is null.");
            }
            var healthinsurance = await _context.Healthinsurances.FindAsync(id);
            if (healthinsurance != null)
            {
                _context.Healthinsurances.Remove(healthinsurance);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HealthinsuranceExists(int id)
        {
          return (_context.Healthinsurances?.Any(e => e.Policynumber == id)).GetValueOrDefault();
        }
    }
}
