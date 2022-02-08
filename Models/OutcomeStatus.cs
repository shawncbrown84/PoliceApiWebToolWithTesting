using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoliceApiWebToolWithTesting.Models
{
    public class OutcomeStatus
    {
        private string _category;
        public string category
        {
            get { return _category; }
            set
            {
                if (value != _category)
                {
                    _category = value;

                }
            }
        }


        private DateTime _date;
        public DateTime date
        {
            get { return _date; }
            set
            {
                if (value != _date)
                {
                    _date = value;

                }
            }
        }
    }
}