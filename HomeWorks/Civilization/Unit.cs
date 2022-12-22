namespace Civilizations
{
	public class Unit
	{
		//тип юніту(люди, орки і т.п.)
		public UnitClassification UnitType { set; get; }
		//здоров'я на початку(100)
		public int Health { set; get; }
		//кількість урону за один удар
		public int Damage { set; get; }
		//кількість ресурсів, які добуває за добу
		public int ResourcesForDayGenerate { set; get; }
		//кількість ресурсів, які витрачає за добу
		public int ResourcesForDayUse { set; get; }
		//конструктор класу
		public Unit(UnitClassification unitType)
		{
			UnitType = unitType;
			Health = 100;
			Damage = UnitType.Damage;
			ResourcesForDayGenerate = UnitType.ResourcesForDayGenerate;
			ResourcesForDayUse = UnitType.ResourcesForDayUse;
		}
	}
}
