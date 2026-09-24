using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLIne.Model
{
    internal class Shedule
    {
        public int SheduleId { get; set; }
        public int RouteId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int Frequency { get; set; } // in minutes
        public Route Status { get; set; }

        public Shedule(int sheduleId, int routeId, DateTime departureTime, DateTime arrivalTime, int frequency)
        {
            SheduleId = sheduleId;
            RouteId = routeId;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            Frequency = frequency;
        }
        public void ChangeDepartureTime(DateTime newDepartureTime)
        {
            DepartureTime = newDepartureTime;
        }
        public void ChangeArrivalTime(DateTime newArrivalTime)
        {
            ArrivalTime = newArrivalTime;
        }
    }
}
