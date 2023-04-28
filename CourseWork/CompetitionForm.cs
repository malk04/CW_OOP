using CourseWork.Entities;
using System;
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
    public partial class CompetitionForm : Form
    {
        private List<Form> forms;

        public CompetitionForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text, String caption, uint type);

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

        private void buttonCreateCompetition_Click(object sender, EventArgs e)
        {
            string _name = textBoxNameCompetition.Text;
            DateTime _date = DateTime.Parse(dateTimePicker1.Text);
            int minAge = (int)numericUpDownMinAge.Value;

            if (!string.IsNullOrEmpty(_name))
            {
                Competition competitionNew = new Competition(_name, _date, minAge, null);
                competitionNew.AddToDataBase();
                //updateTable();

                textBoxNameCompetition.Text = "";
                dateTimePicker1.Text = DateTime.Now.ToString();
                numericUpDownMinAge.Value = 0;
                MessageBox(0, "Конкурс добавлен", "Успешно", 0);
            }
            else
            {
                MessageBox(0, "Заполните поле 'Название'", "Найдено пустое поле", 0);
                return;
            }
        }

        private void buttonEditCompetition_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownEditID.Value;
            Competition? competition = Competition.FindById(_id);
            if (competition == null)
            {
                MessageBox(0, $"Конкурса с id: {_id} не существует", "Объект не найден", 0);
                return;
            }

            string _name = textBoxEditNameCompetition.Text;
            DateTime _date = DateTime.Parse(dateTimePicker2.Text);

            if (!string.IsNullOrEmpty(_name))
            {
                if ((DateTime.Now - _date).TotalHours < 1)
                {
                    MessageBox(0, "Выбрана сегодняшняя дата. Вы уверены, что дата и время проведения введены верно?", "Предупреждение", 0);
                }

                using (DataBaseContext db = new DataBaseContext())
                {
                    competition.Name = _name;
                    competition.Date = _date;
                    db.Competitions.Update(competition);
                    db.SaveChanges();
                }
                //updateTable();

                textBoxEditNameCompetition.Text = "";
                dateTimePicker2.Text = DateTime.Now.ToString();
                MessageBox(0, "Название стихотворения отредактировано", "Успешно", 0);
            }
            else
            {
                MessageBox(0, "Заполните поле 'Название'", "Найдено пустое поле", 0);
                return;
            }
        }

        private void buttonDelCompetition_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownDelIDCompetition.Value;
            Competition? competition = Competition.FindById(_id);
            if (competition == null)
            {
                MessageBox(0, $"Конкурса с id: {_id} не существует", "Объект не найден", 0);
                return;
            }

            competition.DeleteFromDataBase();
            MessageBox(0, "Конкурс удален", "Успешно", 0);
        }

        private void buttonAddParticipant_Click(object sender, EventArgs e)
        {
            int _idComp = (int)numericUpDownAddIDCompetitionParticipant.Value;
            Competition? competition = Competition.FindById(_idComp);
            if (competition == null)
            {
                MessageBox(0, $"Конкурса с id: {_idComp} не существует", "Объект не найден", 0);
                return;
            }

            int _idPar = (int)numericUpDownAddIDCompetitionParticipant.Value;
            Participant? participant = Participant.FindById(_idPar);
            if (participant == null)
            {
                MessageBox(0, $"Конкурсанта с id: {_idPar} не существует", "Объект не найден", 0);
                return;
            }

            if (competition.Participants.Contains(participant))
            {
                MessageBox(0, $"Конкурсант с id: {_idPar} уже добавлен в конкурс с id: {_idComp}", "Ошибка", 0);
                return;
            }

            using (DataBaseContext db = new DataBaseContext())
            {
                competition.Participants.Add(participant);
                db.Competitions.Update(competition);
                db.SaveChanges();
            }

            MessageBox(0, "Участник добавлен в конкурс", "Успешно", 0);
        }

        private void buttonDelParticipant_Click(object sender, EventArgs e)
        {
            int _idComp = (int)numericUpDownDelIDCompetitionParticipant.Value;
            Competition? competition = Competition.FindById(_idComp);
            if (competition == null)
            {
                MessageBox(0, $"Конкурса с id: {_idComp} не существует", "Объект не найден", 0);
                return;
            }

            int _idPar = (int)numericUpDownDelIDParticipant.Value;
            Participant? participant = Participant.FindById(_idPar);
            if (participant == null)
            {
                MessageBox(0, $"Конкурсанта с id: {_idPar} не существует", "Объект не найден", 0);
                return;
            }

            if (!competition.Participants.Contains(participant))
            {
                MessageBox(0, $"Конкурсанта с id: {_idPar} нет в списке участников конкурса с id: {_idComp}", "Ошибка", 0);
                return;
            }

            using (DataBaseContext db = new DataBaseContext())
            {
                competition.Participants.Remove(participant);
                db.Competitions.Update(competition);
                db.SaveChanges();
            }

            MessageBox(0, "Участник удален из конкурса", "Успешно", 0);
        }

        private void buttonAddWinner_Click(object sender, EventArgs e)
        {
            int _idComp = (int)numericUpDownDelIDCompetitionParticipant.Value;
            Competition? competition = Competition.FindById(_idComp);
            if (competition == null)
            {
                MessageBox(0, $"Конкурса с id: {_idComp} не существует", "Объект не найден", 0);
                return;
            }

            int _idPar = (int)numericUpDownDelIDParticipant.Value;
            Participant? participant = Participant.FindById(_idPar);
            if (participant == null)
            {
                MessageBox(0, $"Конкурсанта с id: {_idPar} не существует", "Объект не найден", 0);
                return;
            }

            if (!competition.Participants.Contains(participant))
            {
                MessageBox(0, $"Конкурсанта с id: {_idPar} нет в списке участников конкурса с id: {_idComp}", "Ошибка", 0);
                return;
            }

            using (DataBaseContext db = new DataBaseContext())
            {
                competition.WinnerId = participant.ParticipantId;
                db.Competitions.Update(competition);
                db.SaveChanges();
            }

            MessageBox(0, "Победитель конкурса добавлен/изменен", "Успешно", 0);
        }
    }
}
