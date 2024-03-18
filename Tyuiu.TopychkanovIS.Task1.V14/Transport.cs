using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.TopychkanovIS.Task1.V14
{
    internal class Transport
    {
        public TransportType Type { get; private set; }
        public int RouteNumber { get; private set;  }
        public DateTime RouteIntroductionDate { get; private set; }
        public string InitialStop { get; private set; }
        public string FinalStop { get; private set; }
        public DateTime RouteTime { get; private set; }
        public string Note { get; private set; }

        public Transport(TransportType type, int routeNumber, DateTime routeIntroductionDate, string initialStop, string finalStop, DateTime routeTime, string note) 
        {
            Type = type;
            RouteNumber = routeNumber;
            RouteIntroductionDate = routeIntroductionDate;
            InitialStop = initialStop;
            FinalStop = finalStop;
            RouteTime = routeTime;
            Note = note;
        }

        public Transport GetTransport() => this;

        private string GetType()
        {
            if (Type == TransportType.Bus)
                return "Автобус";
            else if (Type == TransportType.Shuttle)
                return "Маршрутка";
            else if (Type == TransportType.Streetcar)
                return "Трамвай";
            else
                return "Метро";
        }

        public override string ToString()
        {
            return GetType() + " " + RouteNumber.ToString() + " " + RouteIntroductionDate.ToString($"d") + " " 
                + InitialStop.ToString() + " " + FinalStop.ToString() + " " + RouteTime.ToString($"t") + " " + Note.ToString();
        }
    }
}
