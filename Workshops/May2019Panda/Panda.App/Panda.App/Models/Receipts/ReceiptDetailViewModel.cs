using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Panda.App.Models.Receipts
{
    public class ReceiptDetailViewModel : ReceiptViewModel
    {      
        [Display(Name = "Delivery Address")]
        public string DeliveryAddress { get; set; }

        [Display(Name = "Package Weight")]
        public double Weight { get; set; }

        public string Description { get; set; }
    }
}
