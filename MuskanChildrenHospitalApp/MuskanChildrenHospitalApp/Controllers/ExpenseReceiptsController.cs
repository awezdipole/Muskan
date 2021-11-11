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
    public class ExpenseReceiptsController : Controller
    {
        private readonly IExpenseRepository _context;
        private readonly IExpenseHeadsRepository expense;

        public ExpenseReceiptsController(IExpenseRepository context,IExpenseHeadsRepository expense)
        {
            _context = context;
            this.expense = expense;
        }

        // GET: ExpenseReceipts
        public IActionResult Index()
        {
            return View(_context.GetExpenseReceipts());
        }

        // GET: ExpenseReceipts/Details/5
        public IActionResult Details(int id)
        {

            var expenseReceipt = _context.GetExpenseReceipt(id);
                
            if (expenseReceipt == null)
            {
                return NotFound();
            }

            return View(expenseReceipt);
        }

        // GET: ExpenseReceipts/Create
        public IActionResult Create()
        {
           
            ViewData["ExpenseHeadsId"] = new SelectList(expense.ExpenseHeads(), "Id", "HeadsName");
            return View();
        }

        // POST: ExpenseReceipts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Date,Amount,ReceiptNo,HeadsId")] ExpenseReceipt expenseReceipt)
        {
            if (ModelState.IsValid)
            {
                ViewData["ExpenseHeadsId"] = new SelectList(expense.ExpenseHeads(), "Id", "Id",expenseReceipt.HeadsId);
                _context.Add(expenseReceipt);
                return RedirectToAction(nameof(Index));
            }
            return View(expenseReceipt);
        }

        
    }
}
