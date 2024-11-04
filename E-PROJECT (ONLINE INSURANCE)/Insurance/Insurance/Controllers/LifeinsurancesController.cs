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
    public class LifeinsurancesController : Controller
    {
        private readonly InsuranceDbContext _context;

        public LifeinsurancesController(InsuranceDbContext context)
        {
            _context = context;
        }

        // GET: Lifeinsurances
        public async Task<IActionResult> Index()
        {
              return _context.Lifeinsurances != null ? 
                          View(await _context.Lifeinsurances.ToListAsync()) :
                          Problem("Entity set 'InsuranceDbContext.Lifeinsurances'  is null.");
        }

        // GET: Lifeinsurances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lifeinsurances == null)
            {
                return NotFound();
            }

            var lifeinsurance = await _context.Lifeinsurances
                .FirstOrDefaultAsync(m => m.Policynumber == id);
            if (lifeinsurance == null)
            {
                return NotFound();
            }

            return View(lifeinsurance);
        }

        // GET: Lifeinsurances/Create
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



        // POST: Lifeinsurances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Policynumber,CNICnumber,BankACC,HolderName,Email,CustomerAddress,Contact,Gender,MartialStatus,Occupation,PolicyValidity,PolicyStart,DOB,MotherName,NextofKIN,RelationshipwithKIN,KinContact,FatherName,Package")] Lifeinsurance lifeinsurance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lifeinsurance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Home));
            }
            return View(lifeinsurance);
        }

        // GET: Lifeinsurances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lifeinsurances == null)
            {
                return NotFound();
            }

            var lifeinsurance = await _context.Lifeinsurances.FindAsync(id);
            if (lifeinsurance == null)
            {
                return NotFound();
            }
            return View(lifeinsurance);
        }

        // POST: Lifeinsurances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Policynumber,CNICnumber,BankACC,HolderName,Email,CustomerAddress,Contact,Gender,MartialStatus,Occupation,PolicyValidity,PolicyStart,DOB,MotherName,NextofKIN,RelationshipwithKIN,KinContact,FatherName,Package")] Lifeinsurance lifeinsurance)
        {
            if (id != lifeinsurance.Policynumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lifeinsurance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LifeinsuranceExists(lifeinsurance.Policynumber))
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
            return View(lifeinsurance);
        }

        // GET: Lifeinsurances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lifeinsurances == null)
            {
                return NotFound();
            }

            var lifeinsurance = await _context.Lifeinsurances
                .FirstOrDefaultAsync(m => m.Policynumber == id);
            if (lifeinsurance == null)
            {
                return NotFound();
            }

            return View(lifeinsurance);
        }

        // POST: Lifeinsurances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lifeinsurances == null)
            {
                return Problem("Entity set 'InsuranceDbContext.Lifeinsurances'  is null.");
            }
            var lifeinsurance = await _context.Lifeinsurances.FindAsync(id);
            if (lifeinsurance != null)
            {
                _context.Lifeinsurances.Remove(lifeinsurance);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LifeinsuranceExists(int id)
        {
          return (_context.Lifeinsurances?.Any(e => e.Policynumber == id)).GetValueOrDefault();
        }
    }
}
