using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;

namespace Tyuiu.TopychkanovIS.Task1.V14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddTransport_TIS_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckComboBox(comboBoxTransportType_TIS) && CheckTextBoxTransportNumber()
                && CheckDateRouteIntroduction() && CheckTransportStop(textBoxInitialStop_TIS)
                && CheckTransportStop(textBoxFinalStop_TIS) && CheckComboBox(comboBoxRouteHours_TIS)
                && CheckComboBox(comboBoxRouteTimeMin_TIS))
                {

                    #region Get transport type

                    TransportType type;
                    if (comboBoxTransportType_TIS.Text == "Автобус")
                        type = TransportType.Bus;
                    else if (comboBoxTransportType_TIS.Text == "Маршрутка")
                        type = TransportType.Shuttle;
                    else if (comboBoxTransportType_TIS.Text == "Трамвай")
                        type = TransportType.Streetcar;
                    else
                        type = TransportType.Subway;

                    #endregion

                    DateTime routeTime = new DateTime(1,1, 1, Convert.ToInt32(comboBoxRouteHours_TIS.Text), Convert.ToInt32(comboBoxRouteTimeMin_TIS.Text), 0);

                    Transport transport = new Transport(type, Convert.ToInt32(textBoxTransportNumber_TIS.Text), 
                        Convert.ToDateTime(dateTimePickerRouteIntroduction_TIS.Value), 
                        textBoxInitialStop_TIS.Text, textBoxFinalStop_TIS.Text, routeTime, textBoxNote_TIS.Text);

                    using (var streamWriter = new StreamWriter(@"Data.csv", true, Encoding.GetEncoding(1251)))
                    {
                        streamWriter.WriteLine(transport.ToString());
                    }

                    dataGridView1.Rows.Add(comboBoxTransportType_TIS.Text, transport.RouteNumber,
                        transport.RouteIntroductionDate.ToString($"d"),
                        transport.InitialStop, transport.FinalStop, 
                        transport.RouteTime.ToString($"t"), transport.Note);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        #region Check input data

        private bool CheckComboBox(ComboBox comboBox) => comboBox.SelectedIndex != -1;

        private bool CheckTextBoxTransportNumber() => textBoxTransportNumber_TIS.Text.Length != 0;

        private bool CheckDateRouteIntroduction() => dateTimePickerRouteIntroduction_TIS.Value < DateTime.Now;

        private bool CheckTransportStop(TextBox textBoxStop) => textBoxStop.Text.Length != 0;

        private void textBoxTransportNumber_TIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
