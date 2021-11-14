using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MuskanChildrenHospitalApp.Data;
using MuskanChildrenHospitalApp.Models;
using MuskanChildrenHospitalApp.Models.Interface;
using MuskanChildrenHospitalApp.Models.Work;

namespace MuskanChildrenHospitalApp.Controllers
{
    public class BillsController : Controller
    {
        private readonly IBillRepository _context;
        private readonly IAdmissionRepositoy _admission;

        public BillsController(IBillRepository context, IAdmissionRepositoy admission)
        {
            _context = context;
            this._admission = admission;
        }

        // GET: Bills
        public IActionResult Index()
        {
            
            return View( _context.bills());
        }

        // GET: Bills/Details/5
        public IActionResult Details(int id)
        {


            var bill = _context.GetBill(id);
            if (bill == null)
            {
                return NotFound();
            }

            return View(bill);
        }

        // GET: Bills/Create
        public IActionResult Create()
        {
            ViewData["AddmisionId"] = new SelectList(_admission.GetAddmisions(), "id", "RegistrationNumber");
            return View();
        }

        // POST: Bills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("BillNo,DateOfDischarge,Diagnosis,TotalAmount,Advance,Discount,Balance,AmountInWords,AddmisionId,Refund")] mBill bill)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bill);
                
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddmisionId"] = new SelectList(_admission.GetAddmisions(), "id", "id" ,bill.addmisionId);
            return View(bill);
        }

        // GET: Bills/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var bill = await _context.Bills.FindAsync(id);
        //    if (bill == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["AddmisionId"] = new SelectList(_context.Addmisions, "id", "id", bill.AddmisionId);
        //    return View(bill);
        //}

        //// POST: Bills/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,BillNo,DateOfDischarge,Diagnosis,TotalAmount,Advance,Discount,Balance,AmountInWords,AddmisionId,Refund")] Bill bill)
        //{
        //    if (id != bill.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(bill);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!BillExists(bill.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AddmisionId"] = new SelectList(_context.Addmisions, "id", "id", bill.AddmisionId);
        //    return View(bill);
        //}

        //// GET: Bills/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var bill = await _context.Bills
        //        .Include(b => b.Addmision)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (bill == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(bill);
        //}

        //// POST: Bills/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var bill = await _context.Bills.FindAsync(id);
        //    _context.Bills.Remove(bill);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool BillExists(int id)
        //{
        //    return _context.Bills.Any(e => e.Id == id);
        //}
    }
}
