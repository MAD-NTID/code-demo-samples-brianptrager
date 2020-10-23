using System;
using System.Collections.Generic;
using System.Text;

namespace MAD4UFOS
{
    class Alien
    {
        private string name;

        public string Name
        {
            get { return name; }
            set {
                    if (value != "")
                    {
                        name = value;
                    }
                    else
                    {
                        name = "Unidentified";
                    }
                }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;

                if (date == null || date.ToLongDateString() == "")
                {
                    this.date = DateTime.Now;
                }
            }
        }

        private string location;

        public string Location
        {
            get { return location; }
            set 
            {
                if (value != "")
                {
                    location = value;
                }
                else
                {
                    location = "N/A";
                }
            }
        }

        public Alien() //default constructor
        {
            Name = "Unidentified";
            Date = DateTime.Now;
            Location = "N/A";
        }

        public Alien(string _name, DateTime _date, string _location)
        {
            Name = _name;
            Date = _date;
            Location = _location;
        }

        public override string ToString()
        {
            return String.Format($"{name,-12} {Date.ToShortDateString(),12} {Location,-12}");
        }
    }
}
