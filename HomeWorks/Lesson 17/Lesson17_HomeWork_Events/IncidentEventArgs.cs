using System;

namespace Lesson17_HomeWork_Events
{
    public class IncidentEventArgs: EventArgs
    {
        private string cityName;
        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }
    }

    
}
