﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models_PolyCafe
{
    public class Invoice
    {
        public string? Id { get; set; }
        public string? CardId { get; set; } //The ID of the membership card used for the invoice
        public string? StaffId { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}


