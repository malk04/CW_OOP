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
        public InformationForm()
        {
            InitializeComponent();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {

        }

        private void InformationForm_Resize(object sender, EventArgs e)
        {
            groupBoxInformation.Top = this.Height / 2 - groupBoxInformation.Height / 2;
            groupBoxInformation.Left = this.Width / 2 - groupBoxInformation.Width / 2;
        }
    }
}
