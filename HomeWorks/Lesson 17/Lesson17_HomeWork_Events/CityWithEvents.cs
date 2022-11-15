using System;

namespace Lesson17_HomeWork_Events
{
    public delegate void IncidentEventHandler(object sender, IncidentEventArgs incidentEventArgs);
    public class CityWithEvents
    {
        private string cityName;

        public event IncidentEventHandler IncidentForPolice;
        public event IncidentEventHandler IncidentForFireService;
        public event IncidentEventHandler IncidentForAmbulance;

        private IncidentEventArgs eventArgs = new IncidentEventArgs();

        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        public virtual void OnHappenedPolice(IncidentEventArgs args, int needAmbulance)
        {
            if (null != IncidentForPolice)
            {
                IncidentForPolice(this, args);
                if (null != IncidentForAmbulance && needAmbulance < 15)
                {
                    Console.WriteLine("------------Need ambulance--------------");
                    IncidentForAmbulance(this, args);
                }
            }

        }
        public virtual void OnHappenedFireService(IncidentEventArgs args)
        {
            if (null != IncidentForFireService)
            {
                IncidentForFireService(this, args);
            }

        }
        public virtual void OnHappenedAmbulance(IncidentEventArgs args)
        {
            if (null != IncidentForAmbulance)
            {
                IncidentForAmbulance(this, args);
            }

        }
        public void GenerateIncident(int randomValue)
        {
	        eventArgs.CityName = cityName;

	        switch (randomValue)
	        {
		        case < 33:
			        OnHappenedPolice(eventArgs, randomValue);
			        break;
		        case < 66:
			        OnHappenedFireService(eventArgs);
			        break;
                case < 90:
                    OnHappenedAmbulance(eventArgs);
                    break;
                default:
                    Console.WriteLine(cityName+": no incidents"); ;
			        break;
	        }
        }

    }
}

