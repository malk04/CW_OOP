using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class InformationForm : Form
    {
        int time = 30;
        public InformationForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {

        }

        private void InformationForm_Resize(object sender, EventArgs e)
        {
            groupBoxInformation.Top = this.Height / 2 - groupBoxInformation.Height / 2;
            groupBoxInformation.Left = this.Width / 2 - groupBoxInformation.Width / 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                labelSeconds.Text = time.ToString();
            }
            else
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void InformationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
