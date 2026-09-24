using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLIne.Model
{
    internal class Station
    {
        public int StationId { get; set; }
        public string StationName { get; set; }
        public StationType Type { get; set; }
        public StationStatus Status { get; set; }

        public int Latitude { get; set; }
        public int Longitude { get; set; }

        public Station(int stationId, string stationName, StationType type, StationStatus status, int latitude, int longitude)
        {
            StationId = stationId;
            StationName = stationName;
            Type = type;
            Status = status;
            Latitude = latitude;
            Longitude = longitude;
        }

        public StationStatus GetStationStatus()
        {
            return Status;
        }
        public StationStatus CloseStation()
        {
            return StationStatus.Closed;
        }
    }

    public enum StationType
    {
        Bus,
        Train,
        Metro,
        Tram,
        Ferry
    }
    public enum StationStatus
    {
        Active,
        Inactive,
        UnderConstruction,
        Closed
    }
}
