using System;

namespace Lesson9_HomeWork_Software
{
    internal class Trial : Software
    {
        public DateTime InstallDate { get; }
        public int TrialTime { get; }
        
        public Trial(string name, string manufacturer, DateTime installDate, int trialTime) : base(name, manufacturer)
        {
            this.InstallDate = installDate;
            this.TrialTime = trialTime;
        }
        public override void ShowInformation()
        {
            Console.WriteLine($"Trial - {Name}({Manufacturer}), Install: {InstallDate:d}, Trial time: {TrialTime} days");
        }
        public override bool CanUseToday()
        {
            return (InstallDate + TimeSpan.FromDays(TrialTime)) >= DateTime.Now;
        }
    }
}
