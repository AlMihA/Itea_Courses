namespace Lesson5_HomeWork_ShotInTarget
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
			this.btnShot = new System.Windows.Forms.Button();
			this.txtRadius = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelKeyboard = new System.Windows.Forms.Panel();
			this.labelSumPoints = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelCurrentPoints = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelCurrentShot = new System.Windows.Forms.Label();
			this.buttonClear = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panelKeyboard.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnShot
			// 
			this.btnShot.Location = new System.Drawing.Point(38, 385);
			this.btnShot.Name = "btnShot";
			this.btnShot.Size = new System.Drawing.Size(128, 31);
			this.btnShot.TabIndex = 0;
			this.btnShot.Text = "П і у!";
			this.btnShot.UseVisualStyleBackColor = true;
			this.btnShot.Click += new System.EventHandler(this.btnShot_Click);
			// 
			// txtRadius
			// 
			this.txtRadius.Location = new System.Drawing.Point(126, 29);
			this.txtRadius.Name = "txtRadius";
			this.txtRadius.Size = new System.Drawing.Size(49, 23);
			this.txtRadius.TabIndex = 1;
			this.txtRadius.Text = "20";
			this.txtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRadius.TextChanged += new System.EventHandler(this.txtRadius_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Радіус(від 0 до 20)";
			// 
			// panelKeyboard
			// 
			this.panelKeyboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelKeyboard.Controls.Add(this.labelSumPoints);
			this.panelKeyboard.Controls.Add(this.label4);
			this.panelKeyboard.Controls.Add(this.labelCurrentPoints);
			this.panelKeyboard.Controls.Add(this.label3);
			this.panelKeyboard.Controls.Add(this.labelCurrentShot);
			this.panelKeyboard.Controls.Add(this.buttonClear);
			this.panelKeyboard.Controls.Add(this.label2);
			this.panelKeyboard.Controls.Add(this.label1);
			this.panelKeyboard.Controls.Add(this.txtRadius);
			this.panelKeyboard.Controls.Add(this.btnShot);
			this.panelKeyboard.Location = new System.Drawing.Point(662, 12);
			this.panelKeyboard.Name = "panelKeyboard";
			this.panelKeyboard.Size = new System.Drawing.Size(212, 440);
			this.panelKeyboard.TabIndex = 4;
			// 
			// labelSumPoints
			// 
			this.labelSumPoints.AutoSize = true;
			this.labelSumPoints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelSumPoints.ForeColor = System.Drawing.Color.Maroon;
			this.labelSumPoints.Location = new System.Drawing.Point(29, 272);
			this.labelSumPoints.MinimumSize = new System.Drawing.Size(153, 21);
			this.labelSumPoints.Name = "labelSumPoints";
			this.labelSumPoints.Size = new System.Drawing.Size(153, 21);
			this.labelSumPoints.TabIndex = 9;
			this.labelSumPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.Maroon;
			this.label4.Location = new System.Drawing.Point(57, 236);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 21);
			this.label4.TabIndex = 8;
			this.label4.Text = "Сума балів";
			// 
			// labelCurrentPoints
			// 
			this.labelCurrentPoints.AutoSize = true;
			this.labelCurrentPoints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelCurrentPoints.ForeColor = System.Drawing.Color.Maroon;
			this.labelCurrentPoints.Location = new System.Drawing.Point(29, 205);
			this.labelCurrentPoints.MinimumSize = new System.Drawing.Size(153, 21);
			this.labelCurrentPoints.Name = "labelCurrentPoints";
			this.labelCurrentPoints.Size = new System.Drawing.Size(153, 21);
			this.labelCurrentPoints.TabIndex = 7;
			this.labelCurrentPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Maroon;
			this.label3.Location = new System.Drawing.Point(38, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 21);
			this.label3.TabIndex = 6;
			this.label3.Text = "Бали за постріл";
			// 
			// labelCurrentShot
			// 
			this.labelCurrentShot.AutoSize = true;
			this.labelCurrentShot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelCurrentShot.ForeColor = System.Drawing.Color.Maroon;
			this.labelCurrentShot.Location = new System.Drawing.Point(29, 139);
			this.labelCurrentShot.MinimumSize = new System.Drawing.Size(153, 21);
			this.labelCurrentShot.Name = "labelCurrentShot";
			this.labelCurrentShot.Size = new System.Drawing.Size(153, 21);
			this.labelCurrentShot.TabIndex = 5;
			this.labelCurrentShot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(48, 58);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(113, 23);
			this.buttonClear.TabIndex = 4;
			this.buttonClear.Text = "Нова мішень";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Maroon;
			this.label2.Location = new System.Drawing.Point(29, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 21);
			this.label2.TabIndex = 3;
			this.label2.Text = "Поточний постріл";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 462);
			this.Controls.Add(this.panelKeyboard);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Вразити мішень";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
			this.panelKeyboard.ResumeLayout(false);
			this.panelKeyboard.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShot;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelKeyboard;
        private System.Windows.Forms.Label labelCurrentShot;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSumPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCurrentPoints;
        private System.Windows.Forms.Label label3;
    }
}
