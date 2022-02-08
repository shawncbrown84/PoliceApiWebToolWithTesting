using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoliceApiWebToolWithTesting.Models
{
    public class CrimeSummary
    {
        private string _category;
        public string category
        {
            get { return _category; }
            set { _category = value; }
        }

        private int _count;
        public int count
        {
            get { return _count; }
            set { _count = value; }
        }
    }
}