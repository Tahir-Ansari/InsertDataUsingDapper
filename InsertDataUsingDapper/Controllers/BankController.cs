using Dapper;
using InsertDataUsingDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace InsertDataUsingDapper.Controllers
{
    public class BankController : Controller
    {
        // GET: Bank
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<Bank>("BankDetailsViewAll",null));
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult AddOrEdit(Bank bank)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@BankId", bank.BankId);
            param.Add("@Name", bank.Name);
            param.Add("@Sales_Amount", bank.Sales_Amount);
            param.Add("@Date_Of_Sales", bank.Date_Of_Sales);
            param.Add("@Payment_Type", bank.Payment_Type);
            param.Add("@cash_Bank_Ledger", bank.cash_Bank_Ledger);
            param.Add("@RefNo", bank.RefNo);
            param.Add("@Status", bank.Status);
            DapperORM.ExecutedWithoutReturn("BankDetailsAddorEdit", param);

            return RedirectToAction("Index");
        }
    }
}