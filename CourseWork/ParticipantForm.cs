using CourseWork.Entities;
using System.Runtime.InteropServices;

namespace CourseWork
{
    public partial class ParticipantForm : Form
    {
        private List<Form> forms;
        private IEnumerable<Participant> participants;
        private IEnumerable<Competition> competitions;
        private IEnumerable<Poem> poems;

        public ParticipantForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text, String caption, uint type);

        private void ParticipantForm_Resize(object sender, EventArgs e)
        {
            groupBoxCreateEditParticipant.Top = tabControlParticipant.Height / 2 - groupBoxCreateEditParticipant.Height / 2;
            groupBoxCreateEditParticipant.Left = tabControlParticipant.Width / 2 - groupBoxCreateEditParticipant.Width / 2;
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

        private void buttonCreateParticipant_Click(object sender, EventArgs e)
        {
            string _surname = textBoxSurname.Text;
            string _name = textBoxName.Text;
            string _secondName = textBoxSecondName.Text;
            DateTime _birhday = DateTime.Parse(dateTimePicker1.Text);

            if (!string.IsNullOrEmpty(_surname) && !string.IsNullOrEmpty(_name) && !string.IsNullOrEmpty(_secondName))
            {
                if (DateTime.Compare(_birhday, DateTime.Today) > 0)
                {
                    MessageBox(0, "���������� ��� �� ���������� ��������. ��������� ��������� ���� ��������.", "���������� ������� ������", 0);
                    return;
                }

                Participant participantNew = new Participant(_surname, _name, _secondName, _birhday);
                participantNew.AddToDataBase();
                //updateTable();

                textBoxSurname.Text = "";
                textBoxName.Text = "";
                textBoxSecondName.Text = "";
                dateTimePicker1.Text = DateTime.Now.ToString();
                MessageBox(0, "���������� ��������", "�������", 0);
            }
            else
            {
                MessageBox(0, "��������� ��� ���� � ���� '�������� �����������'", "������� ������ ����", 0);
                return;
            }
        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textBoxSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textBoxSurnameEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textBoxNameEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textBoxSecondNameEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void buttonEditParticipant_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownIDEdit.Value;
            Participant? participant = Participant.FindById(_id);
            if (participant == null)
            {
                MessageBox(0, $"����������� � id: {_id} �� ����������", "������ �� ������", 0);
                return;
            }

            string _surname = textBoxSurnameEdit.Text;
            string _name = textBoxNameEdit.Text;
            string _secondName = textBoxSecondNameEdit.Text;
            DateTime _birhday = DateTime.Parse(dateTimePicker2.Text);


            if (DateTime.Compare(_birhday, DateTime.Today) > 0)
            {
                MessageBox(0, "������� ��� �� ����������� ����. ��������� ��������� ���� ��������.", "���������� ������������� ������", 0);
                return;
            }
            else if (DateTime.Compare(_birhday, DateTime.Today) == 0)
            {
                MessageBox(0, "������� ����������� ����. �� �������, ��� ���� �������� ������� �����?", "��������������", 0);
            }

            using (DataBaseContext db = new DataBaseContext())
            {
                if (!string.IsNullOrEmpty(_surname)) participant.Surname = _surname;
                if (!string.IsNullOrEmpty(_name)) participant.Name = _name;
                if (!string.IsNullOrEmpty(_secondName)) participant.SecondName = _secondName;
                participant.DateOfBirth = _birhday;
                db.Participants.Update(participant);
                db.SaveChanges();
            }
            //updateTable();

            textBoxSurnameEdit.Text = "";
            textBoxNameEdit.Text = "";
            textBoxSecondNameEdit.Text = "";
            dateTimePicker2.Text = DateTime.Now.ToString();
            MessageBox(0, "���������� ��������������", "�������", 0);

        }

        private void buttonDeleteParticipant_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownIDDel.Value;
            Participant? participant = Participant.FindById(_id);
            if (participant == null)
            {
                MessageBox(0, $"����������� � id: {_id} �� ����������", "������ �� ������", 0);
                return;
            }

            participant.DeleteFromDataBase();
            MessageBox(0, "���������� ������", "�������", 0);
            //updateTable();
        }
    }
}