namespace CourseWork
{
    public partial class ParticipantForm : Form
    {
        private List<Form> forms;

        public ParticipantForm()
        {
            InitializeComponent();
        }

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
    }
}