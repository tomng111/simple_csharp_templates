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
        }

        private void ein1But_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
                MessageBox.Show("Click the CONNECT button");
            else
                serCOM.Write("e1");                
        }

        private void ausAllBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ein2But_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
                MessageBox.Show("Click the CONNECT button");
            else
                serCOM.Write("e2");
        }

        private void aus1But_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
                MessageBox.Show("Click the CONNECT button");
            else
                serCOM.Write("a1");
        }

        private void aus2But_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
                MessageBox.Show("Click the CONNECT button");
            else
                serCOM.Write("a2");
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
            String datum = dataSendTxt.Text;
            serCOM.Write(datum);
        }

        private void serCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String dataRec = "";
            dataRec = serCOM.ReadLine();
            disTxt.Text = dataRec;
        }
    }
}
