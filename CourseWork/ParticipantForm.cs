using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System.Text;

namespace CourseWork
{
    public partial class ParticipantForm : Form
    {
        private List<Form>? forms;
        private IEnumerable<Participant>? participants;
        private IEnumerable<Participant>? foundParticipants;
        private IEnumerable<Participant>? filterParticipants;
        private IEnumerable<Competition>? competitions;

        public ParticipantForm()
        {
            InitializeComponent();
        }

        private async void ParticipantForm_Load(object sender, EventArgs e)
        {
            await updateFromDataBase();
        }

        /// <summary>
        /// ���������� ������������ ����������� �� ���� ������
        /// </summary>
        /// <returns></returns>
        private async Task updateFromDataBase()
        {
            DataBaseContext db = new DataBaseContext();
            participants = await db.Participants.Include(p => p.Poems).AsNoTracking().ToListAsync();
            competitions = await db.Competitions.AsNoTracking().ToListAsync();
            textBoxFindBySurname.Text = "";
            updateCompetitionComboBox();
            updateYearComboBox();
            updateTableParticipants();
        }

        /// <summary>
        /// ���������� ����������� ������ � ����������
        /// </summary>
        private void updateCompetitionComboBox()
        {
            string chosen = string.IsNullOrEmpty(comboBoxCompitition.Text) ? "���" : comboBoxCompitition.Text;
            comboBoxCompitition.Items.Clear();
            comboBoxCompitition.Items.Add("���");
            foreach (var competition in competitions)
            {
                comboBoxCompitition.Items.Add("id: " + competition.CompetitionId.ToString() + ". " + competition.Name);
            }
            comboBoxCompitition.Text = chosen;
        }

        /// <summary>
        /// ���������� ����������� ������ � ������ �������� ����������
        /// </summary>
        private void updateYearComboBox()
        {
            string chosen = string.IsNullOrEmpty(comboBoxYear.Text) ? "�����" : comboBoxYear.Text;
            comboBoxYear.Items.Clear();
            comboBoxYear.Items.Add("�����");
            SortedSet<int> years = new SortedSet<int>();
            foreach (var participant in participants)
            {
                years.Add(participant.DateOfBirth.Year);
            }
            foreach (int year in years)
            {
                comboBoxYear.Items.Add(year.ToString());
            }
            comboBoxYear.Text = chosen;
        }

        /// <summary>
        /// ����� ���������� � ������
        /// </summary>
        /// <returns></returns>
        private void resetFilters()
        {
            foundParticipants?.ToList().Clear();
            foundParticipants = null;
            filterParticipants?.ToList().Clear();
            filterParticipants = null;
            textBoxFindBySurname.Text = "";
            comboBoxCompitition.Text = "���";
            comboBoxYear.Text = "�����";
            updateTableParticipants();
        }

        /// <summary>
        /// ���������� ������� ������������ � ��������� �����������
        /// </summary>
        private void updateTableParticipants()
        {
            if (filterParticipants != null)
            {
                filterParticipants.ToList().Clear();
            }

            string chosenCompetition = comboBoxCompitition.Text;
            string chosenYear = comboBoxYear.Text;
            List<Participant> participantsForTable = new List<Participant>();

            if (foundParticipants == null)
            {
                participantsForTable = participants.ToList();
            }
            else
            {
                participantsForTable = foundParticipants.ToList();
            }
            
            if (chosenCompetition != "���")
            {
                chosenCompetition = chosenCompetition.Remove(0, 4);
                string strID = chosenCompetition.Split().First();
                strID = strID.Remove(strID.Length - 1, 1);
                participantsForTable = participantsForTable.Where(x => x.Competitions.ToList().Exists(x => x.CompetitionId == Int32.Parse(strID))).ToList();
            }

            if (chosenYear != "�����")
            {
                participantsForTable = participantsForTable.Where((x => x.DateOfBirth.Year == Int32.Parse(chosenYear))).ToList();
            }


            dataGridViewParticipant.RowCount = 0;
            int i = 0;
            foreach (Participant participant in participantsForTable)
            {
                StringBuilder poemIds = new StringBuilder("");
                foreach (Poem poem in participant.Poems)
                {
                    poemIds.Append(poem.PoemId.ToString() + ", ");
                };
                if (poemIds.Length > 0) poemIds.Remove(poemIds.Length - 2, 2);

                DataGridViewRow row = new DataGridViewRow();
                dataGridViewParticipant.Rows.Add(row);
                dataGridViewParticipant.Rows[i].Cells[0].Value = participant.ParticipantId.ToString();
                dataGridViewParticipant.Rows[i].Cells[1].Value = participant.Surname;
                dataGridViewParticipant.Rows[i].Cells[2].Value = participant.Name;
                dataGridViewParticipant.Rows[i].Cells[3].Value = participant.SecondName;
                dataGridViewParticipant.Rows[i].Cells[4].Value = participant.DateOfBirth.ToString("dd/MM/yyyy");
                dataGridViewParticipant.Rows[i].Cells[5].Value = poemIds;
                i++;
            }

            if (chosenCompetition != "���" || chosenYear != "�����")
            {
                labelForFilters.Text = "������� ����������: " + participantsForTable.Count;
                filterParticipants = participantsForTable;
            }
            else
            {
                labelForFilters.Text = "";
                filterParticipants?.ToList().Clear();
                filterParticipants = null;
            }
        }

