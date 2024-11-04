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
    public class HomeinsurancesController : Controller
    {
        private readonly InsuranceDbContext _context;

        public HomeinsurancesController(InsuranceDbContext context)
        {
            _context = context;
        }

        // GET: Homeinsurances
        public async Task<IActionResult> Index()
        {
              return _context.Homeinsurances != null ? 
                          View(await _context.Homeinsurances.ToListAsync()) :
                          Problem("Entity set 'InsuranceDbContext.Homeinsurances'  is null.");
        }

        // GET: Homeinsurances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Homeinsurances == null)
            {
                return NotFound();
            }

            var homeinsurance = await _context.Homeinsurances
                .FirstOrDefaultAsync(m => m.Policynumber == id);
            if (homeinsurance == null)
            {
                return NotFound();
            }

            return View(homeinsurance);
        }

        // GET: Homeinsurances/Create
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

        // POST: Homeinsurances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Policynumber,CNICnumber,BankACC,HolderName,Email,CustomerAddress,Contact,Gender,Occupation,HouseAddress,HouseMembers,HouseOwner,Housesqyard,Houseprice,Housetype,PolicyValidity,Package")] Homeinsurance homeinsurance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homeinsurance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Home));
            }
            return View(homeinsurance);
        }

        // GET: Homeinsurances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Homeinsurances == null)
            {
                return NotFound();
            }

            var homeinsurance = await _context.Homeinsurances.FindAsync(id);
            if (homeinsurance == null)
            {
                return NotFound();
            }
            return View(homeinsurance);
        }

        // POST: Homeinsurances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Policynumber,CNICnumber,BankACC,HolderName,Email,CustomerAddress,Contact,Gender,Occupation,HouseAddress,HouseMembers,HouseOwner,Housesqyard,Houseprice,Housetype,PolicyValidity,Package")] Homeinsurance homeinsurance)
        {
            if (id != homeinsurance.Policynumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeinsurance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeinsuranceExists(homeinsurance.Policynumber))
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
            return View(homeinsurance);
        }

        // GET: Homeinsurances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Homeinsurances == null)
            {
                return NotFound();
            }

            var homeinsurance = await _context.Homeinsurances
                .FirstOrDefaultAsync(m => m.Policynumber == id);
            if (homeinsurance == null)
            {
                return NotFound();
            }

            return View(homeinsurance);
        }

        // POST: Homeinsurances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Homeinsurances == null)
            {
                return Problem("Entity set 'InsuranceDbContext.Homeinsurances'  is null.");
            }
            var homeinsurance = await _context.Homeinsurances.FindAsync(id);
            if (homeinsurance != null)
            {
                _context.Homeinsurances.Remove(homeinsurance);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeinsuranceExists(int id)
        {
          return (_context.Homeinsurances?.Any(e => e.Policynumber == id)).GetValueOrDefault();
        }
    }
}
