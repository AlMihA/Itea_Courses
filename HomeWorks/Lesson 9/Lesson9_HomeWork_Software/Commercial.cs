using System;

namespace Lesson9_HomeWork_Software
{
    internal class Commercial : Software
    {
	    public DateTime InstallDate { get; }
        public int TermOfUse { get; }
        public double Price { get; }

        public Commercial(string name, string manufacturer, DateTime installDate, int termOfUse, double price) : base(name, manufacturer)
        {
            this.InstallDate = installDate;
            this.TermOfUse = termOfUse;
            this.Price = price;
        }
        public override void ShowInformation()
        {
            Console.WriteLine($"Commercial - {Name},{Manufacturer}, Install: {InstallDate:d}, Term of use: {TermOfUse} days, Price: {Price:N} $");
        }
        public override bool CanUseToday()
        {
            return (InstallDate + TimeSpan.FromDays(TermOfUse)) >= DateTime.Now;
        }
    }
}
