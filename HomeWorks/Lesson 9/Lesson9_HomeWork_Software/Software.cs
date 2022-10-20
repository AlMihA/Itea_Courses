namespace Lesson9_HomeWork_Software
{
	internal class Software
	{
		public string Name { get; }
		public string Manufacturer { get; }

		protected Software(string name, string manufacturer)
		{
			this.Name = name;
			this.Manufacturer = manufacturer;
		}
		public virtual void ShowInformation()
		{
		}
		public virtual bool CanUseToday()
		{
			return false;
		}

	}
}
