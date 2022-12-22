using System;
using System.Collections.Generic;

namespace Civilizations
{
	public class Civilization
	{
		//кількість днів розвитку
		public int CountDay;
		//порядковий номер цивілізації для виводу в своє вікно(txtCivilization1,txtCivilization2 і т.п.), також lable(lblMaxGeneration1,lblMaxGeneration2 і т.п.) працюють по тій же схемі
		public int NumberCivilization;
		//додатковий урон для цивілізації
		public int AdditionalDamage;
		//додаткова кількість ресурсів для збору за день для кожного юніта
		public int AdditionalResources;
		//мітка початку війни
		public bool StartWar;
		//назва цивілізації
		public string Title { get; }
		//максимальна чисельність населення
		public int MaxGeneration { set; get; }
		//наявна кількість ресурсів
		public int ResourcesCount { set; get; }
		//тип юнітів цивілізації
		public UnitClassification UnitType { get; }
		//населення
		public List<Unit> Generation;
		//конструктор класу
		public Civilization(string title, int numberCivilization, int maxGeneration, UnitClassification unitType)
		{
			Title = title;
			NumberCivilization = numberCivilization;
			MaxGeneration = maxGeneration;
			UnitType = unitType;
			ResourcesCount = 100000;
			Generation = new List<Unit>();
			CountDay = 0;
			AdditionalDamage = 0;
			AdditionalResources = 0;
			StartWar = false;
		}
		
		//метод щоденного народження юнітів(рендомно від 1 до 1000)
		public string BornUnits()
		{
			Random random = new();
			int countUnits = random.Next(1, 1000);
			for (int i = 0; i < countUnits; i++)
			{
				Unit unit = new(UnitType);
				Generation.Add(unit);
			}
			return "Born " + countUnits + " units" + Environment.NewLine;
		}
		//метод щоденної гибелі юнітів(рендомно від 1 до 500) з початку списку
		//змінна byEpidemy вказує на причину загибелі для виводу інформації
		public string DieUnits(bool byEpidemy)
		{
			Random random = new();
			int countUnits = Math.Min(random.Next(1, 500), Generation.Count);
			List<Unit> listUnit = new();

			for (int i = 0; i < countUnits; i++)
			{
				listUnit.Add(Generation[i]);
			}
			foreach (Unit unit in listUnit)
			{
				Generation.Remove(unit);
			}
			string txtEpidemy = byEpidemy ? " by epidemy " : "";
			return "Died " + txtEpidemy + countUnits + " units" + Environment.NewLine;
		}
		//метод використання и добування ресурсів
		public string UsingResources()
		{
			foreach (Unit unit in Generation)
			{
				ResourcesCount += unit.ResourcesForDayGenerate + AdditionalResources - unit.ResourcesForDayUse;
			}
			ResourcesCount = Math.Max(0, ResourcesCount);
			return "Resources count - " + ResourcesCount + Environment.NewLine;
		}
		//метод генерації різних явищ
		//епідемія - загибель юнітів, шанс 20%(від 1 до 500)
		//голод - знищення ресурсів, шанс 20%(знищується п`ята частина ресурсів)
		//винаходи - додавання ресурсів, шанс 20%(додається половина існуючих ресурсів)
		public string GenerateEvents()
		{
			string txtEvents = "";
			Random random = new();
			int checkEpidemy = random.Next(1, 100);
			if (checkEpidemy <= 20)
			{
				txtEvents += DieUnits(true);
			}
			int checkHunger = random.Next(1, 100);
			if (checkHunger <= 20)
			{
				int destroyedResources = ResourcesCount / 20;
				ResourcesCount -= destroyedResources;
				txtEvents += "Destroyed resources : " + destroyedResources + Environment.NewLine;
			}
			int checkInvention = random.Next(1, 100);
			if (checkInvention <= 20)
			{
				int generatedResources = ResourcesCount / 2;
				ResourcesCount -= generatedResources;
				txtEvents += "Generated resources : " + generatedResources + Environment.NewLine;
			}
			return txtEvents;
		}
		//метод день - відбуваються всі події по черзі
		public string StartDay()
		{
			CountDay += 1;
			string eventsForDay = Title + ", Day " + CountDay.ToString() + ", Generation count - " + Generation.Count + Environment.NewLine;
			eventsForDay += BornUnits();
			eventsForDay += GenerateEvents();
			eventsForDay += DieUnits(false);
			eventsForDay += UsingResources();

			//якщо ресурси 0 або кількість юнітів перевищує максимальну, то активуємо мітку війни
			if (ResourcesCount == 0 || Generation.Count > MaxGeneration)
			{
				StartWar = true;
			}
			return eventsForDay;
		}
	}
}
