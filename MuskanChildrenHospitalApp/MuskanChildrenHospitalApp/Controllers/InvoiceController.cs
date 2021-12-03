using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MuskanChildrenHospitalApp.Data;
using MuskanChildrenHospitalApp.Models;
using MuskanChildrenHospitalApp.Models.Interface;
using MuskanChildrenHospitalApp.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly IBillRepository context;

        public IAssignRoomRepository Assign { get; }
        public IAdmissionRepositoy Admission { get; }
        public IserviceRepository Iservice { get; }

        public InvoiceController(ApplicationDbContext db, IBillRepository context, IAssignRoomRepository assign, IAdmissionRepositoy admission, IserviceRepository iservice)
        {
            this.db = db;
            this.context = context;
            Assign = assign;
            Admission = admission;
            Iservice = iservice;
        }
        public IActionResult Index()
        {
            return View(context.bills());
        }

        public IActionResult add()
        {
            ViewData["AddmisionId"] = new SelectList(Admission.GetAddmisions(), "id", "RegNo");
            ViewData["service"] = new SelectList(Iservice.GetAllServices(), "id", "ServiceName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult add(collection_Invoice coInvoice)
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

                foreach (var details in coInvoice.ServiceDetails)
                {
                    detailsService.ServiceId = details.ServiceId;
                    detailsService.ServiceName = details.ServiceName;
                    detailsService.Price = details.Price;
                    detailsService.Day = details.Day;
                    details.Amount = details.Amount;
                }

            }
            ViewData["AddmisionId"] = new SelectList(Admission.GetAddmisions(), "id", "RegNo", coInvoice.bill.addmisionId);
            ViewData["service"] = new SelectList(Iservice.GetAllServices(), "id", "ServiceName");
            ViewData["Room"] = new SelectList(Assign.GetAssignRoomsByAddId(coInvoice.bill.addmisionId), "RoomId", "RoomName");
            return View(coInvoice);
        }
        public JsonResult getServicesByAddmissionId(int addmissionId)
        {


            var result = db.AssignRooms.Where(m => m.AddmissionId == addmissionId).Select(c => new
            {
                ID = c.RoomId,
                Text = c.RoomName
            });



             ViewData["Room"] = result;
            return Json(result);
        }
        public JsonResult roomchragesbyid(int addmissionId)
        {


            var result = db.Rooms.Where(o => o.Id == addmissionId).SingleOrDefault();



            //ViewData["Room"] = result;
            return Json(result);
        }
    }
}
