using System;

namespace DataAccess.ViewModels
{
    public class DeliveryObject
    {
        public int Id { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public int TruckId { get; set; }
        public bool UnscheduleAssist { get; set; }
        public int OperationManagerStaffId { get; set; }
        public int TeamLeaderStaffId { get; set; }
    }
}