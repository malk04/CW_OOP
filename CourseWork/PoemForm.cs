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
    public partial class PoemForm : Form
    {
        private List<Form> forms;

        public PoemForm()
        {
            InitializeComponent();
        }

        private void PoemForm_Resize(object sender, EventArgs e)
        {
            groupBoxCreatePoem.Width = tabControlPoem.Width / 2 - 10;
            groupBoxEditPoem.Width = tabControlPoem.Width / 2 - 10;
            groupBoxPrintPoem.Width = tabControlPoem.Width / 2 - 10;
            groupBoxEditPoem.Left = tabControlPoem.Width - groupBoxEditPoem.Width - 5;
            groupBoxPrintPoem.Left = tabControlPoem.Width - groupBoxPrintPoem.Width - 5;
        }

        public void Add_Forms_List(List<Form> _forms)
        {
            forms = _forms;
        }

        private void PoemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            forms[0].Hide();
            forms[0].Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forms[2].Hide();
            forms[2].Show();
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
