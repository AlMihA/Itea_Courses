using System;
using System.Collections;


namespace Lesson17_HomeWork_Events
{
    public class FireService
    {
        public ArrayListWithEvents listOfCity;

        public FireService(ArrayListWithEvents city)
        {
            this.listOfCity = city;
            foreach (CityWithEvents _city in listOfCity)
            {
                _city.IncidentForFireService += new IncidentEventHandler(FireServiceIncident);
            }
            listOfCity.ArrayChanged += new ArrayListChangedEventHandler(ArrayListChanged);
        }

        public void FireServiceIncident(object sender, IncidentEventArgs e)
        {
            Console.WriteLine(e.CityName + ":" + "\t" + "The Fire Service received a call");
        }
        public void ArrayListChanged(object sender, ArrayListChangedEventArgs e)
        {
            CityWithEvents cityItem = (CityWithEvents)e.Item;
            cityItem.IncidentForFireService += new IncidentEventHandler(FireServiceIncident);
        }
    }
}
