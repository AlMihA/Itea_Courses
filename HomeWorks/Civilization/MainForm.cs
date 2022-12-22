using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Civilizations
{
	public partial class MainForm : Form
	{
		//таймер між вивідами
		private int _pauseTimer = 500;
		//мітка закінчення війни для виходу з потоку
		public bool AppQuit = true;
		//мітка паузи
		public bool OnPause = false;
		//поток для цивілізацій
		public Thread? СivilizationsThread;
		//класи цивілізацій
		public Civilization? CivilizationsHuman, CivilizationsOrk, CivilizationForDestroy;
		//список діючих цивілізацій
		public List<Civilization>? ListOfCivilizations;

		#region "Form methods"
		public MainForm()
		{
			InitializeComponent();
		}
		//метод виводу повідомлень на екран
		private void UpdateTextBox(object? messageParams)
		{
			if (messageParams is not Dictionary<string, object> dictMessage) return;
			int? numberCivilization = (int)dictMessage["NumberCivilization"];
			string? txtForSend = (string)dictMessage["Message"];
			Controls["txtCivilization" + numberCivilization].Text += txtForSend + Environment.NewLine;
		}
		//метод виведення інформації в Label
		private void ShowInformation()
		{
			if (null != ListOfCivilizations)
			{
				foreach (Civilization civilization in ListOfCivilizations)
				{
					Controls["lblMaxGeneration" + civilization.NumberCivilization].Text = "Max generation: " + civilization.MaxGeneration;
					Controls["lblAdditionalDamage" + civilization.NumberCivilization].Text = "Additional damage: " + civilization.AdditionalDamage;
					Controls["lblAdditionalResources" + civilization.NumberCivilization].Text = "Additional resources: " + civilization.AdditionalResources;
				}
			}
		}
		//метод обробки зміни значенню таймеру
		private void cmbBox_Timer_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (cmbBox_Timer.SelectedItem.ToString() == "") return;
			if (int.TryParse(cmbBox_Timer.SelectedItem.ToString(), out int resultTimer))
			{
				_pauseTimer = resultTimer;
			}
		}
		//метод обробки зміни цивілізації
		private void cmbBox_CurrentCivilization_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (null == ListOfCivilizations) return;
			if (null == cmbBox_CurrentCivilization.SelectedItem ||
			    cmbBox_CurrentCivilization.SelectedItem.ToString() == "") return;
			foreach (Civilization civilization in ListOfCivilizations.Where(civilization =>
				         civilization.Title == cmbBox_CurrentCivilization.SelectedItem.ToString()))
			{
				txtMaxGeneration.Text = civilization.MaxGeneration.ToString();
				txtAdditionalDamage.Text = civilization.AdditionalDamage.ToString();
				txtAdditionalResources.Text = civilization.AdditionalResources.ToString();
			}
		}
		//метод обробки зміни поля MaxGeneration
		private void txtMaxGeneration_TextChanged(object sender, EventArgs e)
		{
			if (txtMaxGeneration.Focused)
			{
				btnApplyChanges.Enabled = true;
			}
		}
		//метод обробки зміни поля AdditionalDamage
		private void txtAdditionalDamage_TextChanged(object sender, EventArgs e)
		{
			if (txtAdditionalDamage.Focused)
			{
				btnApplyChanges.Enabled = true;
			}
		}
		//метод обробки зміни поля AdditionalResources
		private void txtAdditionalResources_TextChanged(object sender, EventArgs e)
		{
			if (txtAdditionalResources.Focused)
			{
				btnApplyChanges.Enabled = true;
			}
		}
		//метод прийняття змін параметрів цивілізації
		private void btnApplyChanges_Click(object sender, EventArgs e)
		{
			if (null != ListOfCivilizations)
			{
				if (cmbBox_CurrentCivilization.SelectedItem.ToString() != "" && int.TryParse(txtMaxGeneration.Text, out int resultMg)
					&& cmbBox_CurrentCivilization.SelectedItem.ToString() != "" && int.TryParse(txtAdditionalDamage.Text, out int resultAd)
					&& cmbBox_CurrentCivilization.SelectedItem.ToString() != "" && int.TryParse(txtAdditionalResources.Text, out int resultAr))
				{
					foreach (Civilization civilization in ListOfCivilizations.Where(civilization => civilization.Title == cmbBox_CurrentCivilization.SelectedItem.ToString()))
					{
						civilization.MaxGeneration = resultMg;
						civilization.AdditionalDamage = resultAd;
						civilization.AdditionalResources = resultAr;
						btnApplyChanges.Enabled = false;
					}
				}
				else
				{
					MessageBox.Show("Incorrect value");
				}
			}
			ShowInformation();
		}
		//автопрокрутка скролу
		private void txtCivilization1_TextChanged(object sender, EventArgs e)
		{
			txtCivilization1.SelectionStart = txtCivilization1.Text.Length;
			txtCivilization1.ScrollToCaret();
		}
		//автопрокрутка скролу
		private void txtCivilization2_TextChanged(object sender, EventArgs e)
		{
			txtCivilization2.SelectionStart = txtCivilization2.Text.Length;
			txtCivilization2.ScrollToCaret();
		}
		//кнопка початок/зупинка гри
		private void btnStart_Click(object sender, EventArgs e)
		{
			if (AppQuit)
			{
				AppQuit = false;
				btnStart.Text = "Stop game";
				StartGame();
			}
			else
			{
				AppQuit = true;
				btnStart.Text = "Start game";
			}
		}
		//кнопка пауза гри
		private void btnPause_Click(object sender, EventArgs e)
		{
			OnPause = true;
			MessageBox.Show("Game on pause. Press Ok to continue");
			OnPause = false;
		}
		//кнопка знищення поточної цивілізації
		private void btnDestroy_Click(object sender, EventArgs e)
		{
			if (null == ListOfCivilizations) return;
			if (null == cmbBox_CurrentCivilization.SelectedItem ||
			    cmbBox_CurrentCivilization.SelectedItem.ToString() == "") return;
			foreach (Civilization civilization in ListOfCivilizations.Where(civilization => civilization.Title == cmbBox_CurrentCivilization.SelectedItem.ToString()))
			{
				CivilizationForDestroy = civilization;
				break;
			}
		}
		//створення форми, початкові значення
		private void MainForm_Load(object sender, EventArgs e)
		{
			cmbBox_Timer.Items.Add("100");
			cmbBox_Timer.Items.Add("300");
			cmbBox_Timer.Items.Add("500");
			cmbBox_Timer.Items.Add("1000");
			cmbBox_Timer.Items.Add("2000");

			Controls["lblMaxGeneration1"].Text = "";
			Controls["lblAdditionalDamage1"].Text = "";
			Controls["lblAdditionalResources1"].Text = "";

			Controls["lblMaxGeneration2"].Text = "";
			Controls["lblAdditionalDamage2"].Text = "";
			Controls["lblAdditionalResources2"].Text = "";
		}
		//при закритті форми, активуємо мітку закінчення, щоб завершити поток цивілізацій
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			AppQuit = true;
		}
		#endregion

		#region "Game methods"
		//метод початку гри
		public void StartGame()
		{
			//створення двох цивілізацій
			txtCivilization1.Clear();
			txtCivilization2.Clear();
			UnitClassification unitHuman = new("Human", 50, 99, 100);
			CivilizationsHuman = new Civilization("Human's civilization", 1, 70000, unitHuman);

			UnitClassification unitOrk = new("Ork", 70, 79, 80);
			CivilizationsOrk = new Civilization("Ork's civilization", 2, 70000, unitOrk);

			ListOfCivilizations = new List<Civilization>
				{
					CivilizationsHuman,
					CivilizationsOrk
				};

			//створення 10000 юнітів для кожної цивілізації
			foreach (Civilization civilization in ListOfCivilizations)
			{
				for (int i = 0; i < 10000; i++)
				{
					Unit unit = new(civilization.UnitType);
					civilization.Generation.Add(unit);
				}
				//додавання цивілізації для вибору
				cmbBox_CurrentCivilization.Items.Add(civilization.Title);
			}

			//отримання контексту форму для можливості зміни елементів форму з потоку цивілізації
			SynchronizationContext? uiContext = SynchronizationContext.Current;

			//відрображення інформації по цивілізаціям
			ShowInformation();

			//запуск потоку цивілізацій з передачею контексту
			СivilizationsThread = new Thread(StartCivilization);
			СivilizationsThread.Start(uiContext);
		}
		//метод запуску цивілізацій в окремому потоці
		public void StartCivilization(object? context)
		{
			//перевірка змінних на наявність
			if (context is not SynchronizationContext uiContext || ListOfCivilizations is not { Count: > 0 }) return;
			//генерація стартових повідомлень
			foreach (Dictionary<string, object> listMessage in ListOfCivilizations.Select(civilization => new Dictionary<string, object>()
			         {
				         { "NumberCivilization", civilization.NumberCivilization },
				         { "Message", "Start Civilization " + civilization.Title }
			         }))
			{
				uiContext.Post(UpdateTextBox, listMessage);
			}
			//безкінечний цикл до моменту завершення гри
			while (!AppQuit)
			{
				foreach (Civilization civilization in ListOfCivilizations)
				{
					//запуск ігрового дня для цивілізації
					GenerateDay(civilization, uiContext);
					//якщо нема населення, то цивілізація знищується
					if (civilization.Generation.Count == 0)
					{
						CivilizationForDestroy = civilization;
					}
					else
					{
						//перевірка мітки початку війни
						if (civilization.StartWar)
						{
							//якщо є з ким воювати, то старт війни
							if (ListOfCivilizations.Count > 1)
							{
								if (!StartWar(uiContext))
								{
									AppQuit = true;
								}

								break;
							}

							//нема з ким воювати, інформую і гра закінчується
							Dictionary<string, object> listMessage = new()
							{
								{ "NumberCivilization", civilization.NumberCivilization },
								{ "Message", "Can't start war. No  opponent. Game stop" }
							};
							uiContext.Post(UpdateTextBox, listMessage);
							btnStart.Text = "Start game";
							AppQuit = true;

						}
					}

					//якщо натиснута кнопка паузи, то чекаю, поки не продовжиться гра
					while (OnPause) ;
				}
				//якщо є цивілізація на знищення
				if (null == CivilizationForDestroy) continue;
				
				{
					Dictionary<string, object> listMessage = new()
					{
						{ "NumberCivilization", CivilizationForDestroy.NumberCivilization },
						{ "Message", "DESTROY Civilization " + CivilizationForDestroy.Title }
					};
					uiContext.Post(UpdateTextBox, listMessage);
					ListOfCivilizations.Remove(CivilizationForDestroy);
					CivilizationForDestroy = null;
				}
			}
		}
		//метод генерації дня для цивілізації і вивід на екран подій, що відбулися
		public void GenerateDay(Civilization? civilization, SynchronizationContext? uiContext)
		{
			if (null == civilization || null == uiContext) return;
			string txtForSend = civilization.StartDay();
			Dictionary<string, object> listMessage = new()
			{
				{ "NumberCivilization", civilization.NumberCivilization },
				{ "Message", txtForSend }
			};

			uiContext.Post(UpdateTextBox, listMessage);
			Thread.Sleep(_pauseTimer);
		}
		//метод початку війни
		public bool StartWar(SynchronizationContext? uiContext)
		{
			//вікно з попередженням про початок війни, зроблено, щоб не прогавити :)
			MessageBox.Show("Start war. Press Ok");
			bool findAttackCivilization = false;
			bool findDefendCivilization = false;
			Civilization? attackCivilization = null;
			Civilization? defendCivilization = null;

			//пошук цивілізацій для атаки. Та що з міткою війни буде атакувати
			//якщо обидві з мітками, то береться перша, а інша буде захищатись
			if (null != ListOfCivilizations)
			{
				foreach (Civilization civilization in ListOfCivilizations)
				{
					if (civilization.StartWar)
						if (findAttackCivilization)
						{
							defendCivilization = civilization;
							findDefendCivilization = true;
						}
						else
						{
							attackCivilization = civilization;
							findAttackCivilization = true;
						}
					else
					{
						if (!findDefendCivilization)
						{
							defendCivilization = civilization;
							findDefendCivilization = true;
						}
					}
					if (findAttackCivilization && findDefendCivilization)
					{
						break;
					}
				}
			}
			else
			{
				return false;
			}
			//старт бійки
			return StartFight(attackCivilization, defendCivilization, uiContext);
		}
		//метод початку бійки між цивілізаціями
		public bool StartFight(Civilization? attackCivilization, Civilization? defendCivilization, SynchronizationContext? uiContext)
		{
			//перевірка значень
			if (null != attackCivilization && null != defendCivilization)
			{
				List<Unit> unitsAttack = new();
				List<Unit> unitsDefend = new();

				Dictionary<string, object> listMessage;

				Random random = new();

				//для участі в бійці береться половина кількості меншої за кількістю цивілізації
				int countUnitsForDight = Math.Min(attackCivilization.Generation.Count, defendCivilization.Generation.Count) / 2;

				//додавання юнітів в список бійців
				for (int i = 0; i < countUnitsForDight; i++)
				{
					unitsAttack.Add(attackCivilization.Generation[i]);
					unitsDefend.Add(defendCivilization.Generation[i]);
				}
				//зміна таймеру для пришвидшення виводу
				int oldPauseTimer = _pauseTimer;
				_pauseTimer = 50;

				//поки є ким воювати проведення зіткнення
				while (unitsAttack.Count > 0 && unitsDefend.Count > 0 && null != uiContext)
				{
					//рандомно вибираються юніти для бійки з кожної цивілізації
					int attackNumber = random.Next(0, unitsAttack.Count - 1);
					int defenderNumber = random.Next(0, unitsDefend.Count - 1);

					//рендомний коефіціент атаки
					int koefAttack = random.Next(1, 100);
					int koefDefend = random.Next(1, 100);

					//підрахунок удару з урахуванням додаткового урону і коефіцієнту
					int pointsAttack = (unitsAttack[attackNumber].Damage + attackCivilization.AdditionalDamage) * koefAttack / 100;
					int pointsDefend = (unitsDefend[defenderNumber].Damage + defendCivilization.AdditionalDamage) * koefDefend / 100;

					//віднімання життя у юніта
					unitsAttack[attackNumber].Health -= pointsDefend;
					unitsDefend[defenderNumber].Health -= pointsAttack;

					//якщо у юніта життя менше нуля, то він знищен в цивілізації і списку бійців на війні
					if (unitsAttack[attackNumber].Health <= 0)
					{
						//відображення знищення, якщо активний флажок показувати бійку
						if (chkShowFight.Checked)
						{
							listMessage = new Dictionary<string, object>
							{
								{ "NumberCivilization", attackCivilization.NumberCivilization },
								{ "Message", "Died N " + attackNumber }
							};
							uiContext.Post(UpdateTextBox, listMessage);
						}

						attackCivilization.Generation.Remove(unitsAttack[attackNumber]);
						unitsAttack.RemoveAt(attackNumber);
					}

					if (unitsDefend[defenderNumber].Health > 0) continue;
					if (chkShowFight.Checked)
					{
						listMessage = new Dictionary<string, object>
						{
							{ "NumberCivilization", defendCivilization.NumberCivilization },
							{ "Message", "Died N " + defenderNumber }
						};
						uiContext.Post(UpdateTextBox, listMessage);
						Thread.Sleep(_pauseTimer);
					}
					defendCivilization.Generation.Remove(unitsDefend[defenderNumber]);
					unitsDefend.RemoveAt(defenderNumber);
				}

				//підрахунок жертв війни
				string resultForAttack = "";
				string resultForDefend = "";

				//програна сторона отримує 10тис ресурів, переможці 100 тис
				if (unitsAttack.Count == 0)
				{
					defendCivilization.ResourcesCount += 100000;
					attackCivilization.ResourcesCount += 10000;
					resultForAttack = "LOSE!!! ";
					resultForDefend = "WIN!!! ";
				}
				else if (unitsDefend.Count == 0)
				{
					attackCivilization.ResourcesCount += 100000;
					defendCivilization.ResourcesCount += 10000;
					resultForAttack = "WIN!!! ";
					resultForDefend = "LOSE!!! ";
				}

				//вивід результатів війни
				if (null != uiContext)
				{
					listMessage = new Dictionary<string, object>
					{
						{ "Message", resultForAttack + "Died count at war " + (countUnitsForDight - unitsAttack.Count) + Environment.NewLine },
						{ "NumberCivilization", attackCivilization.NumberCivilization }
					};
					uiContext.Post(UpdateTextBox, listMessage);

					listMessage = new Dictionary<string, object>
					{
						{ "Message", resultForDefend + "Died count at war  " + (countUnitsForDight - unitsDefend.Count) + Environment.NewLine },
						{ "NumberCivilization", defendCivilization.NumberCivilization }
					};
					uiContext.Post(UpdateTextBox, listMessage);
				}
				//зміна міток війни
				attackCivilization.StartWar = false;
				defendCivilization.StartWar = false;
				//повернення таймеру
				_pauseTimer = oldPauseTimer;

				return true;
			}
			return false;
		}
		#endregion
	}
}
