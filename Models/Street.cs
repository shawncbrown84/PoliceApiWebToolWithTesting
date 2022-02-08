using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoliceApiWebToolWithTesting.Models
{
    public class Street
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set
            {
                if (value != _id)
                {
                    _id = value;

                }
            }
        }

        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                {
                    _name = value;

                }
            }
        }
    }
}