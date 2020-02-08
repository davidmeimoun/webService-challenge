using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webService_challenge;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Form1));
        private BusyForm busyForm = new BusyForm();

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            log.Info("Button1 click");
            busyForm.Show();
            this.Enabled = false;
            WebService1 webservice = new WebService1();

            try
            {
                log.Debug("Start Fibonacci");
                string fibonacciResult = await webservice.Fibonacci(10, true);
                busyForm.Hide();
                this.Enabled = true;
                log.Info("fibonacciResult: " + fibonacciResult);
                MessageBox.Show(fibonacciResult);
            }
            catch (Exception ex)
            {
                log.Error("An error occurred: " + ex.ToString());
                busyForm.Hide();
                this.Enabled = true;
                MessageBox.Show("An error occurred: " + ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Debug("Form1 load");
        }
    }
}
