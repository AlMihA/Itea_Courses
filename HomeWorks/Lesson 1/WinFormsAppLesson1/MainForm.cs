using System;
using System.Windows.Forms;

namespace WinFormsAppLesson1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
	        switch (textBoxMyName.Text)
	        {
		        case "":
			        MessageBox.Show("Я не розмовляю з незнайомцем!", "Помилка");
			        return;
		        default:
			        MessageBox.Show("Hello, " + textBoxMyName.Text,"Вітання");
			        break;
	        }
        }
    }
}
