using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Panda.App.Models.Receipts
{
    public class ReceiptViewModel
    {
        public string Id { get; set; }

        public decimal Fee { get; set; }

        [Display(Name = "Issued On")]
        public string IssuedOn { get; set; }

        public string RecipientName { get; set; }

        public string RecipientId { get; set; }
    }
}
