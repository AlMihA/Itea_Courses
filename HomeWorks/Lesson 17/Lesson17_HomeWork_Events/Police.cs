using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_HomeWork_Events
{
    public class Police
    {
        public Police(CityWithEvents city)
        {
            city.IncidentForPolice += new IncidentEventHandler(PoliceIncident);
        }

        public void PoliceIncident(object sender, IncidentEventArgs e)
        {
            Console.WriteLine("Police in " + e.CityName);
        }
    }
}
