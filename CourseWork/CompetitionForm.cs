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
    public partial class CompetitionForm : Form
    {
        private List<Form> forms;

        public CompetitionForm()
        {
            InitializeComponent();
        }

        private void CompetitionForm_Resize(object sender, EventArgs e)
        {
            groupBoxCreateEditCompetition.Top = tabControlCompetition.Height / 2 - groupBoxCreateEditCompetition.Height / 2;
            groupBoxCreateEditCompetition.Left = tabControlCompetition.Width / 2 - groupBoxCreateEditCompetition.Width / 2;
        }

        public void Add_Forms_List(List<Form> _forms)
        {
            forms = _forms;
        }

        private void CompetitionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forms[0].Hide();
            forms[0].Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forms[1].Hide();
            forms[1].Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            forms[3].Hide();
            forms[3].Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
