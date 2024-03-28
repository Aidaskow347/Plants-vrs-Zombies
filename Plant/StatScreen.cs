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
    public partial class StatScreen : UserControl
    {

        public StatScreen()
        {
            InitializeComponent();

            plantsPlacedLabel.Text += " " + S.plantsPlaced;
            sunCollectedLabel.Text += " " + S.sunCollected;
            sunSpentLabel.Text += " " + S.sunSpent;
            zombiesKilledLabel.Text += " " + S.zombiesKilled;
            survivalTimeLabel.Text += " " + S.survivalTimer.Elapsed.ToString(@"mm\:ss") + " s";

        }

        private void statButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
