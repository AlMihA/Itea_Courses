using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_HomeWork_Events
{
    public class FireService
    {
        public FireService(CityWithEvents city)
        {
            city.IncidentForFireService += new IncidentEventHandler(FireServiceIncident);
        }

        public void FireServiceIncident(object sender, IncidentEventArgs e)
        {
            Console.WriteLine("FireService in " + e.CityName);
        }
    }
}
