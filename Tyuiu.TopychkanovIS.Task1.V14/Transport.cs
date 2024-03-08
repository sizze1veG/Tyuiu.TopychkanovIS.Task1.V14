using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.TopychkanovIS.Task1.V14
{
    internal class Transport
    {
        private TransportType _type;
        private int _routeNumber;
        private DateTime _routeIntroductionDate;
        private string _initialStop;
        private string _finalStop;
        private DateTime _routeTime;
        private string _note;

        public Transport(TransportType type, int routeNumber, DateTime routeIntroductionDate, string initialStop, string finalStop, DateTime routeTime, string note) 
        {
            _type = type;
            _routeNumber = routeNumber;
            _routeIntroductionDate = routeIntroductionDate;
            _initialStop = initialStop;
            _finalStop = finalStop;
            _routeTime = routeTime;
            _note = note;
        }

        public Transport GetTransport() => this;

        public override string ToString()
        {
            return _type.ToString() + " " + _routeNumber.ToString() + " " + _routeIntroductionDate.ToString() + " " 
                + _initialStop.ToString() + " " + _finalStop.ToString() + " " + _routeTime.ToString() + " " + _note.ToString();
        }
    }
}
