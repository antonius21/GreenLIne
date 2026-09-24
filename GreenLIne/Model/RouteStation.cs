using AuthenticationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLIne.Model
{
    internal class RouteStation
    {
        public int RouteId { get; set; }
        public int StationId { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }

        public RouteStation(int routeId, int stationId, DateTime arrivalTime, DateTime departureTime)
        {
            RouteId = routeId;
            StationId = stationId;
            ArrivalTime = arrivalTime;
            DepartureTime = departureTime;
        }

        public void ChangeArrivalTime(DateTime newArrivalTime)
        {
            ArrivalTime = newArrivalTime;
        }
        public void ChangeDepartureTime(DateTime newDepartureTime)
        {
            DepartureTime = newDepartureTime;
        }
    }
}
