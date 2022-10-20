
namespace Lesson11_HomeWork_NFS_Windows_Forms
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonStart = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.buttonStart);
			this.panel1.Controls.Add(this.btnStart);
			this.panel1.Location = new System.Drawing.Point(693, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(301, 844);
			this.panel1.TabIndex = 0;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(94, 740);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(124, 32);
			this.buttonStart.TabIndex = 1;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(94, 793);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(124, 32);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "New race";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1020, 933);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Need For Speed 2D version";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button buttonStart;
	}
}

