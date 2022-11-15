using System;
using System.Collections;

namespace Lesson17_HomeWork_Events
{
    public class Police
    {
        public ArrayListWithEvents listOfCity;

        public Police(ArrayListWithEvents city)
        {
            this.listOfCity = city;
            foreach (CityWithEvents _city in listOfCity)
            {
                _city.IncidentForPolice += new IncidentEventHandler(PoliceIncident);
            }
            listOfCity.ArrayChanged += new ArrayListChangedEventHandler(ArrayListChanged);
        }

        public void PoliceIncident(object sender, IncidentEventArgs e)
        {
            Console.WriteLine(e.CityName +":" + "\t" + "The Police received a call");
        }
        public void ArrayListChanged(object sender, ArrayListChangedEventArgs e)
        {
            CityWithEvents cityItem = (CityWithEvents)e.Item;
            cityItem.IncidentForPolice += new IncidentEventHandler(PoliceIncident);
        }


    }
}
