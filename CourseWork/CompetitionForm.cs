using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class CompetitionForm : Form
    {
        private List<Form>? forms;
        private IEnumerable<Competition>? competitions;

        public CompetitionForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text, String caption, uint type);

        private async void CompetitionForm_Load(object sender, EventArgs e)
        {
            await updateFromDataBase();
        }

        /// <summary>
        /// Обновление всех генерируемых компонентов из базы данных
        /// </summary>
        /// <returns></returns>
        private async Task updateFromDataBase()
        {
            DataBaseContext db = new DataBaseContext();
            competitions = await db.Competitions.Include(c => c.Participants).AsNoTracking().ToListAsync();
            updateYearComboBox();
            updateTableCompetitions();
        }

        /// <summary>
        /// Обновление выпадающего списка с выбором года проведения конкурсов
        /// </summary>
        private void updateYearComboBox()
        {
            string chosen = string.IsNullOrEmpty(comboBoxYearCompetition.Text) ? "Любой" : comboBoxYearCompetition.Text;
            comboBoxYearCompetition.Items.Clear();
            comboBoxYearCompetition.Items.Add("Любой");
            SortedSet<int> years = new SortedSet<int>();
            foreach (var competition in competitions)
            {
                years.Add(competition.Date.Year);
            }
            foreach (int year in years)
            {
                comboBoxYearCompetition.Items.Add(year.ToString());
            }
            comboBoxYearCompetition.Text = chosen;
        }

        /// <summary>
        /// Обновление таблицы конкурсов с выбранной фильтрацией
        /// </summary>
        private void updateTableCompetitions()
        {
            string chosenYear = comboBoxYearCompetition.Text;
            List<Competition> competitionsForTable = new List<Competition>();

            competitionsForTable = competitions.ToList();

            if (chosenYear != "Любой")
            {
                competitionsForTable = competitionsForTable.Where(x => x.Date.Year == Int32.Parse(chosenYear)).ToList();
            }


            dataGridViewCompetition.RowCount = 0;
            int i = 0;
            foreach (Competition competition in competitionsForTable)
            {
                StringBuilder participantIds = new StringBuilder("");
                foreach (Participant participant in competition.Participants)
                {
                    participantIds.Append(participant.ParticipantId.ToString() + ", ");
                };
                if (participantIds.Length > 0) participantIds.Remove(participantIds.Length - 2, 2);

                DataGridViewRow row = new DataGridViewRow();
                dataGridViewCompetition.Rows.Add(row);
                dataGridViewCompetition.Rows[i].Cells[0].Value = competition.CompetitionId.ToString();
                dataGridViewCompetition.Rows[i].Cells[1].Value = competition.Name;
                dataGridViewCompetition.Rows[i].Cells[2].Value = competition.Date.ToString();
                dataGridViewCompetition.Rows[i].Cells[3].Value = competition.MinAge.ToString();
                dataGridViewCompetition.Rows[i].Cells[4].Value = participantIds;
                dataGridViewCompetition.Rows[i].Cells[5].Value = competition.WinnerId.ToString();
                i++;
            }
        }

        private void CompetitionForm_Resize(object sender, EventArgs e)
        {
            groupBoxCreateEditCompetition.Top = CreateEditCompetition.Height / 2 - groupBoxCreateEditCompetition.Height / 2;
            groupBoxCreateEditCompetition.Left = CreateEditCompetition.Width / 2 - groupBoxCreateEditCompetition.Width / 2;
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

        /// <summary>
        /// Создание нового конкурса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonCreateCompetition_Click(object sender, EventArgs e)
        {
            CultureInfo provider = new CultureInfo("en-US");

            string _name = textBoxNameCompetition.Text;
            DateTime _date = DateTime.ParseExact(dateTimePicker1.Text, "dd/MM/yyyy HH:mm", provider);
            int minAge = (int)numericUpDownMinAge.Value;

            if (!string.IsNullOrEmpty(_name))
            {
                Competition competitionNew = new Competition(_name, _date, minAge);
                competitionNew.AddToDataBase();
                await updateFromDataBase();

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

        /// <summary>
        /// Редактирование конкурса по id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonEditCompetition_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownEditID.Value;
            Competition competition;
            try
            {
                competition = Competition.FindById(_id);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Конкурса с id: {_id} не существует", "Объект не найден", 0);
                return;
            }

            string _name = textBoxEditNameCompetition.Text;
            CultureInfo provider = new CultureInfo("en-US");
            DateTime _date = DateTime.ParseExact(dateTimePicker2.Text, "dd/MM/yyyy HH:mm", provider);

            if (!string.IsNullOrEmpty(_name))
            {
                if ((competition.Date - _date).TotalDays >= 1)
                {
                    MessageBox(0, "При переносе конкурса на более раннюю дату возраст уже добавленных участников может не соответствовать минимальному возрасту.", "Предупреждение", 0);
                }

                using (DataBaseContext db = new DataBaseContext())
                {
                    competition.Name = _name;
                    competition.Date = _date;
                    db.Entry(competition).State = EntityState.Modified;
                    db.SaveChanges();
                }
                await updateFromDataBase();

                textBoxEditNameCompetition.Text = "";
                dateTimePicker2.Text = DateTime.Now.ToString();
                MessageBox(0, "Конкурс отредактирован", "Успешно", 0);
            }
            else
            {
                MessageBox(0, "Заполните поле 'Название'", "Найдено пустое поле", 0);
                return;
            }
        }

        /// <summary>
        /// Удаление конкурса по id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonDelCompetition_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownDelIDCompetition.Value;
            Competition competition;
            try
            {
                competition = Competition.FindById(_id);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Конкурса с id: {_id} не существует", "Объект не найден", 0);
                return;
            }

            competition.DeleteFromDataBase();
            await updateFromDataBase();
            MessageBox(0, "Конкурс удален", "Успешно", 0);
        }

        /// <summary>
        /// Добавление участника в конкурс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonAddParticipant_Click(object sender, EventArgs e)
        {
            int _idComp = (int)numericUpDownAddIDCompetitionParticipant.Value;
            Competition competition;
            try
            {
                competition = Competition.FindById(_idComp);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Конкурса с id: {_idComp} не существует", "Объект не найден", 0);
                return;
            }

            int _idPar = (int)numericUpDownAddIDParticipant.Value;
            Participant participant;
            try
            {
                participant = Participant.FindById(_idPar);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Конкурсанта с id: {_idPar} не существует", "Объект не найден", 0);
                return;
            }

            if (competition.Participants.ToList().Exists(x => x.ParticipantId == participant.ParticipantId))
            {
                MessageBox(0, $"Конкурсант с id: {_idPar} уже добавлен в конкурс с id: {_idComp}", "Ошибка", 0);
                return;
            }

            decimal DaysInAYear = 365.242M;
            if ((decimal)(competition.Date - participant.DateOfBirth).TotalDays / DaysInAYear < competition.MinAge)
            {
                MessageBox(0, $"Возраст конкурсанта с id: {_idPar} меньше допустимого. Минимальный возраст для конкурса с id: {_idComp} = {competition.MinAge}", "Ошибка", 0);
                return;
            }

            using (DataBaseContext db = new DataBaseContext())
            {
                competition = db.Competitions.Include(c => c.Participants).First(c => c.CompetitionId == _idComp);
                competition.Participants.Add(participant);
                db.SaveChanges();
            }
            await updateFromDataBase();
            MessageBox(0, "Участник добавлен в конкурс", "Успешно", 0);
        }

        /// <summary>
        /// Удаление участника из конкурса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonDelParticipant_Click(object sender, EventArgs e)
        {
            int _idComp = (int)numericUpDownAddIDCompetitionParticipant.Value;
            Competition competition;
            try
            {
                competition = Competition.FindById(_idComp);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Конкурса с id: {_idComp} не существует", "Объект не найден", 0);
                return;
            }

            int _idPar = (int)numericUpDownAddIDParticipant.Value;
            Participant participant;
            try
            {
                participant = Participant.FindById(_idPar);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Конкурсанта с id: {_idPar} не существует", "Объект не найден", 0);
                return;
            }

            if (!competition.Participants.ToList().Exists(x => x.ParticipantId == participant.ParticipantId))
            {
                MessageBox(0, $"Конкурсанта с id: {_idPar} нет в списке участников конкурса с id: {_idComp}", "Ошибка", 0);
                return;
            }

            using (DataBaseContext db = new DataBaseContext())
            {
                competition = db.Competitions.Include(c => c.Participants).First(c => c.CompetitionId == _idComp);
                participant = db.Participants.First(p => p.ParticipantId == _idPar);
                competition.Participants.Remove(participant);
                if (competition.WinnerId == participant.ParticipantId)
                {
                    competition.WinnerId = null;
                }
                db.SaveChanges();
            }

            await updateFromDataBase();
            MessageBox(0, "Участник удален из конкурса", "Успешно", 0);
        }

        /// <summary>
        /// Добавление/редактирование победителя конкурса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonAddWinner_Click(object sender, EventArgs e)
        {
            int _idComp = (int)numericUpDownAddIDCompetitionWinner.Value;
            Competition competition;
            try
            {
                competition = Competition.FindById(_idComp);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Конкурса с id: {_idComp} не существует", "Объект не найден", 0);
                return;
            }

            int _idPar = (int)numericUpDownAddIDWinner.Value;
            Participant participant;
            try
            {
                participant = Participant.FindById(_idPar);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Конкурсанта с id: {_idPar} не существует", "Объект не найден", 0);
                return;
            }

            if (!competition.Participants.ToList().Exists(x => x.ParticipantId == participant.ParticipantId))
            {
                MessageBox(0, $"Конкурсанта с id: {_idPar} нет в списке участников конкурса с id: {_idComp}", "Ошибка", 0);
                return;
            }

            using (DataBaseContext db = new DataBaseContext())
            {
                competition = db.Competitions.Include(c => c.Participants).First(c => c.CompetitionId == _idComp);
                participant = db.Participants.First(p => p.ParticipantId == _idPar);
                competition.WinnerId = participant.ParticipantId;
                db.SaveChanges();
            }

            await updateFromDataBase();
            MessageBox(0, "Победитель конкурса добавлен/изменен", "Успешно", 0);
        }

        /// <summary>
        /// Загрузка текущих данных конкурса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownEditID.Value;
            Competition competition;
            try
            {
                competition = Competition.FindById(_id);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Конкурса с id: {_id} не существует", "Объект не найден", 0);
                return;
            }
           
            textBoxEditNameCompetition.Text = competition.Name;
            dateTimePicker2.Text = competition.Date.ToString();
        }

        private void buttonFilterCompetition_Click(object sender, EventArgs e)
        {
            updateTableCompetitions();
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            await updateFromDataBase();
            MessageBox(0, "Загружены последние данные", "", 0);
        }

        private void dataGridViewCompetition_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridViewCompetition.ClearSelection();
        }

        /// <summary>
        /// Поиск конкурса по названию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFind_Click(object sender, EventArgs e)
        {
            string strFind = textBoxFindByName.Text.ToLower();
            List<Competition> competitionsForTable = new List<Competition>();

            if (!string.IsNullOrEmpty(strFind))
            {
                competitionsForTable = competitions.Where(x => x.Name.ToLower().Contains(strFind)).ToList();
            }
            else
            {
                competitionsForTable = competitions.ToList();
            }


            dataGridViewCompetition.RowCount = 0;
            int i = 0;
            foreach (Competition competition in competitionsForTable)
            {
                StringBuilder participantIds = new StringBuilder("");
                foreach (Participant participant in competition.Participants)
                {
                    participantIds.Append(participant.ParticipantId.ToString() + ", ");
                };
                if (participantIds.Length > 0) participantIds.Remove(participantIds.Length - 2, 2);

                DataGridViewRow row = new DataGridViewRow();
                dataGridViewCompetition.Rows.Add(row);
                dataGridViewCompetition.Rows[i].Cells[0].Value = competition.CompetitionId.ToString();
                dataGridViewCompetition.Rows[i].Cells[1].Value = competition.Name;
                dataGridViewCompetition.Rows[i].Cells[2].Value = competition.Date.ToString();
                dataGridViewCompetition.Rows[i].Cells[3].Value = competition.MinAge.ToString();
                dataGridViewCompetition.Rows[i].Cells[4].Value = participantIds;
                dataGridViewCompetition.Rows[i].Cells[5].Value = competition.WinnerId.ToString();
                i++;
            }
        }
    }
}
