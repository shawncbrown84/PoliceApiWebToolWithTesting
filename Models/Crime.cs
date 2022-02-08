using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoliceApiWebToolWithTesting.Models
{
    public class Crime
    {

        private string _category;
        public string category
        {
            get { return _category; }
            set { _category = value;}
        }


        private string _location_type;
        public string location_type
        {
            get { return _location_type; }
            set{ _location_type = value; }
        }

        private Location _location;
        public Location location
        {
            get { return _location; }
            set
            { _location = value;}
        }

        private string _context;
        public string context
        {
            get { return _context; }
            set
            {
                if (value != _context)
                {
                    _context = value;

                }
            }
        }

        private OutcomeStatus _outcome_status;
        public OutcomeStatus outcome_status
        {
            get { return _outcome_status; }
            set
            {
                if (value != _outcome_status)
                {
                    _outcome_status = value;

                }
            }
        }


        private string _persistent_id;
        public string persistent_id
        {
            get { return _persistent_id; }
            set
            {
                if (value != _persistent_id)
                {
                    _persistent_id = value;

                }
            }
        }

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

        private string _location_subtype;
        public string location_subtype
        {
            get { return _location_subtype; }
            set
            {
                if (value != _location_subtype)
                {
                    _location_subtype = value;

                }
            }
        }

        private DateTime _month;
        public DateTime month
        {
            get { return _month; }
            set
            {
                if (value != _month)
                {
                    _month = value;

                }
            }
        }


    }
}