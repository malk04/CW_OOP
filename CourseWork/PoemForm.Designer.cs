﻿namespace CourseWork
{
    partial class PoemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlPoem = new System.Windows.Forms.TabControl();
            this.SeeDelPoem = new System.Windows.Forms.TabPage();
            this.dataGridViewPoem = new System.Windows.Forms.DataGridView();
            this.IDPoem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePoem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themePoem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearPoem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avtorPoem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDelPoem = new System.Windows.Forms.GroupBox();
            this.numericUpDownDelIDPoem = new System.Windows.Forms.NumericUpDown();
            this.buttonDelPoem = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBoxFilterPoem = new System.Windows.Forms.GroupBox();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonFilterPoem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxAvtor = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
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
            this.CreateEditPrintPoem = new System.Windows.Forms.TabPage();
            this.groupBoxPrintPoem = new System.Windows.Forms.GroupBox();
            this.textBoxPrintPoem = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonPrintPoem = new System.Windows.Forms.Button();
            this.groupBoxEditPoem = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonEditParticipant = new System.Windows.Forms.Button();
            this.groupBoxCreatePoem = new System.Windows.Forms.GroupBox();
            this.textBoxTextCreate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownYearCreate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAvtorID = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateParticipant = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControlPoem.SuspendLayout();
            this.SeeDelPoem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoem)).BeginInit();
            this.groupBoxDelPoem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelIDPoem)).BeginInit();
            this.groupBoxFilterPoem.SuspendLayout();
            this.groupBoxDeleteParticipant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDDel)).BeginInit();
            this.groupBoxFilterParticipant.SuspendLayout();
            this.CreateEditPrintPoem.SuspendLayout();
            this.groupBoxPrintPoem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxEditPoem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBoxCreatePoem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvtorID)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPoem
            // 
            this.tabControlPoem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPoem.Controls.Add(this.SeeDelPoem);
            this.tabControlPoem.Controls.Add(this.CreateEditPrintPoem);
            this.tabControlPoem.Location = new System.Drawing.Point(6, 12);
            this.tabControlPoem.Name = "tabControlPoem";
            this.tabControlPoem.SelectedIndex = 0;
            this.tabControlPoem.Size = new System.Drawing.Size(1225, 390);
            this.tabControlPoem.TabIndex = 1;
            // 
            // SeeDelPoem
            // 
            this.SeeDelPoem.Controls.Add(this.dataGridViewPoem);
            this.SeeDelPoem.Controls.Add(this.groupBoxDelPoem);
            this.SeeDelPoem.Controls.Add(this.groupBoxFilterPoem);
            this.SeeDelPoem.Controls.Add(this.groupBoxDeleteParticipant);
            this.SeeDelPoem.Controls.Add(this.groupBoxFilterParticipant);
            this.SeeDelPoem.Location = new System.Drawing.Point(4, 29);
            this.SeeDelPoem.Name = "SeeDelPoem";
            this.SeeDelPoem.Padding = new System.Windows.Forms.Padding(3);
            this.SeeDelPoem.Size = new System.Drawing.Size(1217, 357);
            this.SeeDelPoem.TabIndex = 0;
            this.SeeDelPoem.Text = "Просмотр/удаление стихотворений";
            this.SeeDelPoem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPoem
            // 
            this.dataGridViewPoem.AllowUserToAddRows = false;
            this.dataGridViewPoem.AllowUserToDeleteRows = false;
            this.dataGridViewPoem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPoem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPoem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPoem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPoem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPoem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPoem,
            this.namePoem,
            this.themePoem,
            this.yearPoem,
            this.avtorPoem});
            this.dataGridViewPoem.EnableHeadersVisualStyles = false;
            this.dataGridViewPoem.Location = new System.Drawing.Point(5, 6);
            this.dataGridViewPoem.Name = "dataGridViewPoem";
            this.dataGridViewPoem.ReadOnly = true;
            this.dataGridViewPoem.RowHeadersVisible = false;
            this.dataGridViewPoem.RowHeadersWidth = 51;
            this.dataGridViewPoem.RowTemplate.Height = 29;
            this.dataGridViewPoem.Size = new System.Drawing.Size(819, 343);
            this.dataGridViewPoem.TabIndex = 6;
            // 
            // IDPoem
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            this.IDPoem.DefaultCellStyle = dataGridViewCellStyle8;
            this.IDPoem.FillWeight = 50F;
            this.IDPoem.HeaderText = "ID";
            this.IDPoem.MinimumWidth = 6;
            this.IDPoem.Name = "IDPoem";
            this.IDPoem.ReadOnly = true;
            // 
            // namePoem
            // 
            this.namePoem.FillWeight = 87.91444F;
            this.namePoem.HeaderText = "Название";
            this.namePoem.MinimumWidth = 6;
            this.namePoem.Name = "namePoem";
            this.namePoem.ReadOnly = true;
            // 
            // themePoem
            // 
            this.themePoem.FillWeight = 87.91444F;
            this.themePoem.HeaderText = "Тема";
            this.themePoem.MinimumWidth = 6;
            this.themePoem.Name = "themePoem";
            this.themePoem.ReadOnly = true;
            // 
            // yearPoem
            // 
            this.yearPoem.FillWeight = 87.91444F;
            this.yearPoem.HeaderText = "Год написания";
            this.yearPoem.MinimumWidth = 6;
            this.yearPoem.Name = "yearPoem";
            this.yearPoem.ReadOnly = true;
            // 
            // avtorPoem
            // 
            this.avtorPoem.FillWeight = 87.91444F;
            this.avtorPoem.HeaderText = "ID автора";
            this.avtorPoem.MinimumWidth = 6;
            this.avtorPoem.Name = "avtorPoem";
            this.avtorPoem.ReadOnly = true;
            // 
            // groupBoxDelPoem
            // 
            this.groupBoxDelPoem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDelPoem.Controls.Add(this.numericUpDownDelIDPoem);
            this.groupBoxDelPoem.Controls.Add(this.buttonDelPoem);
            this.groupBoxDelPoem.Controls.Add(this.label17);
            this.groupBoxDelPoem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDelPoem.Location = new System.Drawing.Point(830, 221);
            this.groupBoxDelPoem.Name = "groupBoxDelPoem";
            this.groupBoxDelPoem.Size = new System.Drawing.Size(381, 128);
            this.groupBoxDelPoem.TabIndex = 5;
            this.groupBoxDelPoem.TabStop = false;
            this.groupBoxDelPoem.Text = "Удаление стихотворения";
            // 
            // numericUpDownDelIDPoem
            // 
            this.numericUpDownDelIDPoem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownDelIDPoem.Location = new System.Drawing.Point(175, 37);
            this.numericUpDownDelIDPoem.Name = "numericUpDownDelIDPoem";
            this.numericUpDownDelIDPoem.Size = new System.Drawing.Size(194, 27);
            this.numericUpDownDelIDPoem.TabIndex = 10;
            // 
            // buttonDelPoem
            // 
            this.buttonDelPoem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDelPoem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelPoem.Location = new System.Drawing.Point(13, 79);
            this.buttonDelPoem.Name = "buttonDelPoem";
            this.buttonDelPoem.Size = new System.Drawing.Size(356, 37);
            this.buttonDelPoem.TabIndex = 9;
            this.buttonDelPoem.Text = "Удалить";
            this.buttonDelPoem.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(13, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "ID стихотворения";
            // 
            // groupBoxFilterPoem
            // 
            this.groupBoxFilterPoem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilterPoem.Controls.Add(this.comboBoxTheme);
            this.groupBoxFilterPoem.Controls.Add(this.label13);
            this.groupBoxFilterPoem.Controls.Add(this.buttonFilterPoem);
            this.groupBoxFilterPoem.Controls.Add(this.comboBox1);
            this.groupBoxFilterPoem.Controls.Add(this.comboBoxAvtor);
            this.groupBoxFilterPoem.Controls.Add(this.label15);
            this.groupBoxFilterPoem.Controls.Add(this.label16);
            this.groupBoxFilterPoem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxFilterPoem.Location = new System.Drawing.Point(830, 6);
            this.groupBoxFilterPoem.Name = "groupBoxFilterPoem";
            this.groupBoxFilterPoem.Size = new System.Drawing.Size(381, 209);
            this.groupBoxFilterPoem.TabIndex = 4;
            this.groupBoxFilterPoem.TabStop = false;
            this.groupBoxFilterPoem.Text = "Фильтрация";
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.Location = new System.Drawing.Point(175, 117);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(194, 28);
            this.comboBoxTheme.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(13, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 25);
            this.label13.TabIndex = 10;
            this.label13.Text = "Тема";
            // 
            // buttonFilterPoem
            // 
            this.buttonFilterPoem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonFilterPoem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFilterPoem.Location = new System.Drawing.Point(15, 161);
            this.buttonFilterPoem.Name = "buttonFilterPoem";
            this.buttonFilterPoem.Size = new System.Drawing.Size(354, 37);
            this.buttonFilterPoem.TabIndex = 9;
            this.buttonFilterPoem.Text = "Применить";
            this.buttonFilterPoem.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBoxAvtor
            // 
            this.comboBoxAvtor.FormattingEnabled = true;
            this.comboBoxAvtor.Location = new System.Drawing.Point(175, 32);
            this.comboBoxAvtor.Name = "comboBoxAvtor";
            this.comboBoxAvtor.Size = new System.Drawing.Size(194, 28);
            this.comboBoxAvtor.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(13, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "Год написания";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(13, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Автор";
            // 
            // groupBoxDeleteParticipant
            // 
            this.groupBoxDeleteParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDeleteParticipant.Controls.Add(this.numericUpDownIDDel);
            this.groupBoxDeleteParticipant.Controls.Add(this.buttonDeleteParticipant);
            this.groupBoxDeleteParticipant.Controls.Add(this.label14);
            this.groupBoxDeleteParticipant.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDeleteParticipant.Location = new System.Drawing.Point(1844, 193);
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
            this.numericUpDownIDDel.Name = "numericUpDownIDDel";
            this.numericUpDownIDDel.Size = new System.Drawing.Size(194, 27);
            this.numericUpDownIDDel.TabIndex = 10;
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
            this.groupBoxFilterParticipant.Location = new System.Drawing.Point(1844, 6);
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
            // CreateEditPrintPoem
            // 
            this.CreateEditPrintPoem.Controls.Add(this.groupBoxPrintPoem);
            this.CreateEditPrintPoem.Controls.Add(this.groupBoxEditPoem);
            this.CreateEditPrintPoem.Controls.Add(this.groupBoxCreatePoem);
            this.CreateEditPrintPoem.Location = new System.Drawing.Point(4, 29);
            this.CreateEditPrintPoem.Name = "CreateEditPrintPoem";
            this.CreateEditPrintPoem.Padding = new System.Windows.Forms.Padding(3);
            this.CreateEditPrintPoem.Size = new System.Drawing.Size(1217, 357);
            this.CreateEditPrintPoem.TabIndex = 1;
            this.CreateEditPrintPoem.Text = "Добавить/редактировать/вывести стихотворение";
            this.CreateEditPrintPoem.UseVisualStyleBackColor = true;
            // 
            // groupBoxPrintPoem
            // 
            this.groupBoxPrintPoem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxPrintPoem.Controls.Add(this.textBoxPrintPoem);
            this.groupBoxPrintPoem.Controls.Add(this.numericUpDown1);
            this.groupBoxPrintPoem.Controls.Add(this.label9);
            this.groupBoxPrintPoem.Controls.Add(this.buttonPrintPoem);
            this.groupBoxPrintPoem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPrintPoem.Location = new System.Drawing.Point(611, 167);
            this.groupBoxPrintPoem.Name = "groupBoxPrintPoem";
            this.groupBoxPrintPoem.Size = new System.Drawing.Size(600, 184);
            this.groupBoxPrintPoem.TabIndex = 4;
            this.groupBoxPrintPoem.TabStop = false;
            this.groupBoxPrintPoem.Text = "Вывести стихотворение";
            // 
            // textBoxPrintPoem
            // 
            this.textBoxPrintPoem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrintPoem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrintPoem.Location = new System.Drawing.Point(181, 72);
            this.textBoxPrintPoem.Multiline = true;
            this.textBoxPrintPoem.Name = "textBoxPrintPoem";
            this.textBoxPrintPoem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPrintPoem.Size = new System.Drawing.Size(413, 60);
            this.textBoxPrintPoem.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(181, 39);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(413, 27);
            this.numericUpDown1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "ID стихотворения";
            // 
            // buttonPrintPoem
            // 
            this.buttonPrintPoem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrintPoem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonPrintPoem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrintPoem.Location = new System.Drawing.Point(6, 141);
            this.buttonPrintPoem.Name = "buttonPrintPoem";
            this.buttonPrintPoem.Size = new System.Drawing.Size(588, 37);
            this.buttonPrintPoem.TabIndex = 8;
            this.buttonPrintPoem.Text = "Вывести";
            this.buttonPrintPoem.UseVisualStyleBackColor = false;
            // 
            // groupBoxEditPoem
            // 
            this.groupBoxEditPoem.Controls.Add(this.label7);
            this.groupBoxEditPoem.Controls.Add(this.textBox1);
            this.groupBoxEditPoem.Controls.Add(this.numericUpDown2);
            this.groupBoxEditPoem.Controls.Add(this.label12);
            this.groupBoxEditPoem.Controls.Add(this.buttonEditParticipant);
            this.groupBoxEditPoem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEditPoem.Location = new System.Drawing.Point(611, 6);
            this.groupBoxEditPoem.Name = "groupBoxEditPoem";
            this.groupBoxEditPoem.Size = new System.Drawing.Size(600, 155);
            this.groupBoxEditPoem.TabIndex = 3;
            this.groupBoxEditPoem.TabStop = false;
            this.groupBoxEditPoem.Text = "Редактировать стихотворение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Название";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(181, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 27);
            this.textBox1.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown2.Location = new System.Drawing.Point(181, 39);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(413, 27);
            this.numericUpDown2.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "ID стихотворения";
            // 
            // buttonEditParticipant
            // 
            this.buttonEditParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonEditParticipant.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditParticipant.Location = new System.Drawing.Point(6, 114);
            this.buttonEditParticipant.Name = "buttonEditParticipant";
            this.buttonEditParticipant.Size = new System.Drawing.Size(588, 37);
            this.buttonEditParticipant.TabIndex = 8;
            this.buttonEditParticipant.Text = "Редактировать";
            this.buttonEditParticipant.UseVisualStyleBackColor = false;
            // 
            // groupBoxCreatePoem
            // 
            this.groupBoxCreatePoem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCreatePoem.Controls.Add(this.textBoxTextCreate);
            this.groupBoxCreatePoem.Controls.Add(this.label11);
            this.groupBoxCreatePoem.Controls.Add(this.numericUpDownYearCreate);
            this.groupBoxCreatePoem.Controls.Add(this.numericUpDownAvtorID);
            this.groupBoxCreatePoem.Controls.Add(this.buttonCreateParticipant);
            this.groupBoxCreatePoem.Controls.Add(this.label4);
            this.groupBoxCreatePoem.Controls.Add(this.label3);
            this.groupBoxCreatePoem.Controls.Add(this.label2);
            this.groupBoxCreatePoem.Controls.Add(this.textBoxName);
            this.groupBoxCreatePoem.Controls.Add(this.label1);
            this.groupBoxCreatePoem.Controls.Add(this.textBoxSurname);
            this.groupBoxCreatePoem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCreatePoem.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCreatePoem.Name = "groupBoxCreatePoem";
            this.groupBoxCreatePoem.Size = new System.Drawing.Size(599, 345);
            this.groupBoxCreatePoem.TabIndex = 2;
            this.groupBoxCreatePoem.TabStop = false;
            this.groupBoxCreatePoem.Text = "Добавить стихотворение";
            // 
            // textBoxTextCreate
            // 
            this.textBoxTextCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTextCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTextCreate.Location = new System.Drawing.Point(181, 172);
            this.textBoxTextCreate.Multiline = true;
            this.textBoxTextCreate.Name = "textBoxTextCreate";
            this.textBoxTextCreate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTextCreate.Size = new System.Drawing.Size(412, 121);
            this.textBoxTextCreate.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Текст";
            // 
            // numericUpDownYearCreate
            // 
            this.numericUpDownYearCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownYearCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownYearCreate.Location = new System.Drawing.Point(181, 139);
            this.numericUpDownYearCreate.Name = "numericUpDownYearCreate";
            this.numericUpDownYearCreate.Size = new System.Drawing.Size(412, 27);
            this.numericUpDownYearCreate.TabIndex = 10;
            // 
            // numericUpDownAvtorID
            // 
            this.numericUpDownAvtorID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownAvtorID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownAvtorID.Location = new System.Drawing.Point(181, 104);
            this.numericUpDownAvtorID.Name = "numericUpDownAvtorID";
            this.numericUpDownAvtorID.Size = new System.Drawing.Size(412, 27);
            this.numericUpDownAvtorID.TabIndex = 9;
            // 
            // buttonCreateParticipant
            // 
            this.buttonCreateParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCreateParticipant.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateParticipant.Location = new System.Drawing.Point(6, 302);
            this.buttonCreateParticipant.Name = "buttonCreateParticipant";
            this.buttonCreateParticipant.Size = new System.Drawing.Size(587, 37);
            this.buttonCreateParticipant.TabIndex = 8;
            this.buttonCreateParticipant.Text = "Добавить";
            this.buttonCreateParticipant.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Год написания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID автора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тема";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(181, 70);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(412, 27);
            this.textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSurname.Location = new System.Drawing.Point(181, 37);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(412, 27);
            this.textBoxSurname.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1038, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 37);
            this.button4.TabIndex = 17;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(575, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 37);
            this.button3.TabIndex = 16;
            this.button3.Text = "Перейти к окну статистики";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(291, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Перейти к окну конкурсов";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(9, 413);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(269, 37);
            this.button5.TabIndex = 14;
            this.button5.Text = "Перейти к окну участников";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PoemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 462);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControlPoem);
            this.Name = "PoemForm";
            this.Text = "Окно стихотворений";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PoemForm_FormClosing);
            this.Resize += new System.EventHandler(this.PoemForm_Resize);
            this.tabControlPoem.ResumeLayout(false);
            this.SeeDelPoem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoem)).EndInit();
            this.groupBoxDelPoem.ResumeLayout(false);
            this.groupBoxDelPoem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelIDPoem)).EndInit();
            this.groupBoxFilterPoem.ResumeLayout(false);
            this.groupBoxFilterPoem.PerformLayout();
            this.groupBoxDeleteParticipant.ResumeLayout(false);
            this.groupBoxDeleteParticipant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDDel)).EndInit();
            this.groupBoxFilterParticipant.ResumeLayout(false);
            this.groupBoxFilterParticipant.PerformLayout();
            this.CreateEditPrintPoem.ResumeLayout(false);
            this.groupBoxPrintPoem.ResumeLayout(false);
            this.groupBoxPrintPoem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxEditPoem.ResumeLayout(false);
            this.groupBoxEditPoem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBoxCreatePoem.ResumeLayout(false);
            this.groupBoxCreatePoem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvtorID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlPoem;
        private TabPage SeeDelPoem;
        private GroupBox groupBoxDeleteParticipant;
        private NumericUpDown numericUpDownIDDel;
        private Button buttonDeleteParticipant;
        private Label label14;
        private GroupBox groupBoxFilterParticipant;
        private Button buttonFilterParticipant;
        private ComboBox comboBoxYear;
        private ComboBox comboBoxCompitition;
        private Label label6;
        private Label label5;
        private TabPage CreateEditPrintPoem;
        private GroupBox groupBoxEditPoem;
        private Label label12;
        private Button buttonEditParticipant;
        private GroupBox groupBoxCreatePoem;
        private Button buttonCreateParticipant;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxSurname;
        private GroupBox groupBoxFilterPoem;
        private ComboBox comboBoxTheme;
        private Label label13;
        private Button buttonFilterPoem;
        private ComboBox comboBox1;
        private ComboBox comboBoxAvtor;
        private Label label15;
        private Label label16;
        private GroupBox groupBoxDelPoem;
        private NumericUpDown numericUpDownDelIDPoem;
        private Button buttonDelPoem;
        private Label label17;
        private DataGridView dataGridViewPoem;
        private DataGridViewTextBoxColumn IDPoem;
        private DataGridViewTextBoxColumn namePoem;
        private DataGridViewTextBoxColumn themePoem;
        private DataGridViewTextBoxColumn yearPoem;
        private DataGridViewTextBoxColumn avtorPoem;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private TextBox textBoxTextCreate;
        private Label label11;
        private NumericUpDown numericUpDownYearCreate;
        private NumericUpDown numericUpDownAvtorID;
        private NumericUpDown numericUpDown2;
        private GroupBox groupBoxPrintPoem;
        private TextBox textBoxPrintPoem;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private Button buttonPrintPoem;
        private Label label7;
        private TextBox textBox1;
    }
}