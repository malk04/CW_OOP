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
        private List<Form>? forms;
        private IEnumerable<Poem>? poems;
        private IEnumerable<Poem>? foundPoems;
        private IEnumerable<Poem>? filterPoems;

        public PoemForm()
        {
            InitializeComponent();
            comboBoxTheme.SelectedIndex = 0;
            comboBoxPoemTheme.SelectedIndex = 0;
        }

        private async void PoemForm_Load(object sender, EventArgs e)
        {
            await updateFromDataBase();
        }

        /// <summary>
        /// Обновление генерируемых компонентов из базы данных
        /// </summary>
        /// <returns></returns>
        private async Task updateFromDataBase()
        {
            DataBaseContext db = new DataBaseContext();
            poems = await db.Poems.Include(p => p.Participant).AsNoTracking().ToListAsync();
            textBoxFindByName.Text = "";
            updateAvtorComboBox();
            updateYearComboBox();
            updateTablePoems();
        }

        /// <summary>
        /// Сброс фильтрации и поиска
        /// </summary>
        /// <returns></returns>
        private void resetFilters()
        {
            foundPoems?.ToList().Clear();
            foundPoems = null;
            filterPoems?.ToList().Clear();
            filterPoems = null;
            textBoxFindByName.Text = "";
            comboBoxAvtor.Text = "Все";
            comboBoxYearWrite.Text = "Любой";
            comboBoxTheme.Text = "Все";
            updateTablePoems();
        }

        /// <summary>
        /// Обновление выпадающего списка с авторами
        /// </summary>
        private void updateAvtorComboBox()
        {
            string chosen = string.IsNullOrEmpty(comboBoxAvtor.Text) ? "Все" : comboBoxAvtor.Text;
            comboBoxAvtor.Items.Clear();
            comboBoxAvtor.Items.Add("Все");
            SortedSet<string> avtors = new SortedSet<string>();
            foreach (var poem in poems)
            {
                avtors.Add("id: " + poem.ParticipantId.ToString() + ". " + poem.Participant.Surname + " " + poem.Participant.Name + " " + poem.Participant.SecondName);
            }
            foreach (var avtor in avtors)
            {
                comboBoxAvtor.Items.Add(avtor);
            }
            comboBoxAvtor.Text = chosen;
        }

        /// <summary>
        /// Обновление выпадающего списка с годами написания стихотворений
        /// </summary>
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

        /// <summary>
        /// Обновление таблицы стихотворений с выбранной фильтрацией
        /// </summary>
        private void updateTablePoems()
        {
            if (filterPoems != null)
            {
                filterPoems.ToList().Clear();
            }
            
            string chosenAvtor = comboBoxAvtor.Text;
            string chosenYear = comboBoxYearWrite.Text;
            string chosenTheme = comboBoxTheme.Text;
            List<Poem> poemsForTable = new List<Poem>();

            if (foundPoems == null)
            {
                poemsForTable = poems.ToList();
            }
            else
            {
                poemsForTable = foundPoems.ToList();
            }
            
            if (chosenAvtor != "Все")
            {
                chosenAvtor = chosenAvtor.Remove(0, 4);
                string strID = chosenAvtor.Split().First();
                strID = strID.Remove(strID.Length - 1, 1);
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

            if (chosenAvtor != "Все" || chosenYear != "Любой" || chosenTheme != "Все")
            {
                labelForFilters.Text = "Найдено совпадений: " + poemsForTable.Count;
                filterPoems = poemsForTable;
            } else
            {
                labelForFilters.Text = "";
                filterPoems?.ToList().Clear();
                filterPoems = null;
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

        /// <summary>
        /// Создание нового стихотворения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonCreateParticipant_Click(object sender, EventArgs e)
        {
            CultureInfo provider = new CultureInfo("en-US");

            string _name = textBoxPoemName.Text;
            string? _theme = comboBoxPoemTheme.SelectedItem.ToString();
            int _idAvtor = (int)numericUpDownAvtorID.Value;
            DateTime _year = DateTime.ParseExact(dateTimePicker1.Text, "yyyy", provider);
            string _text = textBoxTextCreate.Text;

            try
            {
                Participant.FindById(_idAvtor);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show($"Конкурсанта с id: {_idAvtor} не существует", "Объект не найден", MessageBoxButtons.OK);
                return;
            }

            if (!string.IsNullOrEmpty(_name) && !string.IsNullOrEmpty(_theme) && !string.IsNullOrEmpty(_text))
            {
                if (_year.Year > DateTime.Now.Year)
                {
                    MessageBox.Show("Нельзя добавить ещё не написанное стихотворение. Проверьте введенный год написания.", "Невозможно создать объект", MessageBoxButtons.OK);
                    return;
                }
                Poem poemNew = new Poem(_name, _theme, _year, _text, _idAvtor);
                poemNew.AddToDataBase();
                await updateFromDataBase();

                textBoxPoemName.Text = "";
                comboBoxPoemTheme.SelectedIndex = 0;
                numericUpDownAvtorID.Value = 1;
                dateTimePicker1.Text = DateTime.Now.ToString();
                textBoxTextCreate.Text = "";
                MessageBox.Show("Стихотворение добавлено", "Успешно", MessageBoxButtons.OK);
            } 
            else
            {
                MessageBox.Show("Заполните все поля в окне 'Добавить стихотворение'", "Найдено пустое поле", MessageBoxButtons.OK);
                return;
            }
        }

        /// <summary>
        /// Редактирование стихотворения по id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonEditParticipant_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownEditId.Value;
            Poem poem;
            try
            {
                poem = Poem.FindById(_id);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show($"Стихотворения с id: {_id} не существует", "Объект не найден", MessageBoxButtons.OK);
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
                await updateFromDataBase();

                textBoxEditName.Text = "";
                MessageBox.Show("Название стихотворения отредактировано", "Успешно", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Заполните поле 'Название'", "Найдено пустое поле", MessageBoxButtons.OK);
                return;
            }
        }

        /// <summary>
        /// Вывод текста стихотворения по id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show($"Стихотворения с id: {_id} не существует", "Объект не найден", MessageBoxButtons.OK);
                return;
            }

            textBoxPrintPoem.Text = poem.Text;
        }

        /// <summary>
        /// Удаление стихотворения по id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonDelPoem_Click(object sender, EventArgs e)
        {
            int _id = (int)numericUpDownDelIDPoem.Value;
            Poem poem;
            try
            {
                poem = Poem.FindById(_id);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show($"Стихотворения с id: {_id} не существует", "Объект не найден", MessageBoxButtons.OK);
                return;
            }

            poem.DeleteFromDataBase();
            await updateFromDataBase();
            MessageBox.Show("Стихотворение удалено", "Успешно", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Загрузить текущие данные стихотворения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show($"Стихотворения с id: {_id} не существует", "Объект не найден", MessageBoxButtons.OK);
                return;
            }

            textBoxEditName.Text = poem.Name;
        }

        private void buttonFilterPoem_Click(object sender, EventArgs e)
        {
            updateTablePoems();
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            await updateFromDataBase();
            MessageBox.Show("Загружены последние данные", "", MessageBoxButtons.OK);
        }

        private void dataGridViewPoem_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridViewPoem.ClearSelection();
        }

        /// <summary>
        /// Поиск стихотворения по названию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (foundPoems != null)
            {
                foundPoems.ToList().Clear();
            }

            string strFind = textBoxFindByName.Text.ToLower();
            List<Poem> poemsForTable = new List<Poem>();

            if (filterPoems == null)
            {
                poemsForTable = poems.ToList();
            }
            else
            {
                poemsForTable = filterPoems.ToList();
            }

            if (!string.IsNullOrEmpty(strFind))
            {
                poemsForTable = poemsForTable.Where(x => x.Name.ToLower().Contains(strFind)).ToList();
                foundPoems = poemsForTable;
            } 
            else
            {
                foundPoems = null;
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
            labelForFilters.Text = "Найдено совпадений: " + poemsForTable.Count;
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
