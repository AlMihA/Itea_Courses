using System;
using System.Collections;


namespace Lesson17_HomeWork_Events
{
    public class FireService
    {
        public FireService(ArrayList city)
        {
            foreach (CityWithEvents _city in city)
            {
                _city.IncidentForFireService += new IncidentEventHandler(FireServiceIncident);
            }
        }

        public void FireServiceIncident(object sender, IncidentEventArgs e)
        {
            Console.WriteLine(e.CityName + ":" + "\t" + "The Fire Service received a call");
        }
    }
}
