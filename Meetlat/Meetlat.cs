using System;
using System.Collections.Generic;
using System.Text;

namespace Meetlat
{
    class Meetlat
    {

        public Meetlat(double lengtestart)
        {
            lengteInM = lengtestart;
        }

        private double lengte;
        public double BeginLengte
        {
            set { lengte = value; }
        }

        private double lengteInM;

        public double LengteInCm
        {
            get { return (lengte * 100.0); }
        }
        public double LengteInKm
        {
            get { return (lengte / 1000.0); }
        }
        public double LengteInVoet
        {
            get { return (lengte * 3.2808); }
        }
    }
}
