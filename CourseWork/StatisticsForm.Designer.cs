namespace CourseWork
{
    partial class StatisticsForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.groupBoxFlex = new System.Windows.Forms.GroupBox();
            this.buttonDeleteParticipant = new System.Windows.Forms.Button();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.textBoxAverageAge = new System.Windows.Forms.TextBox();
            this.textBoxCountPoems = new System.Windows.Forms.TextBox();
            this.textBoxCountParticipants = new System.Windows.Forms.TextBox();
            this.textBoxCountCompetitions = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxStatistics.SuspendLayout();
            this.groupBoxFlex.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1041, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 37);
            this.button4.TabIndex = 21;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(578, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 37);
            this.button3.TabIndex = 20;
            this.button3.Text = "Перейти к окну конкурсов";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(294, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Перейти к окну стихотворений";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Перейти к окну участников";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(73, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Интересующий год:";
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStatistics.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxStatistics.Controls.Add(this.groupBoxFlex);
            this.groupBoxStatistics.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(1219, 353);
            this.groupBoxStatistics.TabIndex = 24;
            this.groupBoxStatistics.TabStop = false;
            // 
            // groupBoxFlex
            // 
            this.groupBoxFlex.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxFlex.Controls.Add(this.buttonDeleteParticipant);
            this.groupBoxFlex.Controls.Add(this.comboBoxYear);
            this.groupBoxFlex.Controls.Add(this.textBoxAverageAge);
            this.groupBoxFlex.Controls.Add(this.textBoxCountPoems);
            this.groupBoxFlex.Controls.Add(this.textBoxCountParticipants);
            this.groupBoxFlex.Controls.Add(this.textBoxCountCompetitions);
            this.groupBoxFlex.Controls.Add(this.label5);
            this.groupBoxFlex.Controls.Add(this.label4);
            this.groupBoxFlex.Controls.Add(this.label3);
            this.groupBoxFlex.Controls.Add(this.label2);
            this.groupBoxFlex.Controls.Add(this.label1);
            this.groupBoxFlex.Controls.Add(this.label6);
            this.groupBoxFlex.Location = new System.Drawing.Point(6, 13);
            this.groupBoxFlex.Name = "groupBoxFlex";
            this.groupBoxFlex.Size = new System.Drawing.Size(1207, 334);
            this.groupBoxFlex.TabIndex = 24;
            this.groupBoxFlex.TabStop = false;
            // 
            // buttonDeleteParticipant
            // 
            this.buttonDeleteParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDeleteParticipant.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteParticipant.Location = new System.Drawing.Point(73, 146);
            this.buttonDeleteParticipant.Name = "buttonDeleteParticipant";
            this.buttonDeleteParticipant.Size = new System.Drawing.Size(349, 37);
            this.buttonDeleteParticipant.TabIndex = 34;
            this.buttonDeleteParticipant.Text = "Получить результаты";
            this.buttonDeleteParticipant.UseVisualStyleBackColor = false;
            this.buttonDeleteParticipant.Click += new System.EventHandler(this.buttonDeleteParticipant_Click);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(263, 104);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(159, 28);
            this.comboBoxYear.TabIndex = 33;
            // 
            // textBoxAverageAge
            // 
            this.textBoxAverageAge.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAverageAge.Enabled = false;
            this.textBoxAverageAge.Location = new System.Drawing.Point(846, 231);
            this.textBoxAverageAge.Name = "textBoxAverageAge";
            this.textBoxAverageAge.ReadOnly = true;
            this.textBoxAverageAge.Size = new System.Drawing.Size(291, 27);
            this.textBoxAverageAge.TabIndex = 32;
            // 
            // textBoxCountPoems
            // 
            this.textBoxCountPoems.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCountPoems.Enabled = false;
            this.textBoxCountPoems.Location = new System.Drawing.Point(846, 189);
            this.textBoxCountPoems.Name = "textBoxCountPoems";
            this.textBoxCountPoems.ReadOnly = true;
            this.textBoxCountPoems.Size = new System.Drawing.Size(291, 27);
            this.textBoxCountPoems.TabIndex = 31;
            // 
            // textBoxCountParticipants
            // 
            this.textBoxCountParticipants.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCountParticipants.Enabled = false;
            this.textBoxCountParticipants.Location = new System.Drawing.Point(846, 146);
            this.textBoxCountParticipants.Name = "textBoxCountParticipants";
            this.textBoxCountParticipants.ReadOnly = true;
            this.textBoxCountParticipants.Size = new System.Drawing.Size(291, 27);
            this.textBoxCountParticipants.TabIndex = 30;
            // 
            // textBoxCountCompetitions
            // 
            this.textBoxCountCompetitions.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCountCompetitions.Enabled = false;
            this.textBoxCountCompetitions.Location = new System.Drawing.Point(846, 104);
            this.textBoxCountCompetitions.Name = "textBoxCountCompetitions";
            this.textBoxCountCompetitions.ReadOnly = true;
            this.textBoxCountCompetitions.Size = new System.Drawing.Size(291, 27);
            this.textBoxCountCompetitions.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(484, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Средний возраст участников";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(484, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Общее кол-во написанных стихов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(484, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Общее количество участников";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(484, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Количество проведенный конкурсов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(511, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Годовой анализ";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 430);
            this.Controls.Add(this.groupBoxStatistics);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно статистики";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatisticsForm_FormClosing);
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.Resize += new System.EventHandler(this.StatisticsForm_Resize);
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxFlex.ResumeLayout(false);
            this.groupBoxFlex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label6;
        private GroupBox groupBoxStatistics;
        private GroupBox groupBoxFlex;
        private ComboBox comboBoxYear;
        private TextBox textBoxAverageAge;
        private TextBox textBoxCountPoems;
        private TextBox textBoxCountParticipants;
        private TextBox textBoxCountCompetitions;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonDeleteParticipant;
    }
}