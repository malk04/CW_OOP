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
    public partial class PoemForm : Form
    {
        private List<Form> forms;
        private IEnumerable<Poem> poems;

        public PoemForm()
        {
            InitializeComponent();
            comboBoxTheme.SelectedIndex = 0;
            comboBoxPoemTheme.SelectedIndex = 0;
            updateFromDataBase();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text, String caption, uint type);

        private async Task updateFromDataBase()
        {
            DataBaseContext db = new DataBaseContext();
            poems = await db.Poems.Include(p => p.Participant).AsNoTracking().ToListAsync();
            updateAvtorComboBox();
            updateYearComboBox();
            updateTablePoems();
        }

        private void updateAvtorComboBox()
        {
            string chosen = string.IsNullOrEmpty(comboBoxAvtor.Text) ? "Все" : comboBoxAvtor.Text;
            comboBoxAvtor.Items.Clear();
            comboBoxAvtor.Items.Add("Все");
            foreach (var poem in poems)
            {
                comboBoxAvtor.Items.Add("id: " + poem.ParticipantId.ToString() + ". " + poem.Participant.Surname + " " + poem.Participant.Name + " " + poem.Participant.SecondName);
            }
            comboBoxAvtor.Text = chosen;
        }

        private void updateYearComboBox()
        {
            string chosen = string.IsNullOrEmpty(comboBoxYearWrite.Text) ? "Любой" : comboBoxYearWrite.Text;
            comboBoxYearWrite.Items.Clear();
            comboBoxYearWrite.Items.Add("Любой");
            SortedSet<int> years = new SortedSet<int>();
            foreach (var poem in poems)
            {
                years.Add(poem.Year.Year);
            }
            foreach (int year in years)
            {
                comboBoxYearWrite.Items.Add(year.ToString());
            }
            comboBoxYearWrite.Text = chosen;
        }

        private void updateTablePoems()
        {
            string chosenAvtor = comboBoxAvtor.Text;
            string chosenYear = comboBoxYearWrite.Text;
            string chosenTheme = comboBoxTheme.Text;
            List<Poem> poemsForTable = new List<Poem>();

            poemsForTable = poems.ToList();
            if (chosenAvtor != "Все")
            {
                chosenAvtor.Remove(0, 4);
                string strID = chosenAvtor.Split().First();
                poemsForTable = poemsForTable.Where(x => x.ParticipantId == Int32.Parse(strID)).ToList();
            }

            if (chosenYear != "Любой")
            {
                poemsForTable = poemsForTable.Where(x => x.Year.Year == Int32.Parse(chosenYear)).ToList();
            }

            if (chosenTheme != "Все")
            {
                poemsForTable = poemsForTable.Where(x => x.Theme == chosenTheme).ToList();
            }


            dataGridViewPoem.RowCount = 0;
            int i = 0;
            foreach (Poem poem in poemsForTable)
            {
                DataGridViewRow row = new DataGridViewRow();
                dataGridViewPoem.Rows.Add(row);
                dataGridViewPoem.Rows[i].Cells[0].Value = poem.PoemId.ToString();
                dataGridViewPoem.Rows[i].Cells[1].Value = poem.Name;
                dataGridViewPoem.Rows[i].Cells[2].Value = poem.Theme;
                dataGridViewPoem.Rows[i].Cells[3].Value = poem.Year.ToString("yyyy");
                dataGridViewPoem.Rows[i].Cells[4].Value = poem.ParticipantId.ToString();
                i++;
            }
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

        private void buttonCreateParticipant_Click(object sender, EventArgs e)
        {
            CultureInfo provider = new CultureInfo("en-US");

            string _name = textBoxPoemName.Text;
            string _theme = comboBoxPoemTheme.SelectedItem.ToString();
            int _idAvtor = (int)numericUpDownAvtorID.Value;
            DateTime _year = DateTime.ParseExact(dateTimePicker1.Text, "yyyy", provider);
            string _text = textBoxTextCreate.Text;

            try
            {
                Participant.FindById(_idAvtor);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Конкурсанта с id: {_idAvtor} не существует", "Объект не найден", 0);
                return;
            }

            if (!string.IsNullOrEmpty(_name) && !string.IsNullOrEmpty(_theme) && !string.IsNullOrEmpty(_text))
            {
                if (_year.Year > DateTime.Now.Year)
                {
                    MessageBox(0, "Нельзя добавить ещё не написанное стихотворение. Проверьте введенный год написания.", "Невозможно создать объект", 0);
                    return;
                }
                Poem poemNew = new Poem(_name, _theme, _year, _text, _idAvtor);
                poemNew.AddToDataBase();
                updateFromDataBase();

                textBoxPoemName.Text = "";
                comboBoxPoemTheme.SelectedIndex = 0;
                numericUpDownAvtorID.Value = 1;
                dateTimePicker1.Text = DateTime.Now.ToString();
                textBoxTextCreate.Text = "";
                MessageBox(0, "Стихотворение добавлено", "Успешно", 0);
            } 
            else
            {
                MessageBox(0, "Заполните все поля в окне 'Добавить стихотворение'", "Найдено пустое поле", 0);
                return;
            }
        }

        private void buttonEditParticipant_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownEditId.Value;
            Poem poem;
            try
            {
                poem = Poem.FindById(_id);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Стихотворения с id: {_id} не существует", "Объект не найден", 0);
                return;
            }

            string _name = textBoxEditName.Text;

            if (!string.IsNullOrEmpty(_name))
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    poem.Name = _name;
                    db.Entry(poem).State = EntityState.Modified;
                    db.SaveChanges();
                }
                updateFromDataBase();

                textBoxEditName.Text = "";
                MessageBox(0, "Название стихотворения отредактировано", "Успешно", 0);
            }
            else
            {
                MessageBox(0, "Заполните поле 'Название'", "Найдено пустое поле", 0);
                return;
            }
        }

        private void buttonPrintPoem_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownViewId.Value;
            Poem poem;
            try
            {
                poem = Poem.FindById(_id);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Стихотворения с id: {_id} не существует", "Объект не найден", 0);
                return;
            }

            textBoxPrintPoem.Text = poem.Text;
        }

        private void buttonDelPoem_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownDelIDPoem.Value;
            Poem poem;
            try
            {
                poem = Poem.FindById(_id);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Стихотворения с id: {_id} не существует", "Объект не найден", 0);
                return;
            }

            poem.DeleteFromDataBase();
            updateFromDataBase();
            MessageBox(0, "Стихотворение удалено", "Успешно", 0);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownEditId.Value;
            Poem poem;
            try
            {
                poem = Poem.FindById(_id);
            }
            catch (InvalidOperationException)
            {
                MessageBox(0, $"Стихотворения с id: {_id} не существует", "Объект не найден", 0);
                return;
            }

            textBoxEditName.Text = poem.Name;
        }

        private void buttonFilterPoem_Click(object sender, EventArgs e)
        {
            updateTablePoems();
        }
    }
}
