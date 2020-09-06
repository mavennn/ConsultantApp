using System;

namespace consultant.Models
{
    public class RequestModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string RoomNumber { get; set; }
        public string Status { get; set; }
    }
}