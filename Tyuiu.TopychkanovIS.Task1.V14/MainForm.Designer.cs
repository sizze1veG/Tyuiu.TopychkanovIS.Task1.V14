namespace Tyuiu.TopychkanovIS.Task1.V14
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTransports_TIS = new System.Windows.Forms.DataGridView();
            this.ColumnTransportType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRouteNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRouteIntroduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInitialStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFinalStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRouteTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxTransportType_TIS = new System.Windows.Forms.ComboBox();
            this.textBoxTransportNumber_TIS = new System.Windows.Forms.TextBox();
            this.dateTimePickerRouteIntroduction_TIS = new System.Windows.Forms.DateTimePicker();
            this.textBoxInitialStop_TIS = new System.Windows.Forms.TextBox();
            this.textBoxFinalStop_TIS = new System.Windows.Forms.TextBox();
            this.comboBoxRouteHours_TIS = new System.Windows.Forms.ComboBox();
            this.comboBoxRouteTimeMin_TIS = new System.Windows.Forms.ComboBox();
            this.textBoxNote_TIS = new System.Windows.Forms.TextBox();
            this.groupBoxTransports_TIS = new System.Windows.Forms.GroupBox();
            this.buttonSearch_TIS = new System.Windows.Forms.Button();
            this.buttonDeleteTransport_TIS = new System.Windows.Forms.Button();
            this.buttonEditTransport_TIS = new System.Windows.Forms.Button();
            this.buttonAddTransport_TIS = new System.Windows.Forms.Button();
            this.labelNote_TIS = new System.Windows.Forms.Label();
            this.labelTime_TIS = new System.Windows.Forms.Label();
            this.labelFinal_TIS = new System.Windows.Forms.Label();
            this.labelIntial_TIS = new System.Windows.Forms.Label();
            this.labelIntroduction_TIS = new System.Windows.Forms.Label();
            this.labelNumber_TIS = new System.Windows.Forms.Label();
            this.labelType_TIS = new System.Windows.Forms.Label();
            this.labelTransportsCount_TIS = new System.Windows.Forms.Label();
            this.графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransports_TIS)).BeginInit();
            this.groupBoxTransports_TIS.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.графикToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // dataGridViewTransports_TIS
            // 
            this.dataGridViewTransports_TIS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTransports_TIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransports_TIS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTransportType,
            this.ColumnRouteNumber,
            this.ColumnRouteIntroduction,
            this.ColumnInitialStop,
            this.ColumnFinalStop,
            this.ColumnRouteTime,
            this.ColumnNote});
            this.dataGridViewTransports_TIS.Location = new System.Drawing.Point(31, 38);
            this.dataGridViewTransports_TIS.Name = "dataGridViewTransports_TIS";
            this.dataGridViewTransports_TIS.RowHeadersWidth = 51;
            this.dataGridViewTransports_TIS.RowTemplate.Height = 24;
            this.dataGridViewTransports_TIS.Size = new System.Drawing.Size(997, 413);
            this.dataGridViewTransports_TIS.TabIndex = 1;
            this.dataGridViewTransports_TIS.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridViewTransports_TIS.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // ColumnTransportType
            // 
            this.ColumnTransportType.HeaderText = "Вид";
            this.ColumnTransportType.MinimumWidth = 6;
            this.ColumnTransportType.Name = "ColumnTransportType";
            this.ColumnTransportType.ReadOnly = true;
            this.ColumnTransportType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnTransportType.Width = 80;
            // 
            // ColumnRouteNumber
            // 
            this.ColumnRouteNumber.HeaderText = "Номер";
            this.ColumnRouteNumber.MinimumWidth = 6;
            this.ColumnRouteNumber.Name = "ColumnRouteNumber";
            this.ColumnRouteNumber.ReadOnly = true;
            this.ColumnRouteNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnRouteNumber.Width = 80;
            // 
            // ColumnRouteIntroduction
            // 
            this.ColumnRouteIntroduction.HeaderText = "Дата введения";
            this.ColumnRouteIntroduction.MinimumWidth = 6;
            this.ColumnRouteIntroduction.Name = "ColumnRouteIntroduction";
            this.ColumnRouteIntroduction.ReadOnly = true;
            this.ColumnRouteIntroduction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnRouteIntroduction.Width = 80;
            // 
            // ColumnInitialStop
            // 
            this.ColumnInitialStop.HeaderText = "Начальная остановка";
            this.ColumnInitialStop.MinimumWidth = 6;
            this.ColumnInitialStop.Name = "ColumnInitialStop";
            this.ColumnInitialStop.ReadOnly = true;
            this.ColumnInitialStop.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnInitialStop.Width = 125;
            // 
            // ColumnFinalStop
            // 
            this.ColumnFinalStop.HeaderText = "Конечная остановка";
            this.ColumnFinalStop.MinimumWidth = 6;
            this.ColumnFinalStop.Name = "ColumnFinalStop";
            this.ColumnFinalStop.ReadOnly = true;
            this.ColumnFinalStop.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnFinalStop.Width = 125;
            // 
            // ColumnRouteTime
            // 
            this.ColumnRouteTime.HeaderText = "Время в пути";
            this.ColumnRouteTime.MinimumWidth = 6;
            this.ColumnRouteTime.Name = "ColumnRouteTime";
            this.ColumnRouteTime.ReadOnly = true;
            this.ColumnRouteTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnRouteTime.Width = 80;
            // 
            // ColumnNote
            // 
            this.ColumnNote.HeaderText = "Примечание";
            this.ColumnNote.MinimumWidth = 6;
            this.ColumnNote.Name = "ColumnNote";
            this.ColumnNote.ReadOnly = true;
            this.ColumnNote.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNote.Width = 125;
            // 
            // comboBoxTransportType_TIS
            // 
            this.comboBoxTransportType_TIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransportType_TIS.FormattingEnabled = true;
            this.comboBoxTransportType_TIS.Items.AddRange(new object[] {
            "Автобус",
            "Маршрутка",
            "Трамвай",
            "Метро"});
            this.comboBoxTransportType_TIS.Location = new System.Drawing.Point(182, 64);
            this.comboBoxTransportType_TIS.Name = "comboBoxTransportType_TIS";
            this.comboBoxTransportType_TIS.Size = new System.Drawing.Size(165, 24);
            this.comboBoxTransportType_TIS.TabIndex = 2;
            // 
            // textBoxTransportNumber_TIS
            // 
            this.textBoxTransportNumber_TIS.Location = new System.Drawing.Point(182, 111);
            this.textBoxTransportNumber_TIS.MaxLength = 5;
            this.textBoxTransportNumber_TIS.Name = "textBoxTransportNumber_TIS";
            this.textBoxTransportNumber_TIS.Size = new System.Drawing.Size(165, 22);
            this.textBoxTransportNumber_TIS.TabIndex = 3;
            this.textBoxTransportNumber_TIS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTransportNumber_TIS_KeyPress);
            // 
            // dateTimePickerRouteIntroduction_TIS
            // 
            this.dateTimePickerRouteIntroduction_TIS.Location = new System.Drawing.Point(182, 160);
            this.dateTimePickerRouteIntroduction_TIS.Name = "dateTimePickerRouteIntroduction_TIS";
            this.dateTimePickerRouteIntroduction_TIS.Size = new System.Drawing.Size(165, 22);
            this.dateTimePickerRouteIntroduction_TIS.TabIndex = 4;
            // 
            // textBoxInitialStop_TIS
            // 
            this.textBoxInitialStop_TIS.Location = new System.Drawing.Point(182, 206);
            this.textBoxInitialStop_TIS.MaxLength = 50;
            this.textBoxInitialStop_TIS.Name = "textBoxInitialStop_TIS";
            this.textBoxInitialStop_TIS.Size = new System.Drawing.Size(165, 22);
            this.textBoxInitialStop_TIS.TabIndex = 5;
            // 
            // textBoxFinalStop_TIS
            // 
            this.textBoxFinalStop_TIS.Location = new System.Drawing.Point(182, 247);
            this.textBoxFinalStop_TIS.MaxLength = 50;
            this.textBoxFinalStop_TIS.Name = "textBoxFinalStop_TIS";
            this.textBoxFinalStop_TIS.Size = new System.Drawing.Size(165, 22);
            this.textBoxFinalStop_TIS.TabIndex = 6;
            // 
            // comboBoxRouteHours_TIS
            // 
            this.comboBoxRouteHours_TIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRouteHours_TIS.FormattingEnabled = true;
            this.comboBoxRouteHours_TIS.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxRouteHours_TIS.Location = new System.Drawing.Point(182, 288);
            this.comboBoxRouteHours_TIS.Name = "comboBoxRouteHours_TIS";
            this.comboBoxRouteHours_TIS.Size = new System.Drawing.Size(57, 24);
            this.comboBoxRouteHours_TIS.TabIndex = 7;
            // 
            // comboBoxRouteTimeMin_TIS
            // 
            this.comboBoxRouteTimeMin_TIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRouteTimeMin_TIS.FormattingEnabled = true;
            this.comboBoxRouteTimeMin_TIS.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxRouteTimeMin_TIS.Location = new System.Drawing.Point(245, 288);
            this.comboBoxRouteTimeMin_TIS.Name = "comboBoxRouteTimeMin_TIS";
            this.comboBoxRouteTimeMin_TIS.Size = new System.Drawing.Size(58, 24);
            this.comboBoxRouteTimeMin_TIS.TabIndex = 8;
            // 
            // textBoxNote_TIS
            // 
            this.textBoxNote_TIS.Location = new System.Drawing.Point(182, 333);
            this.textBoxNote_TIS.Name = "textBoxNote_TIS";
            this.textBoxNote_TIS.Size = new System.Drawing.Size(165, 22);
            this.textBoxNote_TIS.TabIndex = 9;
            // 
            // groupBoxTransports_TIS
            // 
            this.groupBoxTransports_TIS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTransports_TIS.Controls.Add(this.buttonSearch_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.buttonDeleteTransport_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.buttonEditTransport_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.buttonAddTransport_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.labelNote_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.labelTime_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.labelFinal_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.labelIntial_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.labelIntroduction_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.labelNumber_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.labelType_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.comboBoxTransportType_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.textBoxNote_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.textBoxTransportNumber_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.comboBoxRouteTimeMin_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.dateTimePickerRouteIntroduction_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.comboBoxRouteHours_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.textBoxInitialStop_TIS);
            this.groupBoxTransports_TIS.Controls.Add(this.textBoxFinalStop_TIS);
            this.groupBoxTransports_TIS.Location = new System.Drawing.Point(1034, 57);
            this.groupBoxTransports_TIS.Name = "groupBoxTransports_TIS";
            this.groupBoxTransports_TIS.Size = new System.Drawing.Size(495, 394);
            this.groupBoxTransports_TIS.TabIndex = 10;
            this.groupBoxTransports_TIS.TabStop = false;
            // 
            // buttonSearch_TIS
            // 
            this.buttonSearch_TIS.Location = new System.Drawing.Point(365, 205);
            this.buttonSearch_TIS.Name = "buttonSearch_TIS";
            this.buttonSearch_TIS.Size = new System.Drawing.Size(119, 23);
            this.buttonSearch_TIS.TabIndex = 21;
            this.buttonSearch_TIS.Text = "Поиск";
            this.buttonSearch_TIS.UseVisualStyleBackColor = true;
            this.buttonSearch_TIS.Click += new System.EventHandler(this.buttonSearch_TIS_Click);
            // 
            // buttonDeleteTransport_TIS
            // 
            this.buttonDeleteTransport_TIS.Location = new System.Drawing.Point(365, 159);
            this.buttonDeleteTransport_TIS.Name = "buttonDeleteTransport_TIS";
            this.buttonDeleteTransport_TIS.Size = new System.Drawing.Size(119, 23);
            this.buttonDeleteTransport_TIS.TabIndex = 20;
            this.buttonDeleteTransport_TIS.Text = "Удалить";
            this.buttonDeleteTransport_TIS.UseVisualStyleBackColor = true;
            this.buttonDeleteTransport_TIS.Click += new System.EventHandler(this.buttonDeleteTransport_TIS_Click);
            // 
            // buttonEditTransport_TIS
            // 
            this.buttonEditTransport_TIS.Location = new System.Drawing.Point(365, 109);
            this.buttonEditTransport_TIS.Name = "buttonEditTransport_TIS";
            this.buttonEditTransport_TIS.Size = new System.Drawing.Size(120, 23);
            this.buttonEditTransport_TIS.TabIndex = 18;
            this.buttonEditTransport_TIS.Text = "Редактировать";
            this.buttonEditTransport_TIS.UseVisualStyleBackColor = true;
            this.buttonEditTransport_TIS.Click += new System.EventHandler(this.buttonEditTransport_TIS_Click);
            // 
            // buttonAddTransport_TIS
            // 
            this.buttonAddTransport_TIS.Location = new System.Drawing.Point(364, 60);
            this.buttonAddTransport_TIS.Name = "buttonAddTransport_TIS";
            this.buttonAddTransport_TIS.Size = new System.Drawing.Size(120, 23);
            this.buttonAddTransport_TIS.TabIndex = 17;
            this.buttonAddTransport_TIS.Text = "Добавить";
            this.buttonAddTransport_TIS.UseVisualStyleBackColor = true;
            this.buttonAddTransport_TIS.Click += new System.EventHandler(this.buttonAddTransport_TIS_Click);
            // 
            // labelNote_TIS
            // 
            this.labelNote_TIS.AutoSize = true;
            this.labelNote_TIS.Location = new System.Drawing.Point(19, 333);
            this.labelNote_TIS.Name = "labelNote_TIS";
            this.labelNote_TIS.Size = new System.Drawing.Size(90, 16);
            this.labelNote_TIS.TabIndex = 16;
            this.labelNote_TIS.Text = "Примечание";
            // 
            // labelTime_TIS
            // 
            this.labelTime_TIS.AutoSize = true;
            this.labelTime_TIS.Location = new System.Drawing.Point(19, 288);
            this.labelTime_TIS.Name = "labelTime_TIS";
            this.labelTime_TIS.Size = new System.Drawing.Size(93, 16);
            this.labelTime_TIS.TabIndex = 15;
            this.labelTime_TIS.Text = "Время в пути";
            // 
            // labelFinal_TIS
            // 
            this.labelFinal_TIS.AutoSize = true;
            this.labelFinal_TIS.Location = new System.Drawing.Point(19, 247);
            this.labelFinal_TIS.Name = "labelFinal_TIS";
            this.labelFinal_TIS.Size = new System.Drawing.Size(142, 16);
            this.labelFinal_TIS.TabIndex = 14;
            this.labelFinal_TIS.Text = "Конечная остановка";
            // 
            // labelIntial_TIS
            // 
            this.labelIntial_TIS.AutoSize = true;
            this.labelIntial_TIS.Location = new System.Drawing.Point(19, 212);
            this.labelIntial_TIS.Name = "labelIntial_TIS";
            this.labelIntial_TIS.Size = new System.Drawing.Size(151, 16);
            this.labelIntial_TIS.TabIndex = 13;
            this.labelIntial_TIS.Text = "Начальная остановка";
            // 
            // labelIntroduction_TIS
            // 
            this.labelIntroduction_TIS.AutoSize = true;
            this.labelIntroduction_TIS.Location = new System.Drawing.Point(19, 166);
            this.labelIntroduction_TIS.Name = "labelIntroduction_TIS";
            this.labelIntroduction_TIS.Size = new System.Drawing.Size(105, 16);
            this.labelIntroduction_TIS.TabIndex = 12;
            this.labelIntroduction_TIS.Text = "Дата введения";
            // 
            // labelNumber_TIS
            // 
            this.labelNumber_TIS.AutoSize = true;
            this.labelNumber_TIS.Location = new System.Drawing.Point(19, 117);
            this.labelNumber_TIS.Name = "labelNumber_TIS";
            this.labelNumber_TIS.Size = new System.Drawing.Size(50, 16);
            this.labelNumber_TIS.TabIndex = 11;
            this.labelNumber_TIS.Text = "Номер";
            // 
            // labelType_TIS
            // 
            this.labelType_TIS.AutoSize = true;
            this.labelType_TIS.Location = new System.Drawing.Point(19, 67);
            this.labelType_TIS.Name = "labelType_TIS";
            this.labelType_TIS.Size = new System.Drawing.Size(32, 16);
            this.labelType_TIS.TabIndex = 10;
            this.labelType_TIS.Text = "Тип";
            // 
            // labelTransportsCount_TIS
            // 
            this.labelTransportsCount_TIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTransportsCount_TIS.AutoSize = true;
            this.labelTransportsCount_TIS.Location = new System.Drawing.Point(1031, 38);
            this.labelTransportsCount_TIS.Name = "labelTransportsCount_TIS";
            this.labelTransportsCount_TIS.Size = new System.Drawing.Size(85, 16);
            this.labelTransportsCount_TIS.TabIndex = 12;
            this.labelTransportsCount_TIS.Text = "Количество";
            // 
            // графикToolStripMenuItem
            // 
            this.графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            this.графикToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.графикToolStripMenuItem.Text = "График";
            this.графикToolStripMenuItem.Click += new System.EventHandler(this.графикToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 510);
            this.Controls.Add(this.labelTransportsCount_TIS);
            this.Controls.Add(this.groupBoxTransports_TIS);
            this.Controls.Add(this.dataGridViewTransports_TIS);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Городской транспорт";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransports_TIS)).EndInit();
            this.groupBoxTransports_TIS.ResumeLayout(false);
            this.groupBoxTransports_TIS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewTransports_TIS;
        private System.Windows.Forms.ComboBox comboBoxTransportType_TIS;
        private System.Windows.Forms.TextBox textBoxTransportNumber_TIS;
        private System.Windows.Forms.DateTimePicker dateTimePickerRouteIntroduction_TIS;
        private System.Windows.Forms.TextBox textBoxInitialStop_TIS;
        private System.Windows.Forms.TextBox textBoxFinalStop_TIS;
        private System.Windows.Forms.ComboBox comboBoxRouteHours_TIS;
        private System.Windows.Forms.ComboBox comboBoxRouteTimeMin_TIS;
        private System.Windows.Forms.TextBox textBoxNote_TIS;
        private System.Windows.Forms.GroupBox groupBoxTransports_TIS;
        private System.Windows.Forms.Label labelNumber_TIS;
        private System.Windows.Forms.Label labelType_TIS;
        private System.Windows.Forms.Label labelIntroduction_TIS;
        private System.Windows.Forms.Label labelFinal_TIS;
        private System.Windows.Forms.Label labelIntial_TIS;
        private System.Windows.Forms.Button buttonEditTransport_TIS;
        private System.Windows.Forms.Button buttonAddTransport_TIS;
        private System.Windows.Forms.Label labelNote_TIS;
        private System.Windows.Forms.Label labelTime_TIS;
        private System.Windows.Forms.Label labelTransportsCount_TIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTransportType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRouteNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRouteIntroduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInitialStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFinalStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRouteTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNote;
        private System.Windows.Forms.Button buttonDeleteTransport_TIS;
        private System.Windows.Forms.Button buttonSearch_TIS;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
    }
}

