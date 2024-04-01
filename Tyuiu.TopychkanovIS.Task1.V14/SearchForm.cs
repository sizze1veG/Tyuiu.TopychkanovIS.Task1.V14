using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.TopychkanovIS.Task1.V14
{
    public partial class SearchForm : Form
    {
        List<Transport> transports = new List<Transport>();
        public SearchForm(List<Transport> transports)
        {
            InitializeComponent();
            this.transports = transports;
        }

        private void comboBoxTransportType_TIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = comboBoxTransportType_TIS.SelectedIndex;
            switch (selected)
            {
                case 0:
                    dataGridViewTransports_TIS.Rows.Clear();
                    foreach (var item in transports)
                    {
                        if (item.Type == TransportType.Bus)
                        {
                            dataGridViewTransports_TIS.Rows.Add(item.ToString().Split(' '));
                        }
                    }
                    break;
                case 1:
                    dataGridViewTransports_TIS.Rows.Clear();
                    foreach (var item in transports)
                    {
                        if (item.Type == TransportType.Shuttle)
                        {
                            dataGridViewTransports_TIS.Rows.Add(item.ToString().Split(' '));
                        }
                    }
                    break;
                case 2:
                    dataGridViewTransports_TIS.Rows.Clear();
                    foreach (var item in transports)
                    {
                        if (item.Type == TransportType.Streetcar)
                        {
                            dataGridViewTransports_TIS.Rows.Add(item.ToString().Split(' '));
                        }
                    }
                    break;
                case 3:
                    dataGridViewTransports_TIS.Rows.Clear();
                    foreach (var item in transports)
                    {
                        if (item.Type == TransportType.Subway)
                        {
                            dataGridViewTransports_TIS.Rows.Add(item.ToString().Split(' '));
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private bool CheckTextBoxTransportNumber() => textBoxTransportNumber_TIS.Text.Length != 0;

        private void textBoxTransportNumber_TIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonNumberSearch_TIS_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxTransportNumber())
            {
                comboBoxTransportType_TIS.SelectedIndex = -1;
                dataGridViewTransports_TIS.Rows.Clear();

                foreach (var item in transports)
                {
                    if (item.RouteNumber == Convert.ToInt32(textBoxTransportNumber_TIS.Text))
                    {
                        dataGridViewTransports_TIS.Rows.Add(item.ToString().Split(' '));
                    }
                }

                if (dataGridViewTransports_TIS.Rows.Count == 1)
                {
                    MessageBox.Show("Записей не найдено!");
                }

                textBoxTransportNumber_TIS.Clear();
            }
        }
    }
}
