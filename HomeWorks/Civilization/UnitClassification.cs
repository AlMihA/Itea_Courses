namespace Civilizations
{
	public class UnitClassification
	{
		//назва типу юнітів(люди, орки і т.п.)
		public string Title { get; }
		//кількість урону за один удар
		public int Damage { get; }
		//кількість ресурсів, які добуває за добу
		public int ResourcesForDayGenerate { get; }
		//кількість ресурсів, які витрачає за добу
		public int ResourcesForDayUse { get; }
		//конструктор класу
		public UnitClassification(string title, int damage, int resourcesForDayGenerate, int resourcesForDayUse)
		{
			Title = title;
			Damage = damage;
			ResourcesForDayGenerate = resourcesForDayGenerate;
			ResourcesForDayUse = resourcesForDayUse;
		}
	}
}
