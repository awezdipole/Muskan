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
    public class ExpenseHeadsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpenseHeadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ExpenseHeads
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExpenseHeads.ToListAsync());
        }

        // GET: ExpenseHeads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expenseHeads = await _context.ExpenseHeads
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expenseHeads == null)
            {
                return NotFound();
            }

            return View(expenseHeads);
        }

        // GET: ExpenseHeads/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExpenseHeads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HeadsName,Status,CreatedDate,ModifiedDate")] ExpenseHeads expenseHeads)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expenseHeads);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(expenseHeads);
        }

        // GET: ExpenseHeads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expenseHeads = await _context.ExpenseHeads.FindAsync(id);
            if (expenseHeads == null)
            {
                return NotFound();
            }
            return View(expenseHeads);
        }

        // POST: ExpenseHeads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HeadsName,Status,CreatedDate,ModifiedDate")] ExpenseHeads expenseHeads)
        {
            if (id != expenseHeads.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expenseHeads);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpenseHeadsExists(expenseHeads.Id))
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
            return View(expenseHeads);
        }

        // GET: ExpenseHeads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expenseHeads = await _context.ExpenseHeads
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expenseHeads == null)
            {
                return NotFound();
            }

            return View(expenseHeads);
        }

        // POST: ExpenseHeads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expenseHeads = await _context.ExpenseHeads.FindAsync(id);
            _context.ExpenseHeads.Remove(expenseHeads);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpenseHeadsExists(int id)
        {
            return _context.ExpenseHeads.Any(e => e.Id == id);
        }
    }
}
