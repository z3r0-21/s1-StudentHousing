using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSoftware
{
    public class Announcements
    {
        private string announcement;


        public string Announcement
        {
            set { this.announcement = value; }
            get { return this.announcement; }
        }
        public Announcements(string newannouncement)
        {
            this.announcement = newannouncement;
        }
    }
}
