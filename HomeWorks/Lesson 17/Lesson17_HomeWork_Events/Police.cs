using System;
using System.Collections;

namespace Lesson17_HomeWork_Events
{
    public class Police
    {
        public Police(ArrayList city)
        {
            foreach (CityWithEvents _city in city)
            {
                _city.IncidentForPolice += new IncidentEventHandler(PoliceIncident);
            }
        }

        public void PoliceIncident(object sender, IncidentEventArgs e)
        {
            Console.WriteLine(e.CityName +":" + "\t" + "The Police received a call");
        }


    }
}
