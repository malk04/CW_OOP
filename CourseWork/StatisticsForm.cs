using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;
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
    public partial class StatisticsForm : Form
    {
        private List<Form>? forms;
        private IEnumerable<Poem>? poems;
        private IEnumerable<Competition>? competitions;

        public StatisticsForm()
        {
            InitializeComponent();
        }

        private async void StatisticsForm_Load(object sender, EventArgs e)
        {
            await updateFromDataBase();
        }

        private async Task updateFromDataBase()
        {
            DataBaseContext db = new DataBaseContext();
            competitions = await db.Competitions.Include(c => c.Participants).AsNoTracking().ToListAsync();
            poems = await db.Poems.AsNoTracking().ToListAsync();
            updateYearComboBox();
        }

        private void updateYearComboBox()
        {
            string chosen = string.IsNullOrEmpty(comboBoxYear.Text) ? "Нет" : comboBoxYear.Text;
            comboBoxYear.Items.Clear();
            comboBoxYear.Items.Add("Нет");
            SortedSet<int> years = new SortedSet<int>();
            foreach (var competition in competitions)
            {
                years.Add(competition.Date.Year);
            }
            foreach (int year in years)
            {
                comboBoxYear.Items.Add(year.ToString());
            }
            comboBoxYear.Text = chosen;
        }

        private void updateResults()
        {
            string chosenYear = comboBoxYear.Text;
            List<Competition> competitionsByYear = new List<Competition>();
            HashSet<Participant> participantsByYear = new HashSet<Participant>();
            List<Poem> poemsByYear = new List<Poem>();
            int averageAge = -1;

            if (chosenYear != "Нет")
            {
                competitionsByYear.AddRange(competitions.Where(competition => competition.Date.Year == Int32.Parse(chosenYear)));

                foreach (Competition competition in competitionsByYear)
                {
                    foreach (Participant participant in competition.Participants)
                    {
                        participantsByYear.Add(participant);
                    }
                }

                poemsByYear.AddRange(poems.Where(poem => poem.Year.Year == Int32.Parse(chosenYear)));

                if (participantsByYear.Count > 0)
                {
                    int sum = 0;
                    foreach (Participant p in participantsByYear)
                    {
                        sum += Int32.Parse(chosenYear) - p.DateOfBirth.Year;
                    }
                    averageAge = sum / participantsByYear.Count;
                }

                textBoxCountCompetitions.Text = competitionsByYear.Count.ToString();
                textBoxCountParticipants.Text = participantsByYear.Count.ToString();
                textBoxCountPoems.Text = poemsByYear.Count.ToString();
                textBoxAverageAge.Text = averageAge != -1? averageAge.ToString() : "-";
            }
            else
            {
                textBoxCountCompetitions.Text = "";
                textBoxCountParticipants.Text = "";
                textBoxCountPoems.Text = "";
                textBoxAverageAge.Text = "";
            }
        }

        public void Add_Forms_List(List<Form> _forms)
        {
            forms = _forms;
        }

        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
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
            forms[2].Hide();
            forms[2].Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonDeleteParticipant_Click(object sender, EventArgs e)
        {
            updateResults();
        }

        private void StatisticsForm_Resize(object sender, EventArgs e)
        {
            groupBoxFlex.Top = groupBoxStatistics.Height / 2 - groupBoxFlex.Height / 2;
            groupBoxFlex.Left = groupBoxStatistics.Width / 2 - groupBoxFlex.Width / 2;
        }
    }
}
