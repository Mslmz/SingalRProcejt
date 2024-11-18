﻿namespace SignalR.EntityLayer.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string Name { get; set; }
        
        public string PhoneNumber { get; set; }

        public int PersonCount { get; set; }
        public DateTime Date { get; set; }  
    }
}
