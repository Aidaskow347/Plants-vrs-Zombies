using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plant
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new S());
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            if (S.drawImage == false)
            {
                S.drawImage = true;
                drawButton.Text = "Draw Images On";
                drawButton.BackColor = Color.LawnGreen;
            }
            else
            {
                S.drawImage = false;
                drawButton.Text = "Draw Images Off";
                drawButton.BackColor = Color.DarkSalmon;
            }
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new StatScreen());
        }
    }
}
