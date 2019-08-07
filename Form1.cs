using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracePoint_DemoApp
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void BtnGetRandom_Click(object sender, EventArgs e)
        {
            List<Person> lotteryEntrants = new List<Person>();

            int maxEntrants = 10;

            for(int i = 0; i < maxEntrants; i++)
            {
                lotteryEntrants.Add(Person.GetRandom());
            }
            int winnerElementIndex = Global.RandomGenerator.Next(maxEntrants);
            Person winner = lotteryEntrants.ElementAt(winnerElementIndex);

            lblWinner.Text = winner.Name;
        }
    }
}
