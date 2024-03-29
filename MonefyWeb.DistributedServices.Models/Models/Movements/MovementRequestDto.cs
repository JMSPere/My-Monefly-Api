﻿using MonefyWeb.Transversal.Models;

namespace MonefyWeb.DistributedServices.Models.Models.Movements
{
    public class MovementRequestDto
    {
        public long AccountId { get; set; }
        public string Concept { get; set; }
        public decimal Amount { get; set; }
        public DateTime MovementDate { get; set; }
        public EMovementType Type { get; set; }
        public EPaymentMethod PaymentMethod { get; set; }
        public long CategoryId { get; set; }
        public long CurrencyId { get; set; }
    }
}
