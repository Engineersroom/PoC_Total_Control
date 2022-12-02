using Ivi.Visa;
using Keysight.Visa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ivi.Visa;
using Ivi.Visa.FormattedIO;
using System.Runtime.InteropServices;
using System.Threading;

namespace POC_Constrol
{
    public partial class Total_control : Form
    {
        [DllImport("C:\\Users\\MSI\\Documents\\Eunsang\\program\\C_sharp\\POC_Constrol\\POC_Constrol\\obj\\Debug\\FMC4030-Dll", CallingConvention = CallingConvention.StdCall)]
        unsafe public static extern int FMC4030_Open_Device(int id, StringBuilder ip, int port);

        [DllImport("C:\\Users\\MSI\\Documents\\Eunsang\\program\\C_sharp\\POC_Constrol\\POC_Constrol\\obj\\Debug\\FMC4030-Dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FMC4030_Close_Device(int id);

        public Total_control()
        {
            InitializeComponent();
        }

        private void Total_control_Load(object sender, EventArgs e)
        {
            txtTestGPIBPortName.Text = "GPIB0::18::INSTR";
            textBox2.Text = ":FREQuency:SPAN 1 MHz";
            txtTestID.Text = "1";
            txtTestIP.Text = "192.168.0.30";
            txtTestPort.Text = "8088";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GpibSession session = new GpibSession(txtTestGPIBPortName.Text, Ivi.Visa.AccessModes.None, 2000);

            IMessageBasedFormattedIO io = session.FormattedIO;
            io.PrintfAndFlush("*IDN?");
            string[] response = new string[] { "", "", "", "" };
            io.Scanf("%,s", out response);
            txtTestGPIBID.Text = response[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GpibSession session = new GpibSession(txtTestGPIBPortName.Text, Ivi.Visa.AccessModes.None, 2000);
            IMessageBasedFormattedIO io = session.FormattedIO;
            io.PrintfAndFlush(textBox2.Text);
        }

        private void btnMotorConnectionTest_Click(object sender, EventArgs e)
        {
            int returnVal = 0;
            StringBuilder _input = new StringBuilder(txtTestIP.Text);

            returnVal = FMC4030_Close_Device(int.Parse(txtTestID.Text));
            txtTestBeforeConnectionState.Text = returnVal.ToString();
            Thread.Sleep(100);

            returnVal = FMC4030_Open_Device(int.Parse(txtTestID.Text), _input, int.Parse(txtTestPort.Text));
            txtTestNowConnectionState2.Text = returnVal.ToString();
            Thread.Sleep(100);

            returnVal = FMC4030_Close_Device(int.Parse(txtTestID.Text));
            txtTestEndConnectionState.Text = returnVal.ToString();
            Thread.Sleep(100);

        }
    }
}
