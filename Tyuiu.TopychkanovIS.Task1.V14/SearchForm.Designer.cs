namespace Tyuiu.TopychkanovIS.Task1.V14
{
    partial class SearchForm
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
            this.dataGridViewTransports_TIS = new System.Windows.Forms.DataGridView();
            this.ColumnTransportType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRouteNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRouteIntroduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInitialStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFinalStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRouteTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelType_TIS = new System.Windows.Forms.Label();
            this.comboBoxTransportType_TIS = new System.Windows.Forms.ComboBox();
            this.groupBoxSearch_TIS = new System.Windows.Forms.GroupBox();
            this.labelTransportNumber_TIS = new System.Windows.Forms.Label();
            this.textBoxTransportNumber_TIS = new System.Windows.Forms.TextBox();
            this.buttonNumberSearch_TIS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransports_TIS)).BeginInit();
            this.groupBoxSearch_TIS.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridViewTransports_TIS.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTransports_TIS.Name = "dataGridViewTransports_TIS";
            this.dataGridViewTransports_TIS.RowHeadersWidth = 51;
            this.dataGridViewTransports_TIS.RowTemplate.Height = 24;
            this.dataGridViewTransports_TIS.Size = new System.Drawing.Size(997, 413);
            this.dataGridViewTransports_TIS.TabIndex = 2;
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
            // labelType_TIS
            // 
            this.labelType_TIS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelType_TIS.AutoSize = true;
            this.labelType_TIS.Location = new System.Drawing.Point(1045, 21);
            this.labelType_TIS.Name = "labelType_TIS";
            this.labelType_TIS.Size = new System.Drawing.Size(32, 16);
            this.labelType_TIS.TabIndex = 12;
            this.labelType_TIS.Text = "Тип";
            // 
            // comboBoxTransportType_TIS
            // 
            this.comboBoxTransportType_TIS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTransportType_TIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransportType_TIS.FormattingEnabled = true;
            this.comboBoxTransportType_TIS.Items.AddRange(new object[] {
            "Автобус",
            "Маршрутка",
            "Трамвай",
            "Метро"});
            this.comboBoxTransportType_TIS.Location = new System.Drawing.Point(1083, 18);
            this.comboBoxTransportType_TIS.Name = "comboBoxTransportType_TIS";
            this.comboBoxTransportType_TIS.Size = new System.Drawing.Size(165, 24);
            this.comboBoxTransportType_TIS.TabIndex = 11;
            this.comboBoxTransportType_TIS.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransportType_TIS_SelectedIndexChanged);
            // 
            // groupBoxSearch_TIS
            // 
            this.groupBoxSearch_TIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch_TIS.Controls.Add(this.buttonNumberSearch_TIS);
            this.groupBoxSearch_TIS.Controls.Add(this.textBoxTransportNumber_TIS);
            this.groupBoxSearch_TIS.Controls.Add(this.labelTransportNumber_TIS);
            this.groupBoxSearch_TIS.Location = new System.Drawing.Point(1048, 292);
            this.groupBoxSearch_TIS.Name = "groupBoxSearch_TIS";
            this.groupBoxSearch_TIS.Size = new System.Drawing.Size(255, 133);
            this.groupBoxSearch_TIS.TabIndex = 13;
            this.groupBoxSearch_TIS.TabStop = false;
            // 
            // labelTransportNumber_TIS
            // 
            this.labelTransportNumber_TIS.AutoSize = true;
            this.labelTransportNumber_TIS.Location = new System.Drawing.Point(6, 28);
            this.labelTransportNumber_TIS.Name = "labelTransportNumber_TIS";
            this.labelTransportNumber_TIS.Size = new System.Drawing.Size(50, 16);
            this.labelTransportNumber_TIS.TabIndex = 0;
            this.labelTransportNumber_TIS.Text = "Номер";
            // 
            // textBoxTransportNumber_TIS
            // 
            this.textBoxTransportNumber_TIS.Location = new System.Drawing.Point(100, 28);
            this.textBoxTransportNumber_TIS.MaxLength = 5;
            this.textBoxTransportNumber_TIS.Name = "textBoxTransportNumber_TIS";
            this.textBoxTransportNumber_TIS.Size = new System.Drawing.Size(100, 22);
            this.textBoxTransportNumber_TIS.TabIndex = 1;
            this.textBoxTransportNumber_TIS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTransportNumber_TIS_KeyPress);
            // 
            // buttonNumberSearch_TIS
            // 
            this.buttonNumberSearch_TIS.Location = new System.Drawing.Point(100, 91);
            this.buttonNumberSearch_TIS.Name = "buttonNumberSearch_TIS";
            this.buttonNumberSearch_TIS.Size = new System.Drawing.Size(100, 23);
            this.buttonNumberSearch_TIS.TabIndex = 2;
            this.buttonNumberSearch_TIS.Text = "Поиск";
            this.buttonNumberSearch_TIS.UseVisualStyleBackColor = true;
            this.buttonNumberSearch_TIS.Click += new System.EventHandler(this.buttonNumberSearch_TIS_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 548);
            this.Controls.Add(this.groupBoxSearch_TIS);
            this.Controls.Add(this.labelType_TIS);
            this.Controls.Add(this.comboBoxTransportType_TIS);
            this.Controls.Add(this.dataGridViewTransports_TIS);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransports_TIS)).EndInit();
            this.groupBoxSearch_TIS.ResumeLayout(false);
            this.groupBoxSearch_TIS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTransports_TIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTransportType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRouteNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRouteIntroduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInitialStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFinalStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRouteTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNote;
        private System.Windows.Forms.Label labelType_TIS;
        private System.Windows.Forms.ComboBox comboBoxTransportType_TIS;
        private System.Windows.Forms.GroupBox groupBoxSearch_TIS;
        private System.Windows.Forms.TextBox textBoxTransportNumber_TIS;
        private System.Windows.Forms.Label labelTransportNumber_TIS;
        private System.Windows.Forms.Button buttonNumberSearch_TIS;
    }
}