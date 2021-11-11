using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MuskanChildrenHospitalApp.Data;
using MuskanChildrenHospitalApp.Models;

namespace MuskanChildrenHospitalApp.Controllers
{
    public class IncomeHeadsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IncomeHeadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IncomeHeads
        public async Task<IActionResult> Index()
        {
            return View(await _context.IncomeHeads.ToListAsync());
        }

        // GET: IncomeHeads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incomeHeads = await _context.IncomeHeads
                .FirstOrDefaultAsync(m => m.Id == id);
            if (incomeHeads == null)
            {
                return NotFound();
            }

            return View(incomeHeads);
        }

        // GET: IncomeHeads/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IncomeHeads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HeadsName,Status,CreatedDate,ModifiedDate")] IncomeHeads incomeHeads)
        {
            if (ModelState.IsValid)
            {
                _context.Add(incomeHeads);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(incomeHeads);
        }

        // GET: IncomeHeads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incomeHeads = await _context.IncomeHeads.FindAsync(id);
            if (incomeHeads == null)
            {
                return NotFound();
            }
            return View(incomeHeads);
        }

        // POST: IncomeHeads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HeadsName,Status,CreatedDate,ModifiedDate")] IncomeHeads incomeHeads)
        {
            if (id != incomeHeads.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incomeHeads);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncomeHeadsExists(incomeHeads.Id))
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
            return View(incomeHeads);
        }

        // GET: IncomeHeads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incomeHeads = await _context.IncomeHeads
                .FirstOrDefaultAsync(m => m.Id == id);
            if (incomeHeads == null)
            {
                return NotFound();
            }

            return View(incomeHeads);
        }

        // POST: IncomeHeads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var incomeHeads = await _context.IncomeHeads.FindAsync(id);
            _context.IncomeHeads.Remove(incomeHeads);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncomeHeadsExists(int id)
        {
            return _context.IncomeHeads.Any(e => e.Id == id);
        }
    }
}
