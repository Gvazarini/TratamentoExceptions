using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception1.Entities.DomainException1;

namespace Exception1.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Reservation error! Check-out day, must be later than Ckeck-in date.");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;

        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)(duration.TotalDays);
        }
        public void UpDateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation error: Reservation dates for update must be future dates.");
            }
            if (checkout <= checkin)
            {
                throw new DomainException( "Reservation error! Check-out day, must be later than Ckeck-in date.");
            }
            CheckIn = checkin;
            CheckOut=checkout;
           
        }
        public override string ToString()
        {
            return "Room reservation: " + RoomNumber + ", check-in: " + CheckIn.ToString("dd/MM/yyyy") + ", check-out: " + CheckOut.ToString("dd/MM/yyyy") + ", Duration: " + Duration() + " nights";
        }
    }
}
