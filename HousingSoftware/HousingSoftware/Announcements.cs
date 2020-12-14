using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSoftware
{
    public class Announcements
    {
        /*private List<string> announcements = new List<string>();
        public string GetAnnouncements(string announcement)
        {
            for (int i = 0; i < announcements.Count; i++)
            {
                announcement = announcements[i];
            }
            return announcement;
        }
        public void AddAnnouncement(string announcement)
        {
           announcements.Add(announcement);
        }*/
        private string Announcement;



        public Announcements(string newAnnouncement)
        {
            Announcement = newAnnouncement;
        }
    }
}
