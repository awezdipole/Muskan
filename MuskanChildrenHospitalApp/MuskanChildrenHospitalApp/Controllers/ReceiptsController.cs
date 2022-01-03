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

namespace MuskanChildrenHospitalApp.Controllers
{
    public class ReceiptsController : Controller
    {
        private readonly IReceiptRepository _context;
        private readonly IAdmissionRepositoy _contextAddmision;
        private readonly IincomeHeadsRepository _contextIncome;

        public ReceiptsController(IReceiptRepository context, IAdmissionRepositoy admission,IincomeHeadsRepository income)
        {
            _context = context;
            _contextAddmision = admission;
            _contextIncome = income;
        }

        // GET: Receipts
        public IActionResult Index()
        {
           
            return View(_context.Receipts());
        }

        // GET: Receipts/Details/5
        public IActionResult Details(int id)
        {
            var receipt = _context.GetReceipt(id);
            if (receipt == null)
            {
                return NotFound();
            }

            return View(receipt);
        }

        // GET: Receipts/Create
        public IActionResult Create()
        {
            ViewData["AddmisionId"] = new SelectList(_contextAddmision.GetAddmisions(), "id", "RegNo");
            ViewData["HeadsId"] = new SelectList(_contextIncome.IncomeHeads(), "Id", "Id");
            return View();
        }

        // POST: Receipts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Date,Amount,ReceiptNo,RegistrationNumber,AddmisionId,HeadsId")] Receipt receipt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(receipt);
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddmisionId"] = new SelectList(_contextAddmision.GetAddmisions(), "id", "id", receipt.AddmisionId);
            //ViewData["HeadsId"] = new SelectList(_contextIncome.IncomeHeads(), "Id", "Id", receipt.HeadsId);
            return View(receipt);
        }

    }
}
