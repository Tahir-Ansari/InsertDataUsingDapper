using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InsertDataUsingDapper.Models
{
  
    public class Bank
    {
        public int BankId { get; set; }
        [Required(ErrorMessage ="please fill the name")]
        public string Name { get; set; }

       
        [Display(Name ="Sales Amount")]
        public string Sales_Amount { get; set; }


        [DataType(DataType.Date)]
        [Display(Name ="Date of Sales")]
        public DateTime Date_Of_Sales { get; set; }

        [Display(Name ="Payment Type")]
        public string Payment_Type { get; set; }

        [Display(Name ="Cash Bank Ledger")]
        public string cash_Bank_Ledger { get; set; }
        public string RefNo { get; set; }
        public string Status { get; set; }
    }
}