namespace Tyuiu.TopychkanovIS.Task1.V14
{
    partial class InfoForm
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
            this.labelName_TIS = new System.Windows.Forms.Label();
            this.labelFrstDescription_TIS = new System.Windows.Forms.Label();
            this.labelScndDescription_TIS = new System.Windows.Forms.Label();
            this.flowLayoutPanelDescription_TIS = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelDescription_TIS.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName_TIS
            // 
            this.labelName_TIS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName_TIS.AutoSize = true;
            this.labelName_TIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_TIS.Location = new System.Drawing.Point(209, 9);
            this.labelName_TIS.Name = "labelName_TIS";
            this.labelName_TIS.Size = new System.Drawing.Size(362, 38);
            this.labelName_TIS.TabIndex = 0;
            this.labelName_TIS.Text = "Городской транспорт";
            // 
            // labelFrstDescription_TIS
            // 
            this.labelFrstDescription_TIS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFrstDescription_TIS.AutoSize = true;
            this.labelFrstDescription_TIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrstDescription_TIS.Location = new System.Drawing.Point(33, 68);
            this.labelFrstDescription_TIS.Name = "labelFrstDescription_TIS";
            this.labelFrstDescription_TIS.Size = new System.Drawing.Size(669, 25);
            this.labelFrstDescription_TIS.TabIndex = 1;
            this.labelFrstDescription_TIS.Text = "Данная программа предназначена для учета городского транспорта. ";
            // 
            // labelScndDescription_TIS
            // 
            this.labelScndDescription_TIS.AutoSize = true;
            this.labelScndDescription_TIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelScndDescription_TIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScndDescription_TIS.Location = new System.Drawing.Point(3, 0);
            this.labelScndDescription_TIS.MaximumSize = new System.Drawing.Size(0, 750);
            this.labelScndDescription_TIS.Name = "labelScndDescription_TIS";
            this.labelScndDescription_TIS.Size = new System.Drawing.Size(757, 58);
            this.labelScndDescription_TIS.TabIndex = 2;
            this.labelScndDescription_TIS.Text = "В программе реализован функционал добавления, изменения и удаления данных. Данные" +
    " хранятся в csv файле.";
            // 
            // flowLayoutPanelDescription_TIS
            // 
            this.flowLayoutPanelDescription_TIS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelDescription_TIS.Controls.Add(this.labelScndDescription_TIS);
            this.flowLayoutPanelDescription_TIS.Location = new System.Drawing.Point(17, 172);
            this.flowLayoutPanelDescription_TIS.Name = "flowLayoutPanelDescription_TIS";
            this.flowLayoutPanelDescription_TIS.Size = new System.Drawing.Size(771, 100);
            this.flowLayoutPanelDescription_TIS.TabIndex = 3;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelDescription_TIS);
            this.Controls.Add(this.labelFrstDescription_TIS);
            this.Controls.Add(this.labelName_TIS);
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.flowLayoutPanelDescription_TIS.ResumeLayout(false);
            this.flowLayoutPanelDescription_TIS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName_TIS;
        private System.Windows.Forms.Label labelFrstDescription_TIS;
        private System.Windows.Forms.Label labelScndDescription_TIS;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDescription_TIS;
    }
}