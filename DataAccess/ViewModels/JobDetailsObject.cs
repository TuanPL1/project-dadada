using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.ViewModels
{
    public class JobDetailsObject
    {
        public int Id { get; set; }

        public string Notes { get; set; }
        public int ClientId { get; set; }
        public int StatusId { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public decimal TotalCost { get; set; }
        public int AssignedTruckId { get; set; }
        public string AdjustmentMatrix { get; set; }
        public int PaymentMethodId { get; set; }
        
    }
}
