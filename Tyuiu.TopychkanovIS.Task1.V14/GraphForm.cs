using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.TopychkanovIS.Task1.V14
{
    public partial class GraphForm : Form
    {
        List<Transport> transports = new List<Transport>();
        public GraphForm(List<Transport> transports)
        {
            InitializeComponent();
            this.transports = transports;
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            int countType = 2;
            int start = 0;
            int end = transports.Count;
            foreach (var item in Enum.GetValues(typeof(TransportType)))
            {
                CustomLabel label = new CustomLabel(start, end, item.ToString(), 0, LabelMarkStyle.None);
                chartTransports_TIS.ChartAreas[0].AxisX.CustomLabels.Add(label);
                start++;
                end++;
                int count = 0;
                countType++;
                foreach (var tr in transports)
                {
                    if (tr.Type == (TransportType)item)
                    {
                        count++;
                    }
                }
                chartTransports_TIS.Series[0].Points.AddXY(countType, count);
            }
        }
    }
}
