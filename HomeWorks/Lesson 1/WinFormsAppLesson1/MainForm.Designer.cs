
namespace WinFormsAppLesson1
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
            this.labelMyName = new System.Windows.Forms.Label();
            this.textBoxMyName = new System.Windows.Forms.TextBox();
            this.buttonHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMyName
            // 
            this.labelMyName.AutoSize = true;
            this.labelMyName.Location = new System.Drawing.Point(35, 35);
            this.labelMyName.Name = "labelMyName";
            this.labelMyName.Size = new System.Drawing.Size(106, 15);
            this.labelMyName.TabIndex = 0;
            this.labelMyName.Text = "Вкажіть Ваше ім\'я";
            // 
            // textBoxMyName
            // 
            this.textBoxMyName.Location = new System.Drawing.Point(158, 32);
            this.textBoxMyName.Name = "textBoxMyName";
            this.textBoxMyName.Size = new System.Drawing.Size(236, 23);
            this.textBoxMyName.TabIndex = 1;
            // 
            // buttonHello
            // 
            this.buttonHello.Location = new System.Drawing.Point(111, 79);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(205, 23);
            this.buttonHello.TabIndex = 2;
            this.buttonHello.Text = "Привітатись";
            this.buttonHello.UseVisualStyleBackColor = true;
            this.buttonHello.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 132);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.textBoxMyName);
            this.Controls.Add(this.labelMyName);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашнє завдання(Лекція 1)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMyName;
        private System.Windows.Forms.TextBox textBoxMyName;
        private System.Windows.Forms.Button buttonHello;
    }
}

