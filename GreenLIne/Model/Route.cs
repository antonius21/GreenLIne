using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLIne.Model
{
    internal class Route
    {
        public int RouteId { get; set; }
        public string RouteName { get; set; }
        public int RouteNumber { get; set; }
        public RouteStatus Status { get; set; }
        public int TotalDistance { get; set; }
        public RouteType routeType { get; set; }
        public List<RouteStation> RouteStations { get; set; }

        public Route(int routeId, string routeName, int routeNumber, List<Station> stations, RouteStatus status, int totalDistance, RouteType routeType, List<Shedule> schedules)
        {
            RouteId = routeId;
            RouteName = routeName;
            RouteNumber = routeNumber;
            RouteStations = new List<RouteStation>();
            Status = status;
            TotalDistance = totalDistance;
            this.routeType = routeType;
        }
        public string AddStation(Station station)
        {
            // Implementation for adding station
            return $"Station {station.StationName} added to route {RouteName}.";
        }
        public string RemoveStation(Station station)
        {
            return $"Station {station.StationName} removed from route {RouteName}.";
        }

    }

    public enum RouteStatus
    {
        Active,
        Inactive,
        UnderConstruction,
        Closed
    }
    public enum RouteType
    {
        Bus,
        Train,
        Metro,
        Tram,
        Ferry
    }
}
