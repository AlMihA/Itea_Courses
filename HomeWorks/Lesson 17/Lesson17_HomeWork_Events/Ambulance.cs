using System;
using System.Collections;

namespace Lesson17_HomeWork_Events
{
    public class Ambulance
    {
        public Ambulance(ArrayList city)
        {
            foreach (CityWithEvents _city in city)
            {
                _city.IncidentForAmbulance += new IncidentEventHandler(AmbulanceIncident);
            }
        }

        public void AmbulanceIncident(object sender, IncidentEventArgs e)
        {
            Console.WriteLine(e.CityName + ":" + "\t" + "The Ambulance received a call");
        }
    }
}
