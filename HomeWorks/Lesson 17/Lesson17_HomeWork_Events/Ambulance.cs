using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_HomeWork_Events
{
    public class Ambulance
    {
        public Ambulance(CityWithEvents city)
        {
            city.IncidentForAmbulance += new IncidentEventHandler(AmbulanceIncident);
        }

        public void AmbulanceIncident(object sender, IncidentEventArgs e)
        {
            Console.WriteLine("Ambulance in " + e.CityName);
        }
    }
}
