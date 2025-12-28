using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ZedGraph;
using System.Security.Cryptography;

namespace DatumSchreibenArduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] Baudrate = { "1200", "2400", "4800", "9600", "115200" };
            baudBox.Items.AddRange(Baudrate);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comPortBox.DataSource = SerialPort.GetPortNames();
            baudBox.Text = "9600";
            // Zedgraph
            GraphPane meinPane = tempGraph.GraphPane;
            meinPane.Title.Text = "Temperaturwerte";
            meinPane.YAxis.Title.Text = "Werte";
            meinPane.XAxis.Title.Text = "Zeit";
            RollingPointPairList meineListe = new RollingPointPairList(500000);
            LineItem meineLinie = meinPane.AddCurve("Temperatur", meineListe, Color.Red, SymbolType.Diamond);
            // Limit
            meinPane.XAxis.Scale.Min = 0;
            meinPane.XAxis.Scale.Max = 50;
            meinPane.XAxis.Scale.MinorStep = 1;
            meinPane.XAxis.Scale.MajorStep = 2;
            meinPane.YAxis.Scale.Min = 0;
            meinPane.YAxis.Scale.Max = 50;
            meinPane.YAxis.Scale.MinorStep = 1;
            meinPane.YAxis.Scale.MajorStep = 2;
            tempGraph.AxisChange();
        }
        int summe = 0;
        public void zeichnen(double meineLinie)
        {
            LineItem linie = tempGraph.GraphPane.CurveList[0] as LineItem;
            if(linie == null)
            {
                return;
            }
            IPointListEdit meineListe = linie.Points as IPointListEdit;
            if (meineListe == null)
            {
                return;
            }
            meineListe.Add(summe, meineLinie);
            tempGraph.AxisChange();
            tempGraph.Invalidate();
            summe += 2;
        }

        private void ausAllBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     
        private void einAllBut_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                einAllBut.Text = "CONNECTED";
                serCOM.PortName = comPortBox.Text;
                serCOM.BaudRate = Convert.ToInt32(baudBox.Text);
                serCOM.Open();
            }
            else
            {
                einAllBut.Text = "DISCONNECTED";
                serCOM.Close();
            }
        }

        private void sendBut_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                MessageBox.Show("Click the CONNECT button!");
            }
            else
            {
                String datum = dataSendTxt.Text;
                serCOM.Write(datum);
            }
        }

        private void serCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String dataRec = "";
            dataRec = serCOM.ReadLine();      
            dataRec = dataRec.Trim();
            int laen = dataRec.Length;
            if(laen > 0)
            {
                int tSig = dataRec.IndexOf("!");
                int lSig = dataRec.IndexOf("@");
                int sSig = dataRec.IndexOf("#");

                String temp = dataRec.Substring(tSig+1, lSig-tSig-1);
                alarmTxt.Text = dataRec.Substring(lSig+1, sSig-lSig-1);
                String sollwert = dataRec.Substring(sSig+1, laen-sSig-1);


                actTempTxt.Text = temp;
                Invoke(new MethodInvoker(() => zeichnen(Convert.ToDouble(temp))));

                if (Convert.ToDouble(temp) >= Convert.ToDouble(sollwert))
                    statusLb.Text = "UE.H";
                else
                    statusLb.Text = "STAB";
            }                      
        }

    }
}
