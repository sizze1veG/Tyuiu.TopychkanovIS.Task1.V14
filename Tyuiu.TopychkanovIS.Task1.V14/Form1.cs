using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tyuiu.TopychkanovIS.Task1.V14
{
    public partial class Form1 : Form
    {
        List<Transport> transports = new List<Transport>();

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

                    transports.Add(transport);

                    dataGridViewTransports_TIS.Rows.Add(comboBoxTransportType_TIS.Text, transport.RouteNumber,
                        transport.RouteIntroductionDate.ToString($"d"),
                        transport.InitialStop, transport.FinalStop, 
                        transport.RouteTime.ToString($"t"), transport.Note);

                    labelTransportsCount_TIS.Text = "Количество: " + transports.Count.ToString();

                    CleareAllFields();

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
            buttonAddTransport_TIS.Enabled = false;
            buttonEditTransport_TIS.Enabled = false;
            buttonDeleteTransport_TIS.Enabled = false;

            if (!File.Exists("Data.csv"))
            {
                using (FileStream fs = File.Create("Data.csv"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("");
                }
            }

            List<string[]> lines = File.ReadAllLines("Data.csv", Encoding.GetEncoding(1251)).Select(x => x.Split(' ')).ToList();
            foreach (var line in lines)
            {
                #region Get transport type

                TransportType type;
                if (line[0] == "Автобус")
                    type = TransportType.Bus;
                else if (line[0] == "Маршрутка")
                    type = TransportType.Shuttle;
                else if (line[0] == "Трамвай")
                    type = TransportType.Streetcar;
                else
                    type = TransportType.Subway;

                #endregion

                Transport transport = new Transport(type, Convert.ToInt32(line[1]),
                    Convert.ToDateTime(line[2]),line[3], line[4], 
                    Convert.ToDateTime(line[5]), line[6]);

                transports.Add(transport);
                dataGridViewTransports_TIS.Rows.Add(line[0], line[1], line[2], line[3], line[4], line[5], line[6]);
            }

            labelTransportsCount_TIS.Text = "Количество: " + transports.Count.ToString();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransports_TIS.CurrentRow.Index == dataGridViewTransports_TIS.Rows.Count - 1)
            {
                buttonAddTransport_TIS.Enabled = true;
                buttonEditTransport_TIS.Enabled = false;
                buttonDeleteTransport_TIS.Enabled = false;

                CleareAllFields();
            }
            else
            {
                buttonAddTransport_TIS.Enabled = false;
                buttonEditTransport_TIS.Enabled = true;
                buttonDeleteTransport_TIS.Enabled = true;

                #region Get transport type

                int selectIndex = -1;
                if (dataGridViewTransports_TIS.CurrentRow.Cells[0].Value.ToString() == "Автобус")
                    selectIndex = 0;
                else if (dataGridViewTransports_TIS.CurrentRow.Cells[0].Value.ToString() == "Маршрутка")
                    selectIndex = 1;
                else if (dataGridViewTransports_TIS.CurrentRow.Cells[0].Value.ToString() == "Трамвай")
                    selectIndex = 2;
                else
                    selectIndex = 3;

                #endregion

                #region Enter fields

                comboBoxTransportType_TIS.SelectedIndex = selectIndex;
                textBoxTransportNumber_TIS.Text = dataGridViewTransports_TIS.CurrentRow.Cells[1].Value.ToString();
                dateTimePickerRouteIntroduction_TIS.Value = Convert.ToDateTime(dataGridViewTransports_TIS.CurrentRow.Cells[2].Value);
                textBoxInitialStop_TIS.Text = dataGridViewTransports_TIS.CurrentRow.Cells[3].Value.ToString();
                textBoxFinalStop_TIS.Text = dataGridViewTransports_TIS.CurrentRow.Cells[4].Value.ToString();
                var time = dataGridViewTransports_TIS.CurrentRow.Cells[5].Value.ToString().Split(':');
                comboBoxRouteHours_TIS.SelectedIndex = Convert.ToInt32(time[0]) - 1;
                comboBoxRouteTimeMin_TIS.SelectedIndex = Convert.ToInt32(time[1]);
                textBoxNote_TIS.Text = dataGridViewTransports_TIS.CurrentRow.Cells[6].Value.ToString();

                #endregion
            }
        }

        private void buttonEditTransport_TIS_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckComboBox(comboBoxTransportType_TIS) && CheckTextBoxTransportNumber()
                && CheckDateRouteIntroduction() && CheckTransportStop(textBoxInitialStop_TIS)
                && CheckTransportStop(textBoxFinalStop_TIS) && CheckComboBox(comboBoxRouteHours_TIS)
                && CheckComboBox(comboBoxRouteTimeMin_TIS))
                {
                    #region Remove transport

                    TransportType type;
                    if (dataGridViewTransports_TIS.CurrentRow.Cells[0].Value.ToString() == "Автобус")
                        type = TransportType.Bus;
                    else if (dataGridViewTransports_TIS.CurrentRow.Cells[0].Value.ToString() == "Маршрутка")
                        type = TransportType.Shuttle;
                    else if (dataGridViewTransports_TIS.CurrentRow.Cells[0].Value.ToString() == "Трамвай")
                        type = TransportType.Streetcar;
                    else
                        type = TransportType.Subway;

                    Transport transportToEdit = new Transport(type, Convert.ToInt32(dataGridViewTransports_TIS.CurrentRow.Cells[1].Value),
                        Convert.ToDateTime(dataGridViewTransports_TIS.CurrentRow.Cells[2].Value), dataGridViewTransports_TIS.CurrentRow.Cells[3].Value.ToString(),
                        dataGridViewTransports_TIS.CurrentRow.Cells[4].Value.ToString(), Convert.ToDateTime(dataGridViewTransports_TIS.CurrentRow.Cells[5].Value),
                        dataGridViewTransports_TIS.CurrentRow.Cells[6].Value.ToString());

                    for (int i = 0; i < transports.Count; i++)
                    {
                        if (transports[i].CompareTo(transportToEdit))
                        {
                            transports.RemoveAt(i);
                            break;
                        }
                    }

                    #endregion

                    #region Get transport type

                    if (comboBoxTransportType_TIS.Text == "Автобус")
                        type = TransportType.Bus;
                    else if (comboBoxTransportType_TIS.Text == "Маршрутка")
                        type = TransportType.Shuttle;
                    else if (comboBoxTransportType_TIS.Text == "Трамвай")
                        type = TransportType.Streetcar;
                    else
                        type = TransportType.Subway;

                    #endregion

                    DateTime routeTime = new DateTime(1, 1, 1, Convert.ToInt32(comboBoxRouteHours_TIS.Text), Convert.ToInt32(comboBoxRouteTimeMin_TIS.Text), 0);

                    Transport transport = new Transport(type, Convert.ToInt32(textBoxTransportNumber_TIS.Text),
                        Convert.ToDateTime(dateTimePickerRouteIntroduction_TIS.Value),
                        textBoxInitialStop_TIS.Text, textBoxFinalStop_TIS.Text, routeTime, textBoxNote_TIS.Text);

                    transports.Add(transport);

                    using (var streamWriter = new StreamWriter(@"Data.csv", false, Encoding.GetEncoding(1251)))
                    {
                        foreach (var tr in transports)
                        {
                            streamWriter.WriteLine(tr.ToString());
                        }
                    }

                    dataGridViewTransports_TIS.CurrentRow.Cells[0].Value = comboBoxTransportType_TIS.Text;
                    dataGridViewTransports_TIS.CurrentRow.Cells[1].Value = transport.RouteNumber;
                    dataGridViewTransports_TIS.CurrentRow.Cells[2].Value = transport.RouteIntroductionDate.ToString($"d");
                    dataGridViewTransports_TIS.CurrentRow.Cells[3].Value = transport.InitialStop;
                    dataGridViewTransports_TIS.CurrentRow.Cells[4].Value = transport.FinalStop;
                    dataGridViewTransports_TIS.CurrentRow.Cells[5].Value = transport.RouteTime.ToString($"t");
                    dataGridViewTransports_TIS.CurrentRow.Cells[6].Value = transport.Note;

                    CleareAllFields();

                    buttonDeleteTransport_TIS.Enabled = false;
                    buttonEditTransport_TIS.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridViewTransports_TIS.Rows.Count == 1)
            {
                buttonDeleteTransport_TIS.Enabled = false;
                buttonEditTransport_TIS.Enabled = false;
            }
        }

        private void buttonDeleteTransport_TIS_Click(object sender, EventArgs e)
        {
            try
            {
                #region Get transport type

                TransportType type;
                if (dataGridViewTransports_TIS.CurrentRow.Cells[0].Value.ToString() == "Автобус")
                    type = TransportType.Bus;
                else if (dataGridViewTransports_TIS.CurrentRow.Cells[0].Value.ToString() == "Маршрутка")
                    type = TransportType.Shuttle;
                else if (dataGridViewTransports_TIS.CurrentRow.Cells[0].Value.ToString() == "Трамвай")
                    type = TransportType.Streetcar;
                else
                    type = TransportType.Subway;

                #endregion

                Transport transport = new Transport(type, Convert.ToInt32(dataGridViewTransports_TIS.CurrentRow.Cells[1].Value),
                    Convert.ToDateTime(dataGridViewTransports_TIS.CurrentRow.Cells[2].Value), dataGridViewTransports_TIS.CurrentRow.Cells[3].Value.ToString(),
                    dataGridViewTransports_TIS.CurrentRow.Cells[4].Value.ToString(), Convert.ToDateTime(dataGridViewTransports_TIS.CurrentRow.Cells[5].Value),
                    dataGridViewTransports_TIS.CurrentRow.Cells[6].Value.ToString());

                for (int i = 0; i < transports.Count; i++)
                {
                    if (transports[i].CompareTo(transport))
                    {
                        transports.RemoveAt(i);
                        break;
                    }
                }

                dataGridViewTransports_TIS.Rows.RemoveAt(dataGridViewTransports_TIS.CurrentRow.Index);

                using (var streamWriter = new StreamWriter(@"Data.csv", false, Encoding.GetEncoding(1251)))
                {
                    foreach (var tr in transports)
                    {
                        streamWriter.WriteLine(tr.ToString());
                    }
                }

                CleareAllFields();

                buttonAddTransport_TIS.Enabled = false;
                buttonEditTransport_TIS.Enabled = false;
                buttonDeleteTransport_TIS.Enabled = false;

                labelTransportsCount_TIS.Text = "Количество: " + transports.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void CleareAllFields()
        {
            comboBoxTransportType_TIS.SelectedIndex = -1;
            textBoxTransportNumber_TIS.Clear();
            dateTimePickerRouteIntroduction_TIS.Value = DateTime.Now;
            textBoxInitialStop_TIS.Clear();
            textBoxFinalStop_TIS.Clear();
            comboBoxRouteHours_TIS.SelectedIndex = -1;
            comboBoxRouteTimeMin_TIS.SelectedIndex = -1;
            textBoxNote_TIS.Clear();
        }

        private void buttonSearch_TIS_Click(object sender, EventArgs e)
        {
            Form searchForm = new SearchForm(transports);
            searchForm.ShowDialog();
        }
    }
}
