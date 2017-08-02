using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class JobDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobDetailsId { get; set; }

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
        public int JobStatusId { get; set; }
    }
}
