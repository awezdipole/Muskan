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
        private readonly ApplicationDbContext db;
        private readonly IBillRepository _context;
        private readonly IAssignRoomRepository assign;
        private readonly IAdmissionRepositoy _admission;
        private readonly IserviceRepository iservice;

        public BillsController(ApplicationDbContext db,IBillRepository context,IAssignRoomRepository assign ,IAdmissionRepositoy admission,IserviceRepository iservice)
        {
            this.db = db;
            _context = context;
            this.assign = assign;
            this._admission = admission;
            this.iservice = iservice;
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
            ViewData["AddmisionId"] = new SelectList(_admission.GetAddmisions(), "id", "RegNo");
            ViewData["service"] = new SelectList(iservice.GetAllServices(), "id", "ServiceName");
            //ViewData["Room"] = new SelectList(assign.GetAssignRoomsByAddId(), "id", "ServiceName");

            return View();
        }

        // POST: Bills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(collection_Invoice coInvoice)
        {
            if (coInvoice.bill != null)
            {
                mBill inv = new mBill();
                inv.Date = coInvoice.bill.Date;
                inv.TotalAmt = coInvoice.bill.TotalAmt;
                inv.AdvanceAmt = coInvoice.bill.AdvanceAmt;
                inv.RefundAmt = coInvoice.bill.RefundAmt;
                inv.RegNo = coInvoice.bill.RegNo;
                inv.BillNo = coInvoice.bill.BillNo;
                inv.BalanceAmt = coInvoice.bill.BalanceAmt;
                inv.addmisionId = coInvoice.bill.addmisionId;

                mBillDetailsService detailsService = new mBillDetailsService();

                foreach(var details in coInvoice.ServiceDetails)
                {
                    detailsService.ServiceId = details.ServiceId;
                    detailsService.ServiceName = details.ServiceName;
                    detailsService.Price = details.Price;
                    detailsService.Day = details.Day;
                    details.Amount = details.Amount;
                }

            }
            ViewData["AddmisionId"] = new SelectList(_admission.GetAddmisions(), "id", "id" , coInvoice.bill.addmisionId);
            return View(coInvoice);
        }

        //public SelectList GetRooms(string stateId, string selectCityId = null)
        //{
        //    IEnumerable<SelectListItem> cityList = new List<SelectListItem>();
        //    if (!string.IsNullOrEmpty(stateId))
        //    {
        //        int _stateId = Convert.ToInt32(stateId);
        //        cityList = (from m in db.AssignRooms where m.add == _stateId select m).AsEnumerable().Select(m => new SelectListItem() { Text = m.CityName, Value = m.CityID.ToString() });
        //    }
        //    return new SelectList(cityList, "Value", "Text", selectCityId);
        //}
        public JsonResult getServicesByAddmissionId(int addmissionId)
        {
            

            var result = db.AssignRooms.Where(m => m.AddmissionId == addmissionId).Select(c => new
            {
                ID = c.RoomId,
                Text = c.RoomName
            });

           // ViewBag["Room"] = result;
            return Json(result);
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
