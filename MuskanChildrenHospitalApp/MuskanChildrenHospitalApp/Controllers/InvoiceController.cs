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
          
            // List<service> services=new List<service>();
            List<service> services = db.Services.ToList();
            ViewData["services"] = services;
            //collection_Invoice inv = new collection_Invoice();
            //mBillDetailsService detailsService = new mBillDetailsService();
            //foreach (var item in services)
            //{
            //    detailsService.ServiceId = item.id;
            //    detailsService.ServiceName = item.ServiceName;
            //    detailsService.Price = item.Charges;
            //}


            //for (int i = 0; i <= services.Count; i++)
            //{
            //    inv.ServiceDetails[i].ServiceId = services[i].id;
            //    inv.ServiceDetails[i].ServiceName = services[i].ServiceName;
            //    inv.ServiceDetails[i].Price = services[i].Charges;
            //}
            return View();
        }

        public JsonResult getservices()
        {
            var result = db.Services.ToList();
            return Json(result);
        }

        [HttpPost]
        public JsonResult add(string BillNo, string Date, string Diagnosis, string RegNo, string addmisionId, string AmtInWords, string TotalAmt,
           string AdvanceAmt, string BalanceAmt, string RefundAmt, string DiscountAmt, string PaidAmt, mBillDetailsService[] Services, mBillRommDetailsCharges[] Roomdetails)
        {
            string result = "Error! Order Is Not Complete!";
            if (BillNo != null && addmisionId!=null && PaidAmt !=null  && Date!=null)
            {
                mBill inv = new mBill();
                inv.Date = Date;
                inv.TotalAmt = Convert.ToDecimal(TotalAmt);
                inv.AdvanceAmt = Convert.ToDecimal(AdvanceAmt);
                inv.RefundAmt = Convert.ToDecimal(RefundAmt);
                inv.RegNo = RegNo;
                inv.BillNo = BillNo;
                inv.BalanceAmt = Convert.ToDecimal(BalanceAmt);
                inv.PaidAmt = Convert.ToDecimal(PaidAmt);
                inv.addmisionId = Convert.ToInt32(addmisionId);

                mBillDetailsService detailsService = new mBillDetailsService();

                foreach (var details in Services)
                {
                    detailsService.ServiceId = details.ServiceId;
                    detailsService.ServiceName = details.ServiceName;
                    detailsService.Price = details.Price;
                    detailsService.Day = details.Day;
                    details.Amount = details.Amount;
                    details.mBillId = inv.id;

                    inv.mServices.Add(details);
                }
                mBillRommDetailsCharges roomCharges = new mBillRommDetailsCharges();

                foreach(var room in Roomdetails)
                {
                    roomCharges.roomId = room.roomId;
                    roomCharges.Charge = room.Charge;
                    roomCharges.Days = room.Days;
                    roomCharges.Amount = room.Amount;
                    roomCharges.BillId = inv.id;
                    inv.mRooms.Add(roomCharges);
                }

                db.Bills.Add(inv);
                db.SaveChanges();

                result = inv.BillNo;
                ViewData["AddmisionId"] = new SelectList(Admission.GetAddmisions(), "id", "RegNo", inv.addmisionId);
            ViewData["service"] = new SelectList(Iservice.GetAllServices(), "id", "ServiceName");
            ViewData["Room"] = new SelectList(Assign.GetAssignRoomsByAddId(inv.addmisionId), "RoomId", "RoomName");
                return Json(result);
            }
            
            return Json(result);
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

        public JsonResult advanceamountbyid(int addmissionId)
        {

            var receiptsList = db.Receipts.Where(a => a.AddmisionId == addmissionId);
            var result= receiptsList.Sum(x => x.Amount);
           
            //= db.Rooms.Where(o => o.Id == addmissionId).SingleOrDefault();

           // var totalcharge = result.TotalCharges;

            //ViewData["Room"] = result;
            return Json(result);
        }
        public JsonResult roomchragesbyid(int addmissionId)
        {


            var result = db.Rooms.Where(o => o.Id == addmissionId).SingleOrDefault();

            var totalcharge = result.TotalCharges;

            //ViewData["Room"] = result;
            return Json(totalcharge);
        }

        public JsonResult servicechragesbyid(int serviceId)
        {


            var result = db.Services.Where(a => a.id == serviceId).FirstOrDefault();

            var charges = result.Charges;

            //ViewData["Room"] = result;
            return Json(charges);
        }
    }
}