        private void ParticipantForm_Resize(object sender, EventArgs e)
        {
            groupBoxCreateEditParticipant.Top = CreateEditParticipant.Height / 2 - groupBoxCreateEditParticipant.Height / 2;
            groupBoxCreateEditParticipant.Left = CreateEditParticipant.Width / 2 - groupBoxCreateEditParticipant.Width / 2;
        }

        public void Add_Forms_List(List<Form> _forms)
        {
            forms = _forms;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forms[1].Hide();
            forms[1].Show();
        }

        private void ParticipantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
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

        /// <summary>
        /// �������� ������ �����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonCreateParticipant_Click(object sender, EventArgs e)
        {
            string _surname = textBoxSurname.Text;
            string _name = textBoxName.Text;
            string _secondName = textBoxSecondName.Text;
            DateTime _birhday = DateTime.Parse(dateTimePicker1.Text);

            if (!string.IsNullOrEmpty(_surname) && !string.IsNullOrEmpty(_name) && !string.IsNullOrEmpty(_secondName))
            {
                if (DateTime.Compare(_birhday, DateTime.Today) > 0)
                {
                    MessageBox.Show("���������� ��� �� ���������� ��������. ��������� ��������� ���� ��������.", "���������� ������� ������", MessageBoxButtons.OK);
                    return;
                }

                Participant participantNew = new Participant(_surname, _name, _secondName, _birhday);
                participantNew.AddToDataBase();
                await updateFromDataBase();

                textBoxSurname.Text = "";
                textBoxName.Text = "";
                textBoxSecondName.Text = "";
                dateTimePicker1.Text = DateTime.Now.ToString();
                MessageBox.Show("���������� ��������", "�������", MessageBoxButtons.OK);
            }
            else
            {

                MessageBox.Show("��������� ��� ���� � ���� '�������� �����������'", "������� ������ ����", MessageBoxButtons.OK);
                return;
            }
        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space || Char.IsDigit(e.KeyChar))
                e.KeyChar = '\0';
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space || Char.IsDigit(e.KeyChar))
                e.KeyChar = '\0';
        }

        private void textBoxSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space || Char.IsDigit(e.KeyChar))
                e.KeyChar = '\0';
        }

        private void textBoxSurnameEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space || Char.IsDigit(e.KeyChar))
                e.KeyChar = '\0';
        }

        private void textBoxNameEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space || Char.IsDigit(e.KeyChar))
                e.KeyChar = '\0';
        }

        private void textBoxSecondNameEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space || Char.IsDigit(e.KeyChar))
                e.KeyChar = '\0';
        }

        /// <summary>
        /// �������������� ����������� �� id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonEditParticipant_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownIDEdit.Value;
            Participant participant;
            try
            {
                participant = Participant.FindById(_id);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show($"����������� � id: {_id} �� ����������", "������ �� ������", MessageBoxButtons.OK);
                return;
            }

            string _surname = textBoxSurnameEdit.Text;
            string _name = textBoxNameEdit.Text;
            string _secondName = textBoxSecondNameEdit.Text;
            DateTime _birhday = DateTime.Parse(dateTimePicker2.Text);


            if (DateTime.Compare(_birhday, DateTime.Today) > 0)
            {
                MessageBox.Show("������� ��� �� ����������� ����. ��������� ��������� ���� ��������.", "���������� ������������� ������", MessageBoxButtons.OK);
                return;
            }
            else if (DateTime.Compare(_birhday, DateTime.Today) == 0)
            {
                MessageBox.Show("������� ����������� ����. �� �������, ��� ���� �������� ������� �����?", "��������������", MessageBoxButtons.OK);
            }

            using (DataBaseContext db = new DataBaseContext())
            {
                if (!string.IsNullOrEmpty(_surname)) participant.Surname = _surname;
                if (!string.IsNullOrEmpty(_name)) participant.Name = _name;
                if (!string.IsNullOrEmpty(_secondName)) participant.SecondName = _secondName;
                participant.DateOfBirth = _birhday;
                db.Entry(participant).State = EntityState.Modified;
                db.SaveChanges();
            }
            await updateFromDataBase();

            textBoxSurnameEdit.Text = "";
            textBoxNameEdit.Text = "";
            textBoxSecondNameEdit.Text = "";
            dateTimePicker2.Text = DateTime.Now.ToString();
            MessageBox.Show("���������� ��������������", "�������", MessageBoxButtons.OK);
        }

        /// <summary>
        /// �������� ����������� �� id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonDeleteParticipant_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownIDDel.Value;
            Participant participant;
            try
            {
                participant = Participant.FindById(_id);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show($"����������� � id: {_id} �� ����������", "������ �� ������", MessageBoxButtons.OK);
                return;
            }

            participant.DeleteFromDataBase();
            MessageBox.Show("���������� ������", "�������", MessageBoxButtons.OK);
            await updateFromDataBase();
        }

        /// <summary>
        /// ��������� ������� ������ �����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownIDEdit.Value;
            Participant participant;
            try
            {
                participant = Participant.FindById(_id);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show($"����������� � id: {_id} �� ����������", "������ �� ������", MessageBoxButtons.OK);
                return;
            }

            textBoxSurnameEdit.Text = participant.Surname;
            textBoxNameEdit.Text = participant.Name;
            textBoxSecondNameEdit.Text = participant.SecondName;
            dateTimePicker2.Text = participant.DateOfBirth.ToString();
        }

        private void buttonFilterParticipant_Click(object sender, EventArgs e)
        {
            updateTableParticipants();
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            await updateFromDataBase();
            MessageBox.Show("��������� ��������� ������", "", MessageBoxButtons.OK);
        }

        private void dataGridViewParticipant_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridViewParticipant.ClearSelection();
        }

        /// <summary>
        /// ����� ����������� �� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (foundParticipants != null)
            {
                foundParticipants.ToList().Clear();
            }

            string strFind = textBoxFindBySurname.Text.ToLower();
            List<Participant> participantsForTable = new List<Participant>();

            if (filterParticipants == null)
            {
                participantsForTable = participants.ToList();
            }
            else
            {
                participantsForTable = filterParticipants.ToList();
            }

            if (!string.IsNullOrEmpty(strFind))
            {
                participantsForTable = participantsForTable.Where(x => x.Surname.ToLower().Contains(strFind)).ToList();
                foundParticipants = participantsForTable;
            }
            else
            {
                foundParticipants = null;
            }

            dataGridViewParticipant.RowCount = 0;
            int i = 0;
            foreach (Participant participant in participantsForTable)
            {
                StringBuilder poemIds = new StringBuilder("");
                foreach (Poem poem in participant.Poems)
                {
                    poemIds.Append(poem.PoemId.ToString() + ", ");
                };
                if (poemIds.Length > 0) poemIds.Remove(poemIds.Length - 2, 2);

                DataGridViewRow row = new DataGridViewRow();
                dataGridViewParticipant.Rows.Add(row);
                dataGridViewParticipant.Rows[i].Cells[0].Value = participant.ParticipantId.ToString();
                dataGridViewParticipant.Rows[i].Cells[1].Value = participant.Surname;
                dataGridViewParticipant.Rows[i].Cells[2].Value = participant.Name;
                dataGridViewParticipant.Rows[i].Cells[3].Value = participant.SecondName;
                dataGridViewParticipant.Rows[i].Cells[4].Value = participant.DateOfBirth.ToString("dd/MM/yyyy");
                dataGridViewParticipant.Rows[i].Cells[5].Value = poemIds;
                i++;
            }
            labelForFilters.Text = "������� ����������: " + participantsForTable.Count;
        }

        /// <summary>
        /// �������� ����������/�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetFilters();
        }
    }
}