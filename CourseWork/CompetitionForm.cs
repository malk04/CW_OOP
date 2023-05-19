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
        private IEnumerable<Competition>? foundCompetitions;
        private IEnumerable<Competition>? filterCompetitions;

        public CompetitionForm()
        {
            InitializeComponent();
        }

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
            textBoxFindByName.Text = "";
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
        /// Сброс фильтрации и поиска
        /// </summary>
        /// <returns></returns>
        private void resetFilters()
        {
            foundCompetitions?.ToList().Clear();
            foundCompetitions = null;
            filterCompetitions?.ToList().Clear();
            filterCompetitions = null;
            textBoxFindByName.Text = "";
            comboBoxYearCompetition.Text = "Любой";
            updateTableCompetitions();
        }

        /// <summary>
        /// Обновление таблицы конкурсов с выбранной фильтрацией
        /// </summary>
        private void updateTableCompetitions()
        {
            if (filterCompetitions != null)
            {
                filterCompetitions.ToList().Clear();
            }

            string chosenYear = comboBoxYearCompetition.Text;
            List<Competition> competitionsForTable = new List<Competition>();

            if (foundCompetitions == null)
            {
                competitionsForTable = competitions.ToList();
            }
            else
            {
                competitionsForTable = foundCompetitions.ToList();
            }

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

            if (chosenYear != "Любой")
            {
                labelForFilters.Text = "Найдено совпадений: " + competitionsForTable.Count;
                filterCompetitions = competitionsForTable;
            }
            else
            {
                labelForFilters.Text = "";
                filterCompetitions?.ToList().Clear();
                filterCompetitions = null;
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
                MessageBox.Show("Конкурс добавлен", "Успешно", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Заполните поле 'Название'", "Найдено пустое поле", MessageBoxButtons.OK);
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
                MessageBox.Show($"Конкурса с id: {_id} не существует", "Объект не найден", MessageBoxButtons.OK);
                return;
            }

            string _name = textBoxEditNameCompetition.Text;
            CultureInfo provider = new CultureInfo("en-US");
            DateTime _date = DateTime.ParseExact(dateTimePicker2.Text, "dd/MM/yyyy HH:mm", provider);

            if (!string.IsNullOrEmpty(_name))
            {
                if ((competition.Date - _date).TotalDays >= 1)
                {
                    MessageBox.Show("При переносе конкурса на более раннюю дату возраст уже добавленных участников может не соответствовать минимальному возрасту.", "Предупреждение", MessageBoxButtons.OK);
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
                MessageBox.Show("Конкурс отредактирован", "Успешно", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Заполните поле 'Название'", "Найдено пустое поле", MessageBoxButtons.OK);
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
                MessageBox.Show($"Конкурса с id: {_id} не существует", "Объект не найден", MessageBoxButtons.OK);
                return;
            }

            competition.DeleteFromDataBase();
            await updateFromDataBase();
            MessageBox.Show("Конкурс удален", "Успешно", MessageBoxButtons.OK);
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
                MessageBox.Show($"Конкурса с id: {_idComp} не существует", "Объект не найден", MessageBoxButtons.OK);
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
                MessageBox.Show($"Конкурсанта с id: {_idPar} не существует", "Объект не найден", MessageBoxButtons.OK);
                return;
            }

            if (competition.Participants.ToList().Exists(x => x.ParticipantId == participant.ParticipantId))
            {
                MessageBox.Show($"Конкурсант с id: {_idPar} уже добавлен в конкурс с id: {_idComp}", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            decimal DaysInAYear = 365.242M;
            if ((decimal)(competition.Date - participant.DateOfBirth).TotalDays / DaysInAYear < competition.MinAge)
            {
                MessageBox.Show($"Возраст конкурсанта с id: {_idPar} меньше допустимого. Минимальный возраст для конкурса с id: {_idComp} = {competition.MinAge}", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            using (DataBaseContext db = new DataBaseContext())
            {
                competition = db.Competitions.Include(c => c.Participants).First(c => c.CompetitionId == _idComp);
                competition.Participants.Add(participant);
                db.SaveChanges();
            }
            await updateFromDataBase();
            MessageBox.Show("Участник добавлен в конкурс", "Успешно", MessageBoxButtons.OK);
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
                MessageBox.Show($"Конкурса с id: {_idComp} не существует", "Объект не найден", MessageBoxButtons.OK);
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
                MessageBox.Show($"Конкурсанта с id: {_idPar} не существует", "Объект не найден", MessageBoxButtons.OK);
                return;
            }

            if (!competition.Participants.ToList().Exists(x => x.ParticipantId == participant.ParticipantId))
            {
                MessageBox.Show($"Конкурсанта с id: {_idPar} нет в списке участников конкурса с id: {_idComp}", "Ошибка", MessageBoxButtons.OK);
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
            MessageBox.Show("Участник удален из конкурса", "Успешно", MessageBoxButtons.OK);
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
                MessageBox.Show($"Конкурса с id: {_idComp} не существует", "Объект не найден", MessageBoxButtons.OK);
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
                MessageBox.Show($"Конкурсанта с id: {_idPar} не существует", "Объект не найден", MessageBoxButtons.OK);
                return;
            }

            if (!competition.Participants.ToList().Exists(x => x.ParticipantId == participant.ParticipantId))
            {
                MessageBox.Show($"Конкурсанта с id: {_idPar} нет в списке участников конкурса с id: {_idComp}", "Ошибка", MessageBoxButtons.OK);
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
            MessageBox.Show("Победитель конкурса добавлен/изменен", "Успешно", MessageBoxButtons.OK);
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
                MessageBox.Show($"Конкурса с id: {_id} не существует", "Объект не найден", MessageBoxButtons.OK);
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
            MessageBox.Show("Загружены последние данные", "", MessageBoxButtons.OK);
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
            if (foundCompetitions != null)
            {
                foundCompetitions.ToList().Clear();
            }

            string strFind = textBoxFindByName.Text.ToLower();
            List<Competition> competitionsForTable = new List<Competition>();

            if (filterCompetitions == null)
            {
                competitionsForTable = competitions.ToList();
            }
            else
            {
                competitionsForTable = filterCompetitions.ToList();
            }

            if (!string.IsNullOrEmpty(strFind))
            {
                competitionsForTable = competitionsForTable.Where(x => x.Name.ToLower().Contains(strFind)).ToList();
                foundCompetitions = competitionsForTable;
            }
            else
            {
                foundCompetitions = null;
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
            labelForFilters.Text = "Найдено совпадений: " + competitionsForTable.Count;
        }

        /// <summary>
        /// Сбросить фильтрацию/поиск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetFilters();
        }
    }
}
