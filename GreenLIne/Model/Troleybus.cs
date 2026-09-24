using AuthenticationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLIne.Model
{
    internal class Troleybus
    {
        public int TroleybusId { get; set; }
        public int RouteId { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public bool IsOperational { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
        public DateTime DateOfProduce { get; set; }

        public Troleybus(int troleybusId, int routeId, string model, int capacity, bool isOperational, DateTime lastMaintenanceDate, DateTime dateOfProduce)
        {
            TroleybusId = troleybusId;
            RouteId = routeId;
            Model = model;
            Capacity = capacity;
            IsOperational = isOperational;
            LastMaintenanceDate = lastMaintenanceDate;
            DateOfProduce = dateOfProduce;
        }
    }
}
