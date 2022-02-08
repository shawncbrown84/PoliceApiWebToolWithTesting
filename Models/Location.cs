using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoliceApiWebToolWithTesting.Models
{
    public class Location
    {
        private double _latitude;
        public double latitude
        {
            get { return _latitude; }
            set
            {
                if (value != _latitude)
                {
                    _latitude = value;

                }
            }
        }

        private double _longitude;
        public double longitude
        {
            get { return _longitude; }
            set
            {
                if (value != _longitude)
                {
                    _longitude = value;

                }
            }
        }



        private Street _street;
        public Street street
        {
            get { return _street; }
            set
            {
                if (value != _street)
                {
                    _street = value;
                }
            }
        }
    }
}