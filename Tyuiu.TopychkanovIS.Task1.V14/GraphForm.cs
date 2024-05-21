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
            int xValue = 0;

            var transportTypeTranslations = new Dictionary<TransportType, string>
        {
            { TransportType.Bus, "Автобус" },
            { TransportType.Shuttle, "Маршрутка" },
            { TransportType.Streetcar, "Трамвай" },
            { TransportType.Subway, "Метро" }
        };

            foreach (var item in Enum.GetValues(typeof(TransportType)).Cast<TransportType>())
            {
                string translatedLabel = transportTypeTranslations[item];
                CustomLabel label = new CustomLabel(xValue - 0.5, xValue + 0.5, translatedLabel, 0, LabelMarkStyle.None);
                chartTransports_TIS.ChartAreas[0].AxisX.CustomLabels.Add(label);

                int count = transports.Count(tr => tr.Type == item);

                chartTransports_TIS.Series[0].Points.AddXY(xValue, count);

                xValue++;
            }
        }
    }
}
