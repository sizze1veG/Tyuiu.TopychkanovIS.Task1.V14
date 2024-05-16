using System;
using System.Windows.Forms;

namespace Tyuiu.TopychkanovIS.Task1.V14
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            this.ActiveControl = null;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 400);
            

            labelName_TIS.Location = new System.Drawing.Point(50, 20);
            labelName_TIS.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            labelName_TIS.AutoSize = true;

            labelVersion_TIS.Location = new System.Drawing.Point(50, 60);
            labelVersion_TIS.AutoSize = true;

            labelDeveloper_TIS.Location = new System.Drawing.Point(50, 90);
            labelDeveloper_TIS.AutoSize = true;

            labelContact_TIS.Location = new System.Drawing.Point(50, 120);
            labelContact_TIS.AutoSize = true;

            textBoxDescription_TIS.Location = new System.Drawing.Point(50, 200);
            textBoxDescription_TIS.Size = new System.Drawing.Size(300, 200);
            textBoxDescription_TIS.Multiline = true;
            textBoxDescription_TIS.ReadOnly = true;
            textBoxDescription_TIS.BorderStyle = BorderStyle.None;
            textBoxDescription_TIS.BackColor = System.Drawing.Color.White;

            labelName_TIS.Text = "Городской Транспортный Менеджер";
            labelVersion_TIS.Text = "Версия: 1.0";
            labelDeveloper_TIS.Text = "Разработчик: Топычканов Иван Сергеевич";
            labelContact_TIS.Text = "Контактная информация:\n- Электронная почта: vanotopych@mail.ru\n- Телефон: +79834041717";
            textBoxDescription_TIS.Text = "Городской Транспортный Менеджер - это приложение для удобного управления данными о городском транспорте. Оно предоставляет возможность ввода, редактирования, поиска, сортировки и фильтрации информации о различных видах транспорта, маршрутах, остановках и других связанных данных. Приложение оснащено графическим интерфейсом, который позволяет пользователям легко взаимодействовать с данными и управлять ими.";

            this.Controls.Add(labelName_TIS);
            this.Controls.Add(labelVersion_TIS);
            this.Controls.Add(labelDeveloper_TIS);
            this.Controls.Add(labelContact_TIS);
            this.Controls.Add(textBoxDescription_TIS);
        }
    }
}
