namespace CourseWork
{
    partial class ParticipantForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlParticipant = new System.Windows.Forms.TabControl();
            this.SeeDelParticipant = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewParticipant = new System.Windows.Forms.DataGridView();
            this.IDParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirthParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsOfPoemsParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDeleteParticipant = new System.Windows.Forms.GroupBox();
            this.numericUpDownIDDel = new System.Windows.Forms.NumericUpDown();
            this.buttonDeleteParticipant = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxFilterParticipant = new System.Windows.Forms.GroupBox();
            this.buttonFilterParticipant = new System.Windows.Forms.Button();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxCompitition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateEditParticipant = new System.Windows.Forms.TabPage();
            this.groupBoxCreateEditParticipant = new System.Windows.Forms.GroupBox();
            this.groupBoxEditParticipant = new System.Windows.Forms.GroupBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.numericUpDownIDEdit = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonEditParticipant = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSecondNameEdit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNameEdit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSurnameEdit = new System.Windows.Forms.TextBox();
            this.groupBoxCreateParticipant = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCreateParticipant = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControlParticipant.SuspendLayout();
            this.SeeDelParticipant.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipant)).BeginInit();
            this.groupBoxDeleteParticipant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDDel)).BeginInit();
            this.groupBoxFilterParticipant.SuspendLayout();
            this.CreateEditParticipant.SuspendLayout();
            this.groupBoxCreateEditParticipant.SuspendLayout();
            this.groupBoxEditParticipant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEdit)).BeginInit();
            this.groupBoxCreateParticipant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlParticipant
            // 
            this.tabControlParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlParticipant.Controls.Add(this.SeeDelParticipant);
            this.tabControlParticipant.Controls.Add(this.CreateEditParticipant);
            this.tabControlParticipant.Location = new System.Drawing.Point(12, 12);
            this.tabControlParticipant.Name = "tabControlParticipant";
            this.tabControlParticipant.SelectedIndex = 0;
            this.tabControlParticipant.Size = new System.Drawing.Size(1225, 420);
            this.tabControlParticipant.TabIndex = 0;
            // 
            // SeeDelParticipant
            // 
            this.SeeDelParticipant.Controls.Add(this.groupBox1);
            this.SeeDelParticipant.Controls.Add(this.dataGridViewParticipant);
            this.SeeDelParticipant.Controls.Add(this.groupBoxDeleteParticipant);
            this.SeeDelParticipant.Controls.Add(this.groupBoxFilterParticipant);
            this.SeeDelParticipant.Location = new System.Drawing.Point(4, 29);
            this.SeeDelParticipant.Name = "SeeDelParticipant";
            this.SeeDelParticipant.Padding = new System.Windows.Forms.Padding(3);
            this.SeeDelParticipant.Size = new System.Drawing.Size(1217, 387);
            this.SeeDelParticipant.TabIndex = 0;
            this.SeeDelParticipant.Text = "Просмотр/удаление участников";
            this.SeeDelParticipant.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(830, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.Location = new System.Drawing.Point(13, 15);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(356, 37);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Обновить данные";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewParticipant
            // 
            this.dataGridViewParticipant.AllowUserToAddRows = false;
            this.dataGridViewParticipant.AllowUserToDeleteRows = false;
            this.dataGridViewParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewParticipant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParticipant.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewParticipant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParticipant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewParticipant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDParticipant,
            this.surnameParticipant,
            this.nameParticipant,
            this.middleNameParticipant,
            this.DateOfBirthParticipant,
            this.idsOfPoemsParticipant});
            this.dataGridViewParticipant.EnableHeadersVisualStyles = false;
            this.dataGridViewParticipant.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewParticipant.Name = "dataGridViewParticipant";
            this.dataGridViewParticipant.ReadOnly = true;
            this.dataGridViewParticipant.RowHeadersVisible = false;
            this.dataGridViewParticipant.RowHeadersWidth = 51;
            this.dataGridViewParticipant.RowTemplate.Height = 29;
            this.dataGridViewParticipant.Size = new System.Drawing.Size(819, 329);
            this.dataGridViewParticipant.TabIndex = 4;
            // 
            // IDParticipant
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            this.IDParticipant.DefaultCellStyle = dataGridViewCellStyle2;
            this.IDParticipant.FillWeight = 50F;
            this.IDParticipant.HeaderText = "ID";
            this.IDParticipant.MinimumWidth = 6;
            this.IDParticipant.Name = "IDParticipant";
            this.IDParticipant.ReadOnly = true;
            // 
            // surnameParticipant
            // 
            this.surnameParticipant.FillWeight = 87.91444F;
            this.surnameParticipant.HeaderText = "Фамилия";
            this.surnameParticipant.MinimumWidth = 6;
            this.surnameParticipant.Name = "surnameParticipant";
            this.surnameParticipant.ReadOnly = true;
            // 
            // nameParticipant
            // 
            this.nameParticipant.FillWeight = 87.91444F;
            this.nameParticipant.HeaderText = "Имя";
            this.nameParticipant.MinimumWidth = 6;
            this.nameParticipant.Name = "nameParticipant";
            this.nameParticipant.ReadOnly = true;
            // 
            // middleNameParticipant
            // 
            this.middleNameParticipant.FillWeight = 87.91444F;
            this.middleNameParticipant.HeaderText = "Отчество";
            this.middleNameParticipant.MinimumWidth = 6;
            this.middleNameParticipant.Name = "middleNameParticipant";
            this.middleNameParticipant.ReadOnly = true;
            // 
            // DateOfBirthParticipant
            // 
            this.DateOfBirthParticipant.FillWeight = 87.91444F;
            this.DateOfBirthParticipant.HeaderText = "Дата рождения";
            this.DateOfBirthParticipant.MinimumWidth = 6;
            this.DateOfBirthParticipant.Name = "DateOfBirthParticipant";
            this.DateOfBirthParticipant.ReadOnly = true;
            // 
            // idsOfPoemsParticipant
            // 
            this.idsOfPoemsParticipant.FillWeight = 87.91444F;
            this.idsOfPoemsParticipant.HeaderText = "ID стихотворений";
            this.idsOfPoemsParticipant.MinimumWidth = 6;
            this.idsOfPoemsParticipant.Name = "idsOfPoemsParticipant";
            this.idsOfPoemsParticipant.ReadOnly = true;
            // 
            // groupBoxDeleteParticipant
            // 
            this.groupBoxDeleteParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDeleteParticipant.Controls.Add(this.numericUpDownIDDel);
            this.groupBoxDeleteParticipant.Controls.Add(this.buttonDeleteParticipant);
            this.groupBoxDeleteParticipant.Controls.Add(this.label14);
            this.groupBoxDeleteParticipant.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDeleteParticipant.Location = new System.Drawing.Point(830, 190);
            this.groupBoxDeleteParticipant.Name = "groupBoxDeleteParticipant";
            this.groupBoxDeleteParticipant.Size = new System.Drawing.Size(381, 128);
            this.groupBoxDeleteParticipant.TabIndex = 3;
            this.groupBoxDeleteParticipant.TabStop = false;
            this.groupBoxDeleteParticipant.Text = "Удаление конкурсанта";
            // 
            // numericUpDownIDDel
            // 
            this.numericUpDownIDDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownIDDel.Location = new System.Drawing.Point(175, 37);
            this.numericUpDownIDDel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIDDel.Name = "numericUpDownIDDel";
            this.numericUpDownIDDel.Size = new System.Drawing.Size(194, 27);
            this.numericUpDownIDDel.TabIndex = 10;
            this.numericUpDownIDDel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonDeleteParticipant
            // 
            this.buttonDeleteParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDeleteParticipant.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteParticipant.Location = new System.Drawing.Point(13, 79);
            this.buttonDeleteParticipant.Name = "buttonDeleteParticipant";
            this.buttonDeleteParticipant.Size = new System.Drawing.Size(356, 37);
            this.buttonDeleteParticipant.TabIndex = 9;
            this.buttonDeleteParticipant.Text = "Удалить";
            this.buttonDeleteParticipant.UseVisualStyleBackColor = false;
            this.buttonDeleteParticipant.Click += new System.EventHandler(this.buttonDeleteParticipant_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(13, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "ID конурсанта";
            // 
            // groupBoxFilterParticipant
            // 
            this.groupBoxFilterParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilterParticipant.Controls.Add(this.buttonFilterParticipant);
            this.groupBoxFilterParticipant.Controls.Add(this.comboBoxYear);
            this.groupBoxFilterParticipant.Controls.Add(this.comboBoxCompitition);
            this.groupBoxFilterParticipant.Controls.Add(this.label6);
            this.groupBoxFilterParticipant.Controls.Add(this.label5);
            this.groupBoxFilterParticipant.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxFilterParticipant.Location = new System.Drawing.Point(830, 3);
            this.groupBoxFilterParticipant.Name = "groupBoxFilterParticipant";
            this.groupBoxFilterParticipant.Size = new System.Drawing.Size(381, 174);
            this.groupBoxFilterParticipant.TabIndex = 2;
            this.groupBoxFilterParticipant.TabStop = false;
            this.groupBoxFilterParticipant.Text = "Фильтрация";
            // 
            // buttonFilterParticipant
            // 
            this.buttonFilterParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonFilterParticipant.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFilterParticipant.Location = new System.Drawing.Point(15, 122);
            this.buttonFilterParticipant.Name = "buttonFilterParticipant";
            this.buttonFilterParticipant.Size = new System.Drawing.Size(354, 37);
            this.buttonFilterParticipant.TabIndex = 9;
            this.buttonFilterParticipant.Text = "Применить";
            this.buttonFilterParticipant.UseVisualStyleBackColor = false;
            this.buttonFilterParticipant.Click += new System.EventHandler(this.buttonFilterParticipant_Click);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(175, 74);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(194, 28);
            this.comboBoxYear.TabIndex = 3;
            // 
            // comboBoxCompitition
            // 
            this.comboBoxCompitition.FormattingEnabled = true;
            this.comboBoxCompitition.Location = new System.Drawing.Point(175, 32);
            this.comboBoxCompitition.Name = "comboBoxCompitition";
            this.comboBoxCompitition.Size = new System.Drawing.Size(194, 28);
            this.comboBoxCompitition.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Год рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Конкурс";
            // 
            // CreateEditParticipant
            // 
            this.CreateEditParticipant.Controls.Add(this.groupBoxCreateEditParticipant);
            this.CreateEditParticipant.Location = new System.Drawing.Point(4, 29);
            this.CreateEditParticipant.Name = "CreateEditParticipant";
            this.CreateEditParticipant.Padding = new System.Windows.Forms.Padding(3);
            this.CreateEditParticipant.Size = new System.Drawing.Size(1217, 387);
            this.CreateEditParticipant.TabIndex = 1;
            this.CreateEditParticipant.Text = "Добавить/редактировать участника";
            this.CreateEditParticipant.UseVisualStyleBackColor = true;
            // 
            // groupBoxCreateEditParticipant
            // 
            this.groupBoxCreateEditParticipant.Controls.Add(this.groupBoxEditParticipant);
            this.groupBoxCreateEditParticipant.Controls.Add(this.groupBoxCreateParticipant);
            this.groupBoxCreateEditParticipant.Location = new System.Drawing.Point(176, 42);
            this.groupBoxCreateEditParticipant.Name = "groupBoxCreateEditParticipant";
            this.groupBoxCreateEditParticipant.Size = new System.Drawing.Size(865, 303);
            this.groupBoxCreateEditParticipant.TabIndex = 3;
            this.groupBoxCreateEditParticipant.TabStop = false;
            // 
            // groupBoxEditParticipant
            // 
            this.groupBoxEditParticipant.Controls.Add(this.buttonLoad);
            this.groupBoxEditParticipant.Controls.Add(this.numericUpDownIDEdit);
            this.groupBoxEditParticipant.Controls.Add(this.label12);
            this.groupBoxEditParticipant.Controls.Add(this.buttonEditParticipant);
            this.groupBoxEditParticipant.Controls.Add(this.dateTimePicker2);
            this.groupBoxEditParticipant.Controls.Add(this.label7);
            this.groupBoxEditParticipant.Controls.Add(this.label8);
            this.groupBoxEditParticipant.Controls.Add(this.textBoxSecondNameEdit);
            this.groupBoxEditParticipant.Controls.Add(this.label9);
            this.groupBoxEditParticipant.Controls.Add(this.textBoxNameEdit);
            this.groupBoxEditParticipant.Controls.Add(this.label10);
            this.groupBoxEditParticipant.Controls.Add(this.textBoxSurnameEdit);
            this.groupBoxEditParticipant.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEditParticipant.Location = new System.Drawing.Point(435, 16);
            this.groupBoxEditParticipant.Name = "groupBoxEditParticipant";
            this.groupBoxEditParticipant.Size = new System.Drawing.Size(424, 276);
            this.groupBoxEditParticipant.TabIndex = 3;
            this.groupBoxEditParticipant.TabStop = false;
            this.groupBoxEditParticipant.Text = "Редактировать конкурсанта";
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.Location = new System.Drawing.Point(16, 228);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(191, 37);
            this.buttonLoad.TabIndex = 11;
            this.buttonLoad.Text = "Загрузить данные";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // numericUpDownIDEdit
            // 
            this.numericUpDownIDEdit.Location = new System.Drawing.Point(213, 32);
            this.numericUpDownIDEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIDEdit.Name = "numericUpDownIDEdit";
            this.numericUpDownIDEdit.Size = new System.Drawing.Size(194, 27);
            this.numericUpDownIDEdit.TabIndex = 10;
            this.numericUpDownIDEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(16, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "ID конкурсанта";
            // 
            // buttonEditParticipant
            // 
            this.buttonEditParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonEditParticipant.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditParticipant.Location = new System.Drawing.Point(213, 228);
            this.buttonEditParticipant.Name = "buttonEditParticipant";
            this.buttonEditParticipant.Size = new System.Drawing.Size(194, 37);
            this.buttonEditParticipant.TabIndex = 8;
            this.buttonEditParticipant.Text = "Редактировать";
            this.buttonEditParticipant.UseVisualStyleBackColor = false;
            this.buttonEditParticipant.Click += new System.EventHandler(this.buttonEditParticipant_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(213, 176);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(194, 27);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата рождения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(16, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Отчество";
            // 
            // textBoxSecondNameEdit
            // 
            this.textBoxSecondNameEdit.Location = new System.Drawing.Point(213, 142);
            this.textBoxSecondNameEdit.Name = "textBoxSecondNameEdit";
            this.textBoxSecondNameEdit.Size = new System.Drawing.Size(194, 27);
            this.textBoxSecondNameEdit.TabIndex = 4;
            this.textBoxSecondNameEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSecondNameEdit_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(16, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Имя";
            // 
            // textBoxNameEdit
            // 
            this.textBoxNameEdit.Location = new System.Drawing.Point(213, 108);
            this.textBoxNameEdit.Name = "textBoxNameEdit";
            this.textBoxNameEdit.Size = new System.Drawing.Size(194, 27);
            this.textBoxNameEdit.TabIndex = 2;
            this.textBoxNameEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameEdit_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(16, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Фамилия";
            // 
            // textBoxSurnameEdit
            // 
            this.textBoxSurnameEdit.Location = new System.Drawing.Point(213, 76);
            this.textBoxSurnameEdit.Name = "textBoxSurnameEdit";
            this.textBoxSurnameEdit.Size = new System.Drawing.Size(194, 27);
            this.textBoxSurnameEdit.TabIndex = 0;
            this.textBoxSurnameEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSurnameEdit_KeyPress);
            // 
            // groupBoxCreateParticipant
            // 
            this.groupBoxCreateParticipant.Controls.Add(this.label11);
            this.groupBoxCreateParticipant.Controls.Add(this.buttonCreateParticipant);
            this.groupBoxCreateParticipant.Controls.Add(this.dateTimePicker1);
            this.groupBoxCreateParticipant.Controls.Add(this.label4);
            this.groupBoxCreateParticipant.Controls.Add(this.label3);
            this.groupBoxCreateParticipant.Controls.Add(this.textBoxSecondName);
            this.groupBoxCreateParticipant.Controls.Add(this.label2);
            this.groupBoxCreateParticipant.Controls.Add(this.textBoxName);
            this.groupBoxCreateParticipant.Controls.Add(this.label1);
            this.groupBoxCreateParticipant.Controls.Add(this.textBoxSurname);
            this.groupBoxCreateParticipant.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCreateParticipant.Location = new System.Drawing.Point(6, 16);
            this.groupBoxCreateParticipant.Name = "groupBoxCreateParticipant";
            this.groupBoxCreateParticipant.Size = new System.Drawing.Size(423, 276);
            this.groupBoxCreateParticipant.TabIndex = 2;
            this.groupBoxCreateParticipant.TabStop = false;
            this.groupBoxCreateParticipant.Text = "Добавить конкурсанта";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(15, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(301, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Заполните все поля (без пробелов)";
            // 
            // buttonCreateParticipant
            // 
            this.buttonCreateParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCreateParticipant.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateParticipant.Location = new System.Drawing.Point(15, 228);
            this.buttonCreateParticipant.Name = "buttonCreateParticipant";
            this.buttonCreateParticipant.Size = new System.Drawing.Size(392, 37);
            this.buttonCreateParticipant.TabIndex = 8;
            this.buttonCreateParticipant.Text = "Добавить";
            this.buttonCreateParticipant.UseVisualStyleBackColor = false;
            this.buttonCreateParticipant.Click += new System.EventHandler(this.buttonCreateParticipant_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(213, 142);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(194, 27);
            this.textBoxSecondName.TabIndex = 4;
            this.textBoxSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSecondName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(213, 109);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(194, 27);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(213, 76);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(194, 27);
            this.textBoxSurname.TabIndex = 0;
            this.textBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSurname_KeyPress);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Перейти к окну стихотворений";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(294, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Перейти к окну конкурсов";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(578, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 37);
            this.button3.TabIndex = 12;
            this.button3.Text = "Перейти к окну статистики";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1041, 443);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 37);
            this.button4.TabIndex = 13;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 492);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlParticipant);
            this.Name = "ParticipantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно участников";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParticipantForm_FormClosing);
            this.Load += new System.EventHandler(this.ParticipantForm_Load);
            this.Resize += new System.EventHandler(this.ParticipantForm_Resize);
            this.tabControlParticipant.ResumeLayout(false);
            this.SeeDelParticipant.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipant)).EndInit();
            this.groupBoxDeleteParticipant.ResumeLayout(false);
            this.groupBoxDeleteParticipant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDDel)).EndInit();
            this.groupBoxFilterParticipant.ResumeLayout(false);
            this.groupBoxFilterParticipant.PerformLayout();
            this.CreateEditParticipant.ResumeLayout(false);
            this.groupBoxCreateEditParticipant.ResumeLayout(false);
            this.groupBoxEditParticipant.ResumeLayout(false);
            this.groupBoxEditParticipant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEdit)).EndInit();
            this.groupBoxCreateParticipant.ResumeLayout(false);
            this.groupBoxCreateParticipant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlParticipant;
        private TabPage SeeDelParticipant;
        private TabPage CreateEditParticipant;
        private GroupBox groupBoxFilterParticipant;
        private Button buttonFilterParticipant;
        private ComboBox comboBoxYear;
        private ComboBox comboBoxCompitition;
        private Label label6;
        private Label label5;
        private GroupBox groupBoxCreateEditParticipant;
        private GroupBox groupBoxCreateParticipant;
        private Button buttonCreateParticipant;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private TextBox textBoxSecondName;
        private Label label2;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxSurname;
        private GroupBox groupBoxEditParticipant;
        private NumericUpDown numericUpDownIDEdit;
        private Label label12;
        private Button buttonEditParticipant;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Label label8;
        private TextBox textBoxSecondNameEdit;
        private Label label9;
        private TextBox textBoxNameEdit;
        private Label label10;
        private TextBox textBoxSurnameEdit;
        private Label label11;
        private GroupBox groupBoxDeleteParticipant;
        private Button buttonDeleteParticipant;
        private Label label14;
        private NumericUpDown numericUpDownIDDel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridViewParticipant;
        private DataGridViewTextBoxColumn IDParticipant;
        private DataGridViewTextBoxColumn surnameParticipant;
        private DataGridViewTextBoxColumn nameParticipant;
        private DataGridViewTextBoxColumn middleNameParticipant;
        private DataGridViewTextBoxColumn DateOfBirthParticipant;
        private DataGridViewTextBoxColumn idsOfPoemsParticipant;
        private Button buttonLoad;
        private GroupBox groupBox1;
        private Button buttonUpdate;
    }
}