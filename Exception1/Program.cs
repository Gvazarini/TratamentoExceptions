using System;
using System.Globalization;
using System.Text;
using Exception1.Entities;
using Exception1.Entities.DomainException1;
namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime enterday = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime lastday = DateTime.Parse(Console.ReadLine());
                DateTime moment = DateTime.Now;


                Reservation reservation = new Reservation(number, enterday, lastday);
                Console.Write("Reservation: " + reservation);
                Console.WriteLine();
                Console.Write("Enter update reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                enterday = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                lastday = DateTime.Parse(Console.ReadLine());
                reservation.UpDateDates(enterday, lastday);

                reservation.UpDateDates(enterday, lastday);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException ex)
            {
                Console.WriteLine("Error in reservation. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error" + ex.Message);
            }
        }
    }
}
