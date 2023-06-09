﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class NavigationForm : Form
    {
        private List<Form>? forms;

        public NavigationForm()
        {
            InitializeComponent();
        }

        public void Add_Forms_List(List<Form> _forms)
        {
            forms = _forms;
        }

        private void NavigationForm_Resize(object sender, EventArgs e)
        {
            groupBoxNavigation.Top = Height / 2 - groupBoxNavigation.Height / 2 - 5;
            groupBoxNavigation.Left = Width / 2 - groupBoxNavigation.Width / 2 - 5;
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
            forms[2].Hide();
            forms[2].Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            forms[3].Hide();
            forms[3].Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void NavigationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите выйти?", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Environment.Exit(0);
                    return;
                case DialogResult.No:
                    e.Cancel = true;
                    return;
            }
        }
    }
}
