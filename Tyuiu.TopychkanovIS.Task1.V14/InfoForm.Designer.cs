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
            this.labelVersion_TIS = new System.Windows.Forms.Label();
            this.labelDeveloper_TIS = new System.Windows.Forms.Label();
            this.labelContact_TIS = new System.Windows.Forms.Label();
            this.textBoxDescription_TIS = new System.Windows.Forms.TextBox();
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
            this.labelName_TIS.Size = new System.Drawing.Size(302, 31);
            this.labelName_TIS.TabIndex = 0;
            this.labelName_TIS.Text = "Городской транспорт";
            // 
            // labelVersion_TIS
            // 
            this.labelVersion_TIS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion_TIS.AutoSize = true;
            this.labelVersion_TIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersion_TIS.Location = new System.Drawing.Point(33, 68);
            this.labelVersion_TIS.Name = "labelVersion_TIS";
            this.labelVersion_TIS.Size = new System.Drawing.Size(547, 20);
            this.labelVersion_TIS.TabIndex = 1;
            this.labelVersion_TIS.Text = "Данная программа предназначена для учета городского транспорта. ";
            // 
            // labelDeveloper_TIS
            // 
            this.labelDeveloper_TIS.AutoSize = true;
            this.labelDeveloper_TIS.Location = new System.Drawing.Point(256, 174);
            this.labelDeveloper_TIS.Name = "labelDeveloper_TIS";
            this.labelDeveloper_TIS.Size = new System.Drawing.Size(44, 16);
            this.labelDeveloper_TIS.TabIndex = 2;
            this.labelDeveloper_TIS.Text = "label1";
            // 
            // labelContact_TIS
            // 
            this.labelContact_TIS.AutoSize = true;
            this.labelContact_TIS.Location = new System.Drawing.Point(230, 245);
            this.labelContact_TIS.Name = "labelContact_TIS";
            this.labelContact_TIS.Size = new System.Drawing.Size(44, 16);
            this.labelContact_TIS.TabIndex = 2;
            this.labelContact_TIS.Text = "label1";
            // 
            // textBoxDescription_TIS
            // 
            this.textBoxDescription_TIS.Location = new System.Drawing.Point(199, 336);
            this.textBoxDescription_TIS.Name = "textBoxDescription_TIS";
            this.textBoxDescription_TIS.Size = new System.Drawing.Size(100, 22);
            this.textBoxDescription_TIS.TabIndex = 3;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDescription_TIS);
            this.Controls.Add(this.labelContact_TIS);
            this.Controls.Add(this.labelDeveloper_TIS);
            this.Controls.Add(this.labelVersion_TIS);
            this.Controls.Add(this.labelName_TIS);
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName_TIS;
        private System.Windows.Forms.Label labelVersion_TIS;
        private System.Windows.Forms.Label labelDeveloper_TIS;
        private System.Windows.Forms.Label labelContact_TIS;
        private System.Windows.Forms.TextBox textBoxDescription_TIS;
    }
}