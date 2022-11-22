using System;
using System.Collections;

namespace Lesson17_HomeWork_Events
{
    public class Ambulance
    {
        public ArrayListWithEvents listOfCity;

        public Ambulance(ArrayListWithEvents city)
        {
            this.listOfCity = city;
            foreach (CityWithEvents _city in listOfCity)
            {
                _city.IncidentForAmbulance += new IncidentEventHandler(AmbulanceIncident);
            }
            listOfCity.ArrayChanged += new ArrayListChangedEventHandler(ArrayListChanged);
        }

        public void AmbulanceIncident(object sender, IncidentEventArgs e)
        {
            Console.WriteLine(e.CityName + ":" + "\t" + "The Ambulance received a call");
        }
        public void ArrayListChanged(object sender, ArrayListChangedEventArgs e)
        {
            CityWithEvents cityItem = (CityWithEvents)e.Item;
            cityItem.IncidentForAmbulance += new IncidentEventHandler(AmbulanceIncident);
        }
    }
}
