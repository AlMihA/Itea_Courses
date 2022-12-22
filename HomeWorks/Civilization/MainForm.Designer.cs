namespace Civilizations
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnStart = new System.Windows.Forms.Button();
			this.txtCivilization1 = new System.Windows.Forms.TextBox();
			this.txtCivilization2 = new System.Windows.Forms.TextBox();
			this.cmbBox_CurrentCivilization = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnDestroy = new System.Windows.Forms.Button();
			this.chkShowFight = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbBox_Timer = new System.Windows.Forms.ComboBox();
			this.btnApplyChanges = new System.Windows.Forms.Button();
			this.txtAdditionalResources = new System.Windows.Forms.TextBox();
			this.txtAdditionalDamage = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMaxGeneration = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblMaxGeneration1 = new System.Windows.Forms.Label();
			this.lblAdditionalDamage1 = new System.Windows.Forms.Label();
			this.lblAdditionalResources1 = new System.Windows.Forms.Label();
			this.lblMaxGeneration2 = new System.Windows.Forms.Label();
			this.lblAdditionalDamage2 = new System.Windows.Forms.Label();
			this.lblAdditionalResources2 = new System.Windows.Forms.Label();
			this.btnPause = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(483, 513);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(367, 64);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start game";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// txtCivilization1
			// 
			this.txtCivilization1.BackColor = System.Drawing.SystemColors.InfoText;
			this.txtCivilization1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtCivilization1.ForeColor = System.Drawing.Color.OrangeRed;
			this.txtCivilization1.Location = new System.Drawing.Point(22, 17);
			this.txtCivilization1.Multiline = true;
			this.txtCivilization1.Name = "txtCivilization1";
			this.txtCivilization1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtCivilization1.Size = new System.Drawing.Size(461, 455);
			this.txtCivilization1.TabIndex = 1;
			this.txtCivilization1.TextChanged += new System.EventHandler(this.txtCivilization1_TextChanged);
			// 
			// txtCivilization2
			// 
			this.txtCivilization2.BackColor = System.Drawing.SystemColors.InfoText;
			this.txtCivilization2.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtCivilization2.ForeColor = System.Drawing.Color.OrangeRed;
			this.txtCivilization2.Location = new System.Drawing.Point(847, 17);
			this.txtCivilization2.Multiline = true;
			this.txtCivilization2.Name = "txtCivilization2";
			this.txtCivilization2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtCivilization2.Size = new System.Drawing.Size(461, 455);
			this.txtCivilization2.TabIndex = 1;
			this.txtCivilization2.TextChanged += new System.EventHandler(this.txtCivilization2_TextChanged);
			// 
			// cmbBox_CurrentCivilization
			// 
			this.cmbBox_CurrentCivilization.FormattingEnabled = true;
			this.cmbBox_CurrentCivilization.Location = new System.Drawing.Point(43, 26);
			this.cmbBox_CurrentCivilization.Name = "cmbBox_CurrentCivilization";
			this.cmbBox_CurrentCivilization.Size = new System.Drawing.Size(234, 23);
			this.cmbBox_CurrentCivilization.TabIndex = 2;
			this.cmbBox_CurrentCivilization.SelectionChangeCommitted += new System.EventHandler(this.cmbBox_CurrentCivilization_SelectionChangeCommitted);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cmbBox_CurrentCivilization);
			this.panel1.Location = new System.Drawing.Point(497, 17);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(327, 455);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnDestroy);
			this.panel2.Controls.Add(this.chkShowFight);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.cmbBox_Timer);
			this.panel2.Controls.Add(this.btnApplyChanges);
			this.panel2.Controls.Add(this.txtAdditionalResources);
			this.panel2.Controls.Add(this.txtAdditionalDamage);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtMaxGeneration);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(14, 63);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(298, 372);
			this.panel2.TabIndex = 4;
			// 
			// btnDestroy
			// 
			this.btnDestroy.Location = new System.Drawing.Point(11, 245);
			this.btnDestroy.Name = "btnDestroy";
			this.btnDestroy.Size = new System.Drawing.Size(267, 23);
			this.btnDestroy.TabIndex = 8;
			this.btnDestroy.Text = "Destroy civilization";
			this.btnDestroy.UseVisualStyleBackColor = true;
			this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
			// 
			// chkShowFight
			// 
			this.chkShowFight.AutoSize = true;
			this.chkShowFight.Checked = true;
			this.chkShowFight.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkShowFight.Location = new System.Drawing.Point(28, 329);
			this.chkShowFight.Name = "chkShowFight";
			this.chkShowFight.Size = new System.Drawing.Size(87, 19);
			this.chkShowFight.TabIndex = 7;
			this.chkShowFight.Text = "Show fight";
			this.chkShowFight.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(106, 282);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "Choose timer";
			// 
			// cmbBox_Timer
			// 
			this.cmbBox_Timer.FormattingEnabled = true;
			this.cmbBox_Timer.Location = new System.Drawing.Point(28, 300);
			this.cmbBox_Timer.Name = "cmbBox_Timer";
			this.cmbBox_Timer.Size = new System.Drawing.Size(234, 23);
			this.cmbBox_Timer.TabIndex = 5;
			this.cmbBox_Timer.SelectionChangeCommitted += new System.EventHandler(this.cmbBox_Timer_SelectionChangeCommitted);
			// 
			// btnApplyChanges
			// 
			this.btnApplyChanges.Enabled = false;
			this.btnApplyChanges.Location = new System.Drawing.Point(11, 173);
			this.btnApplyChanges.Name = "btnApplyChanges";
			this.btnApplyChanges.Size = new System.Drawing.Size(267, 26);
			this.btnApplyChanges.TabIndex = 5;
			this.btnApplyChanges.Text = "Apply changes";
			this.btnApplyChanges.UseVisualStyleBackColor = true;
			this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
			// 
			// txtAdditionalResources
			// 
			this.txtAdditionalResources.Location = new System.Drawing.Point(11, 135);
			this.txtAdditionalResources.Name = "txtAdditionalResources";
			this.txtAdditionalResources.Size = new System.Drawing.Size(267, 23);
			this.txtAdditionalResources.TabIndex = 4;
			this.txtAdditionalResources.TextChanged += new System.EventHandler(this.txtAdditionalResources_TextChanged);
			// 
			// txtAdditionalDamage
			// 
			this.txtAdditionalDamage.Location = new System.Drawing.Point(11, 86);
			this.txtAdditionalDamage.Name = "txtAdditionalDamage";
			this.txtAdditionalDamage.Size = new System.Drawing.Size(267, 23);
			this.txtAdditionalDamage.TabIndex = 4;
			this.txtAdditionalDamage.TextChanged += new System.EventHandler(this.txtAdditionalDamage_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(11, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Additional resources";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(11, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Additional damage";
			// 
			// txtMaxGeneration
			// 
			this.txtMaxGeneration.Location = new System.Drawing.Point(11, 33);
			this.txtMaxGeneration.Name = "txtMaxGeneration";
			this.txtMaxGeneration.Size = new System.Drawing.Size(267, 23);
			this.txtMaxGeneration.TabIndex = 4;
			this.txtMaxGeneration.TextChanged += new System.EventHandler(this.txtMaxGeneration_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(11, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Max Generation";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(93, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Choose civilization";
			// 
			// lblMaxGeneration1
			// 
			this.lblMaxGeneration1.AutoSize = true;
			this.lblMaxGeneration1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblMaxGeneration1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblMaxGeneration1.ForeColor = System.Drawing.Color.White;
			this.lblMaxGeneration1.Location = new System.Drawing.Point(22, 513);
			this.lblMaxGeneration1.Name = "lblMaxGeneration1";
			this.lblMaxGeneration1.Size = new System.Drawing.Size(111, 17);
			this.lblMaxGeneration1.TabIndex = 3;
			this.lblMaxGeneration1.Text = "lblMaxGeneration1";
			// 
			// lblAdditionalDamage1
			// 
			this.lblAdditionalDamage1.AutoSize = true;
			this.lblAdditionalDamage1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblAdditionalDamage1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblAdditionalDamage1.ForeColor = System.Drawing.Color.White;
			this.lblAdditionalDamage1.Location = new System.Drawing.Point(22, 540);
			this.lblAdditionalDamage1.Name = "lblAdditionalDamage1";
			this.lblAdditionalDamage1.Size = new System.Drawing.Size(129, 17);
			this.lblAdditionalDamage1.TabIndex = 3;
			this.lblAdditionalDamage1.Text = "lblAdditionalDamage1";
			// 
			// lblAdditionalResources1
			// 
			this.lblAdditionalResources1.AutoSize = true;
			this.lblAdditionalResources1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblAdditionalResources1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblAdditionalResources1.ForeColor = System.Drawing.Color.White;
			this.lblAdditionalResources1.Location = new System.Drawing.Point(22, 569);
			this.lblAdditionalResources1.Name = "lblAdditionalResources1";
			this.lblAdditionalResources1.Size = new System.Drawing.Size(138, 17);
			this.lblAdditionalResources1.TabIndex = 3;
			this.lblAdditionalResources1.Text = "lblAdditionalResources1";
			// 
			// lblMaxGeneration2
			// 
			this.lblMaxGeneration2.AutoSize = true;
			this.lblMaxGeneration2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblMaxGeneration2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblMaxGeneration2.ForeColor = System.Drawing.Color.White;
			this.lblMaxGeneration2.Location = new System.Drawing.Point(1153, 513);
			this.lblMaxGeneration2.Name = "lblMaxGeneration2";
			this.lblMaxGeneration2.Size = new System.Drawing.Size(111, 17);
			this.lblMaxGeneration2.TabIndex = 3;
			this.lblMaxGeneration2.Text = "lblMaxGeneration2";
			this.lblMaxGeneration2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblAdditionalDamage2
			// 
			this.lblAdditionalDamage2.AutoSize = true;
			this.lblAdditionalDamage2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblAdditionalDamage2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblAdditionalDamage2.ForeColor = System.Drawing.Color.White;
			this.lblAdditionalDamage2.Location = new System.Drawing.Point(1153, 540);
			this.lblAdditionalDamage2.Name = "lblAdditionalDamage2";
			this.lblAdditionalDamage2.Size = new System.Drawing.Size(129, 17);
			this.lblAdditionalDamage2.TabIndex = 3;
			this.lblAdditionalDamage2.Text = "lblAdditionalDamage2";
			this.lblAdditionalDamage2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblAdditionalResources2
			// 
			this.lblAdditionalResources2.AutoSize = true;
			this.lblAdditionalResources2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblAdditionalResources2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblAdditionalResources2.ForeColor = System.Drawing.Color.White;
			this.lblAdditionalResources2.Location = new System.Drawing.Point(1153, 569);
			this.lblAdditionalResources2.Name = "lblAdditionalResources2";
			this.lblAdditionalResources2.Size = new System.Drawing.Size(138, 17);
			this.lblAdditionalResources2.TabIndex = 3;
			this.lblAdditionalResources2.Text = "lblAdditionalResources2";
			// 
			// btnPause
			// 
			this.btnPause.Location = new System.Drawing.Point(553, 590);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(230, 26);
			this.btnPause.TabIndex = 4;
			this.btnPause.Text = "Pause";
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1320, 700);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtCivilization2);
			this.Controls.Add(this.lblAdditionalResources2);
			this.Controls.Add(this.lblAdditionalResources1);
			this.Controls.Add(this.lblAdditionalDamage2);
			this.Controls.Add(this.lblAdditionalDamage1);
			this.Controls.Add(this.lblMaxGeneration2);
			this.Controls.Add(this.lblMaxGeneration1);
			this.Controls.Add(this.txtCivilization1);
			this.Controls.Add(this.btnStart);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Civilization";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtCivilization1;
		private System.Windows.Forms.TextBox txtCivilization2;
		private System.Windows.Forms.ComboBox cmbBox_CurrentCivilization;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAdditionalDamage;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMaxGeneration;
		private System.Windows.Forms.TextBox txtAdditionalResources;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblMaxGeneration1;
		private System.Windows.Forms.Label lblAdditionalDamage1;
		private System.Windows.Forms.Label lblAdditionalResources1;
		private System.Windows.Forms.Label lblMaxGeneration2;
		private System.Windows.Forms.Label lblAdditionalDamage2;
		private System.Windows.Forms.Label lblAdditionalResources2;
		private System.Windows.Forms.Button btnApplyChanges;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbBox_Timer;
		private System.Windows.Forms.CheckBox chkShowFight;
		private System.Windows.Forms.Button btnDestroy;
		private System.Windows.Forms.Button btnPause;
	}
}