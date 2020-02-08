using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BusyForm : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BusyForm));
        public BusyForm()
        {
            InitializeComponent();
        }

        private void BusyForm_Load(object sender, EventArgs e)
        {
            log.Debug("BusyForm load");
            this.ControlBox = false;
        }
    }
}
